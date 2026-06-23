// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Amqp_open20191212.Models
{
    public class CreateAccountResponseBody : TeaModel {
        /// <summary>
        /// <para>The return code. A value of 200 indicates that the request was successful.</para>
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
            /// <para>The AccessKey ID that is used to create the username and password.</para>
            /// 
            /// <b>Example:</b>
            /// <para>LTAI****************</para>
            /// </summary>
            [NameInMap("AccessKey")]
            [Validation(Required=false)]
            public string AccessKey { get; set; }

            /// <summary>
            /// <para>The timestamp when the username and password were created. Unit: milliseconds.</para>
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
            /// <para>The ID of the Alibaba Cloud account or RAM user that owns the AccessKey. The AccessKey is used to create the static username and password.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1565***********01</para>
            /// </summary>
            [NameInMap("MasterUId")]
            [Validation(Required=false)]
            public long? MasterUId { get; set; }

            /// <summary>
            /// <para>The created static password.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OUYwQzM2QjZBRkUxNDRFM***************MzZCNzdDQzoxNjcxNDMwMzkyODI1</para>
            /// </summary>
            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }

            /// <summary>
            /// <para>The remarks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>*** environment</para>
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
        /// <para>FEBA5E0C-50D0-4FA6-A794-4901E5465***</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
