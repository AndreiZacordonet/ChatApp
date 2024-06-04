using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using MessageNamespace;

namespace MessageModuleTest
{
    [TestClass]
    public class MessageTest
    {
        [TestMethod]
        public void TestSerializationWithChatMsgType()
        {
            // Arrange
            var body = new Dictionary<string, string> { { "text", "Hello Dl Polaru!" } };
            var message = new Message(MessageType.ChatMsg, "Andrei", "Dl Polaru", body);

            // Act
            string json = Message.ToJson(message);
            Message deserializedMessage = Message.FromJson(json);

            // Assert
            Assert.AreEqual(message.Type, deserializedMessage.Type);
            Assert.AreEqual(message.Sender, deserializedMessage.Sender);
            Assert.AreEqual(message.Receiver, deserializedMessage.Receiver);
            CollectionAssert.AreEqual(message.Body, deserializedMessage.Body);
        }

        [TestMethod]
        public void TestSerializationWithRegisterType()
        {
            // Arrange
            var body = new Dictionary<string, string> { { "username", "Polaru" }, { "password", "123Dl1223Polaru!" } };
            var message = new Message(MessageType.Register, "Eusebiu", "Server", body);

            // Act
            string json = Message.ToJson(message);
            Message deserializedMessage = Message.FromJson(json);

            // Assert
            Assert.AreEqual(message.Type, deserializedMessage.Type);
            Assert.AreEqual(message.Sender, deserializedMessage.Sender);
            Assert.AreEqual(message.Receiver, deserializedMessage.Receiver);
            CollectionAssert.AreEqual(message.Body, deserializedMessage.Body);
        }

        [TestMethod]
        public void TestSerializationWithLoginType()
        {
            // Arrange
            var body = new Dictionary<string, string> { { "username", "Eusebiu" }, { "password", "123Dl1223Polaru!" } };
            var message = new Message(MessageType.Login, "Eusebiu", "Server", body);

            // Act
            string json = Message.ToJson(message);
            Message deserializedMessage = Message.FromJson(json);

            // Assert
            Assert.AreEqual(message.Type, deserializedMessage.Type);
            Assert.AreEqual(message.Sender, deserializedMessage.Sender);
            Assert.AreEqual(message.Receiver, deserializedMessage.Receiver);
            CollectionAssert.AreEqual(message.Body, deserializedMessage.Body);
        }

        [TestMethod]
        public void TestSerializationWithLogoutType()
        {
            // Arrange
            var body = new Dictionary<string, string> { { "body", "Logging out" } };
            var message = new Message(MessageType.Logout, "DaveSapun", "Server", body);

            // Act
            string json = Message.ToJson(message);
            Message deserializedMessage = Message.FromJson(json);

            // Assert
            Assert.AreEqual(message.Type, deserializedMessage.Type);
            Assert.AreEqual(message.Sender, deserializedMessage.Sender);
            Assert.AreEqual(message.Receiver, deserializedMessage.Receiver);
            CollectionAssert.AreEqual(message.Body, deserializedMessage.Body);
        }

        [TestMethod]
        public void TestSerializationWithUnknownType()
        {
            // Arrange
            var body = new Dictionary<string, string> { { "data", "Unknown message data" } };
            var message = new Message(MessageType.ServerError, "UnknownSender", "UnknownReceiver", body);

            // Act
            string json = Message.ToJson(message);
            Message deserializedMessage = Message.FromJson(json);

            // Assert
            Assert.AreEqual(message.Type, deserializedMessage.Type);
            Assert.AreEqual(message.Sender, deserializedMessage.Sender);
            Assert.AreEqual(message.Receiver, deserializedMessage.Receiver);
            CollectionAssert.AreEqual(message.Body, deserializedMessage.Body);
        }
    }
}
