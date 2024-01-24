// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Amqp_open20191212.Models
{
    public class CreateAccountResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code. The status code 200 indicates that the request was successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateAccountResponseBodyData Data { get; set; }
        public class CreateAccountResponseBodyData : TeaModel {
            /// <summary>
            /// The AccessKey ID that is used to create the password.
            /// </summary>
            [NameInMap("AccessKey")]
            [Validation(Required=false)]
            public string AccessKey { get; set; }

            /// <summary>
            /// The timestamp that indicates when the password was created. Unit: milliseconds.
            /// </summary>
            [NameInMap("CreateTimeStamp")]
            [Validation(Required=false)]
            public long? CreateTimeStamp { get; set; }

            /// <summary>
            /// The ID of the ApsaraMQ for RabbitMQ instance.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The Alibaba Cloud account ID or RAM user to which the AccessKey pair that is used to create the static username and password belongs.
            /// </summary>
            [NameInMap("MasterUId")]
            [Validation(Required=false)]
            public long? MasterUId { get; set; }

            /// <summary>
            /// The created static password.
            /// </summary>
            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }

            /// <summary>
            /// The created static username.
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the call is successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
