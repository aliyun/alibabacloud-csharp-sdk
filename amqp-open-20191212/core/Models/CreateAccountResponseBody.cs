// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Amqp_open20191212.Models
{
    public class CreateAccountResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code. The status code 200 indicates that the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateAccountResponseBodyData Data { get; set; }
        public class CreateAccountResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The AccessKey ID that is used to create the password.</para>
            /// 
            /// <b>Example:</b>
            /// <para>LTAI****************</para>
            /// </summary>
            [NameInMap("AccessKey")]
            [Validation(Required=false)]
            public string AccessKey { get; set; }

            /// <summary>
            /// <para>The timestamp that indicates when the password was created. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1671175303522</para>
            /// </summary>
            [NameInMap("CreateTimeStamp")]
            [Validation(Required=false)]
            public long? CreateTimeStamp { get; set; }

            /// <summary>
            /// <para>The ID of the ApsaraMQ for RabbitMQ instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>amqp-cn-*********</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud account ID or RAM user to which the AccessKey pair that is used to create the static username and password belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>15657*********01</para>
            /// </summary>
            [NameInMap("MasterUId")]
            [Validation(Required=false)]
            public long? MasterUId { get; set; }

            /// <summary>
            /// <para>The created static password.</para>
            /// 
            /// <b>Example:</b>
            /// <para>NEMxQTYzNjdDRTVDNDI1NUU5NjE3**************1MzNGODoxNjcxMTc1MzEzNTIy</para>
            /// </summary>
            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>***环境</para>
            /// </summary>
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            /// <summary>
            /// <para>The created static username.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MjphbXFwLWNuLXVxbTJ6cjc2djAwMzpMVEFJNX*******ZNMWVSWnRFSjZ2Zm8=</para>
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>operation success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>92385FD2-624A-48C9-8FB5-753F2AFA***</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
