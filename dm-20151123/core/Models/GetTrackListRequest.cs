// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class GetTrackListRequest : TeaModel {
        /// <summary>
        /// <para>The sender address.</para>
        /// <remarks>
        /// <para>If you omit this parameter, the query returns data for all sender addresses. This parameter is required if you specify the <c>TagName</c> parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:test@example.com">test@example.com</a></para>
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// <para>The ID of the configuration set.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("ConfigSetId")]
        [Validation(Required=false)]
        public string ConfigSetId { get; set; }

        /// <summary>
        /// <para>The dedicated IP address to query.</para>
        /// <para>If this parameter is omitted, data for all dedicated IPs is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx.xxx.xxx.xxx</para>
        /// </summary>
        [NameInMap("DedicatedIp")]
        [Validation(Required=false)]
        public string DedicatedIp { get; set; }

        /// <summary>
        /// <para>The ID of the dedicated IP pool to query.</para>
        /// <para>If this parameter is omitted, data for all IP pools is returned.</para>
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
        /// <para>The end date of the query. The duration between the StartTime and EndTime cannot exceed 7 days. The format is <c>yyyy-MM-dd</c>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-09-29</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The Email Service Provider (ESP) to query. Valid values are:</para>
        /// <list type="bullet">
        /// <item><description><para>gmail.com</para>
        /// </description></item>
        /// <item><description><para>yahoo.com</para>
        /// </description></item>
        /// <item><description><para>outlook.com</para>
        /// </description></item>
        /// <item><description><para>icloud.com</para>
        /// </description></item>
        /// <item><description><para>Others: Any ESP not listed above.</para>
        /// </description></item>
        /// </list>
        /// <para>If you omit this parameter, the query returns data for all ESPs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gmail.com</para>
        /// </summary>
        [NameInMap("Esp")]
        [Validation(Required=false)]
        public string Esp { get; set; }

        /// <summary>
        /// <para>Set this to 0 for the first query. For subsequent queries, set it to 1 to perform a paged query in chronological order. (This field is deprecated)</para>
        /// 
        /// <b>Example:</b>
        /// <para>（本字段已废弃）</para>
        /// </summary>
        [NameInMap("Offset")]
        [Validation(Required=false)]
        public string Offset { get; set; }

        /// <summary>
        /// <para>Used for pagination. Do not set this parameter for the first query. For subsequent queries, set this parameter to the <c>OffsetCreateTime</c> value returned in the previous response. (This field is deprecated)</para>
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
        /// <para>The page number to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page.</para>
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
        /// <para>The start date of the query. The date must be within the last 30 days. The format is <c>yyyy-MM-dd</c>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-09-29</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The tag name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tagname</para>
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
