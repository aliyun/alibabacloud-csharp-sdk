// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class SenderStatisticsByTagNameAndBatchIDRequest : TeaModel {
        /// <summary>
        /// <para>The sender address. If this parameter is not specified, data for all addresses is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// <para>For dedicated IP users, specifies a dedicated IP address to query data for.</para>
        /// <para>If this parameter is not specified, data for all dedicated IP addresses is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx.xxx.xxx.xxx</para>
        /// </summary>
        [NameInMap("DedicatedIp")]
        [Validation(Required=false)]
        public string DedicatedIp { get; set; }

        /// <summary>
        /// <para>For dedicated IP users, specifies the ID of a dedicated IP pool to query data for.</para>
        /// <para>If this parameter is not specified, data for all dedicated IP pools is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("DedicatedIpPoolId")]
        [Validation(Required=false)]
        public string DedicatedIpPoolId { get; set; }

        /// <summary>
        /// <para>The sender domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dmdomain.com</para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <para>The end time. The time span between the start time and end time cannot exceed 31 days. Format: yyyy-MM-dd.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-09-29</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>For dedicated IP users, specifies a particular ESP to query data for. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>gmail.com</description></item>
        /// <item><description>yahoo.com</description></item>
        /// <item><description>outlook.com</description></item>
        /// <item><description>icloud.com</description></item>
        /// <item><description>others: data for ESPs other than the ones listed above.</description></item>
        /// </list>
        /// <para>If this parameter is not specified, data for all ESPs is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gmail.com</para>
        /// </summary>
        [NameInMap("Esp")]
        [Validation(Required=false)]
        public string Esp { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The start time. The time cannot be earlier than 90 days ago. Format: yyyy-MM-dd.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-09-29</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The email tag. If this parameter is not specified, data for all tags is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("TagName")]
        [Validation(Required=false)]
        public string TagName { get; set; }

    }

}
