// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Amqp_open20191212.Models
{
    public class CreateAccountRequest : TeaModel {
        /// <summary>
        /// <para>The remarks on the static user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>*** environment</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>The AccessKey ID of your Alibaba Cloud account or RAM user. For more information about how to obtain an AccessKey ID, see <a href="https://help.aliyun.com/document_detail/116401.html">Create an AccessKey</a>.</para>
        /// <remarks>
        /// <para>If you use the AccessKey of a RAM user to create a static username and password to access ApsaraMQ for RabbitMQ and to send and receive messages, make sure that the RAM user is granted the required permissions. For more information, see <a href="https://help.aliyun.com/document_detail/146559.html">RAM access policies</a>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yourAccessKeyID</para>
        /// </summary>
        [NameInMap("accountAccessKey")]
        [Validation(Required=false)]
        public string AccountAccessKey { get; set; }

        /// <summary>
        /// <para>The timestamp that indicates when the username and password are created. Unit: milliseconds.</para>
        /// <remarks>
        /// <para>This timestamp is used to calculate the static password. You can customize this value. This is not the timestamp that the system generates when the username and password are created.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1671175303522</para>
        /// </summary>
        [NameInMap("createTimestamp")]
        [Validation(Required=false)]
        public long? CreateTimestamp { get; set; }

        /// <summary>
        /// <para>The ID of the ApsaraMQ for RabbitMQ instance. This specifies the instance for which you want to create a static username and password.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amqp-cn-*********</para>
        /// </summary>
        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The signature of the AccessKey secret. The system calculates the static password based on the signature, the AccessKey secret signature, and the username.</para>
        /// <para>The AccessKey secret signature is calculated using the HmacSHA1 algorithm on the creation timestamp of the specified username and the AccessKey ID. For more information about how to calculate the signature, see the <b>Signature algorithm sample code</b> section in this topic.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4c1a6367ce4c4255e9617326f9133ac635******</para>
        /// </summary>
        [NameInMap("secretSign")]
        [Validation(Required=false)]
        public string SecretSign { get; set; }

        /// <summary>
        /// <para>The signature. The system calculates the static password based on the signature, the AccessKey secret signature, and the username.</para>
        /// <para>The signature is calculated using the HmacSHA1 algorithm on the creation timestamp of the specified username and the AccessKey ID. For more information about how to calculate the signature, see the <b>Signature algorithm sample code</b> section in this topic.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>22c2d7d1769cb53c5a6d9213248e2de524******</para>
        /// </summary>
        [NameInMap("signature")]
        [Validation(Required=false)]
        public string Signature { get; set; }

        /// <summary>
        /// <para>The static username that you want to create.</para>
        /// <para>The value of this parameter is a Base64-encoded string that is constructed from the instance ID and the AccessKey ID. For more information about how to calculate the value, see the <b>Username calculation sample code</b> section in this topic.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Mjo****************</para>
        /// </summary>
        [NameInMap("userName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
