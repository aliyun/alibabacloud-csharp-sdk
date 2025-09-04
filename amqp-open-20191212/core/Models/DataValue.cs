// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Amqp_open20191212.Models
{
    public class DataValue : TeaModel {
        /// <summary>
        /// <para>The Alibaba Cloud account ID or Resource Access Management (RAM) user to which the AccessKey pair that is used to create the static username and password belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1565************1</para>
        /// </summary>
        [NameInMap("masterUid")]
        [Validation(Required=false)]
        public long? MasterUid { get; set; }

        /// <summary>
        /// <para>The ID of the ApsaraMQ for RabbitMQ instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amqp-cn-uqm******03</para>
        /// </summary>
        [NameInMap("cInstanceId")]
        [Validation(Required=false)]
        public string CInstanceId { get; set; }

        /// <summary>
        /// <para>The AccessKey ID that is used to create the static username and password.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LTAI****************</para>
        /// </summary>
        [NameInMap("accessKey")]
        [Validation(Required=false)]
        public string AccessKey { get; set; }

        /// <summary>
        /// <para>The static username.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MjphbXFwLWNuLXVxbTJ6cjc2djAwMzpMVEFJNX*******ZNMWVSWnRFSjZ2Zm8=</para>
        /// </summary>
        [NameInMap("userName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

        /// <summary>
        /// <para>The static password.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OUYwQzM2QjZBRkUxNDRFM***************MzZCNzdDQzoxNjcxNDMwMzkyODI1</para>
        /// </summary>
        [NameInMap("password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>The timestamp that indicates when the static username and password were deleted. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1671175303522</para>
        /// </summary>
        [NameInMap("deleted")]
        [Validation(Required=false)]
        public long? Deleted { get; set; }

        /// <summary>
        /// <para>The timestamp that indicates when the static username and password were created. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1671175303522</para>
        /// </summary>
        [NameInMap("createTimestamp")]
        [Validation(Required=false)]
        public long? CreateTimestamp { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>***环境</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

    }

}
