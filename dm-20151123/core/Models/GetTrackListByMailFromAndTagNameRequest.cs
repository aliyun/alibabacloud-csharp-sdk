// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class GetTrackListByMailFromAndTagNameRequest : TeaModel {
        /// <summary>
        /// <para>The sender address.</para>
        /// <remarks>
        /// <para>If you leave this parameter empty, data for all addresses is returned. This parameter is required if you specify TagName.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:e-service@amegroups.cn">e-service@amegroups.cn</a></para>
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// <para>The configuration set ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("ConfigSetId")]
        [Validation(Required=false)]
        public string ConfigSetId { get; set; }

        /// <summary>
        /// <para>The dedicated IP address. This parameter is available only for users of dedicated IPs.</para>
        /// <para>If you do not specify this parameter, data for all IPs is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx.xxx.xxx.xxx</para>
        /// </summary>
        [NameInMap("DedicatedIp")]
        [Validation(Required=false)]
        public string DedicatedIp { get; set; }

        /// <summary>
        /// <para>The ID of the dedicated IP pool. This parameter is available only for users of dedicated IPs.</para>
        /// <para>If you do not specify this parameter, data for all IP pools is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("DedicatedIpPoolId")]
        [Validation(Required=false)]
        public string DedicatedIpPoolId { get; set; }

        /// <summary>
        /// <para>The end time. The time span between the start time and end time cannot exceed 15 days. The format is yyyy-MM-dd.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-09-29</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The Email Service Provider (ESP). This parameter is available only for users of dedicated IPs. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>gmail.com</para>
        /// </description></item>
        /// <item><description><para>yahoo.com</para>
        /// </description></item>
        /// <item><description><para>outlook.com</para>
        /// </description></item>
        /// <item><description><para>icloud.com</para>
        /// </description></item>
        /// <item><description><para>others (data for ESPs other than the ones listed above)</para>
        /// </description></item>
        /// </list>
        /// <para>If you do not specify this parameter, data for all ESPs is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gmail.com</para>
        /// </summary>
        [NameInMap("Esp")]
        [Validation(Required=false)]
        public string Esp { get; set; }

        /// <summary>
        /// <para>The value is 0 for the first query and 1 for subsequent queries. A value of 1 indicates a paged query in chronological order. (This field is deprecated)</para>
        /// 
        /// <b>Example:</b>
        /// <para>（本字段已废弃）</para>
        /// </summary>
        [NameInMap("Offset")]
        [Validation(Required=false)]
        public string Offset { get; set; }

        /// <summary>
        /// <para>Used for paging. Do not set this parameter for the first query. For subsequent queries, set this parameter to the OffsetCreateTime value from the previous response. (This field is deprecated)</para>
        /// 
        /// <b>Example:</b>
        /// <para>（本字段已废弃）</para>
        /// </summary>
        [NameInMap("OffsetCreateTime")]
        [Validation(Required=false)]
        public string OffsetCreateTime { get; set; }

        /// <summary>
        /// <para>(This field is deprecated)</para>
        /// 
        /// <b>Example:</b>
        /// <para>（本字段已废弃）</para>
        /// </summary>
        [NameInMap("OffsetCreateTimeDesc")]
        [Validation(Required=false)]
        public string OffsetCreateTimeDesc { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The start time. The time cannot be earlier than 30 days ago. The format is yyyy-MM-dd.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-09-29</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The email tag. If you leave this parameter empty, data for all tags is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Subscription</para>
        /// </summary>
        [NameInMap("TagName")]
        [Validation(Required=false)]
        public string TagName { get; set; }

        /// <summary>
        /// <para>(This field is deprecated)</para>
        /// 
        /// <b>Example:</b>
        /// <para>（本字段已废弃）</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public string Total { get; set; }

    }

}
