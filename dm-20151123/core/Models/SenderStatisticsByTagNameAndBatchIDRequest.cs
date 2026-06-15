// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class SenderStatisticsByTagNameAndBatchIDRequest : TeaModel {
        /// <summary>
        /// <para>The sender address. If you do not specify this parameter, statistics for all sender addresses are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// <para>If you use Dedicated IPs, use this parameter to filter statistics by a specific Dedicated IP.</para>
        /// <para>If you do not specify this parameter, statistics for all dedicated IPs that match the other criteria are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx.xxx.xxx.xxx</para>
        /// </summary>
        [NameInMap("DedicatedIp")]
        [Validation(Required=false)]
        public string DedicatedIp { get; set; }

        /// <summary>
        /// <para>If you use Dedicated IPs, specify the ID of the dedicated IP pool to query.</para>
        /// <para>If you do not specify this parameter, statistics for all resources are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("DedicatedIpPoolId")]
        [Validation(Required=false)]
        public string DedicatedIpPoolId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dmdomain.com</para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <para>The end time for the query. The time range between <c>StartTime</c> and <c>EndTime</c> cannot exceed 7 days. The format must be <c>YYYY-MM-DD</c>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-09-29</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>If you use Dedicated IPs, use this parameter to filter statistics by a specific Email Service Provider (ESP). Valid values are:</para>
        /// <list type="bullet">
        /// <item><description><para><c>gmail.com</c></para>
        /// </description></item>
        /// <item><description><para><c>yahoo.com</c></para>
        /// </description></item>
        /// <item><description><para><c>outlook.com</c></para>
        /// </description></item>
        /// <item><description><para><c>icloud.com</c></para>
        /// </description></item>
        /// <item><description><para><c>others</c> (matches data for all other ESPs)</para>
        /// </description></item>
        /// </list>
        /// <para>If you do not specify this parameter, statistics for all ESPs are returned.</para>
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
        /// <para>The start time for the query. The date cannot be more than 30 days in the past. The format must be <c>YYYY-MM-DD</c>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-09-29</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The email tag. If you do not specify this parameter, statistics for all tags are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("TagName")]
        [Validation(Required=false)]
        public string TagName { get; set; }

    }

}
