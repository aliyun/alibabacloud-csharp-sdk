// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Amqp_open20191212.Models
{
    public class CreateAccountRequest : TeaModel {
        /// <summary>
        /// The AccessKey ID of your Alibaba Cloud account or RAM user. For information about how to obtain an AccessKey pair, see [Create an AccessKey pair](~~116401~~).
        /// 
        /// >  If you use the pair of static username and password that is created by using the Accesskey pair of a RAM user to access ApsaraMQ for RabbitMQ to send and receive messages, make sure that the RAM user is granted the required permissions. For more information, see [RAM policies](~~146559~~).
        /// </summary>
        [NameInMap("accountAccessKey")]
        [Validation(Required=false)]
        public string AccountAccessKey { get; set; }

        /// <summary>
        /// The timestamp that indicates when the password is created. Unit: milliseconds.
        /// 
        /// >  This timestamp is specified by you and is used to generate a static password. The timestamp is not the timestamp that indicates when the system generates the password.
        /// </summary>
        [NameInMap("createTimestamp")]
        [Validation(Required=false)]
        public long? CreateTimestamp { get; set; }

        /// <summary>
        /// The ID of the instance for which you want to create a pair of static username and password.
        /// </summary>
        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The AccessKey secret signature. The system generates a static password based on the signature in the request, the AccessKey secret signature, and the username.
        /// 
        /// The system uses the HMAC-SHA1 algorithm to generate the AccessKey secret signature based on the timestamp that indicates when the username is created and the AccessKey ID. For more information, see the **"Sample code on how to generate a signature"** section of this topic.
        /// </summary>
        [NameInMap("secretSign")]
        [Validation(Required=false)]
        public string SecretSign { get; set; }

        /// <summary>
        /// The signature. The system generates a static password based on the signature in the request, the AccessKey secret signature, and the username.
        /// 
        /// The system uses the HMAC-SHA1 algorithm to generate the signature based on the timestamp that indicates when the username is created and the AccessKey ID. For more information, see the **"Sample code on how to generate a signature"** section of this topic.
        /// </summary>
        [NameInMap("signature")]
        [Validation(Required=false)]
        public string Signature { get; set; }

        /// <summary>
        /// The static username that you want to create.
        /// 
        /// The value of this parameter is a Base64-encoded string that is generated based on the instance ID and AccessKey ID. For more information, see the "**Sample code on how to generate a username**" section of this topic.
        /// </summary>
        [NameInMap("userName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
