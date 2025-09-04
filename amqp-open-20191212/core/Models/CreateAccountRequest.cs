// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Amqp_open20191212.Models
{
    public class CreateAccountRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>***环境</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>The AccessKey ID of your Alibaba Cloud account or RAM user. For information about how to obtain an AccessKey pair, see <a href="https://help.aliyun.com/document_detail/116401.html">Create an AccessKey pair</a>.</para>
        /// <remarks>
        /// <para> If you use the pair of static username and password that is created by using the Accesskey pair of a RAM user to access ApsaraMQ for RabbitMQ to send and receive messages, make sure that the RAM user is granted the required permissions. For more information, see <a href="https://help.aliyun.com/document_detail/146559.html">RAM policies</a>.</para>
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
        /// <para>The timestamp that indicates when the password is created. Unit: milliseconds.</para>
        /// <remarks>
        /// <para> This timestamp is specified by you and is used to generate a static password. The timestamp is not the timestamp that indicates when the system generates the password.</para>
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
        /// <para>The ID of the instance for which you want to create a pair of static username and password.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amqp-cn-*********</para>
        /// </summary>
        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The AccessKey secret signature. The system generates a static password based on the signature in the request, the AccessKey secret signature, and the username.</para>
        /// <para>The system uses the HMAC-SHA1 algorithm to generate the AccessKey secret signature based on the timestamp that indicates when the username is created and the AccessKey ID. For more information, see the <b>&quot;Sample code on how to generate a signature&quot;</b> section of this topic.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4c1a6367ce4c4255e9617326f9133ac635******</para>
        /// </summary>
        [NameInMap("secretSign")]
        [Validation(Required=false)]
        public string SecretSign { get; set; }

        /// <summary>
        /// <para>The signature. The system generates a static password based on the signature in the request, the AccessKey secret signature, and the username.</para>
        /// <para>The system uses the HMAC-SHA1 algorithm to generate the signature based on the timestamp that indicates when the username is created and the AccessKey ID. For more information, see the <b>&quot;Sample code on how to generate a signature&quot;</b> section of this topic.</para>
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
        /// <para>The value of this parameter is a Base64-encoded string that is generated based on the instance ID and AccessKey ID. For more information, see the &quot;<b>Sample code on how to generate a username</b>&quot; section of this topic.</para>
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
