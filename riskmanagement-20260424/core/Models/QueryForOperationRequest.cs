// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RiskManagement20260424.Models
{
    public class QueryForOperationRequest : TeaModel {
        /// <summary>
        /// <para>The end time of the application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1791937232000</para>
        /// </summary>
        [NameInMap("ApplyTimeEnd")]
        [Validation(Required=false)]
        public long? ApplyTimeEnd { get; set; }

        /// <summary>
        /// <para>The start time of the application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1791937132000</para>
        /// </summary>
        [NameInMap("ApplyTimeStart")]
        [Validation(Required=false)]
        public long? ApplyTimeStart { get; set; }

        /// <summary>
        /// <para>The asset type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>EIP</b>: VPC public IP address.</description></item>
        /// <item><description><b>SLB</b>: load balancing.</description></item>
        /// <item><description><b>ECS</b>: Public IP address in the classic network.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>EIP</para>
        /// </summary>
        [NameInMap("AssetType")]
        [Validation(Required=false)]
        public string AssetType { get; set; }

        /// <summary>
        /// <para>The end time of the review.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1791937232000</para>
        /// </summary>
        [NameInMap("AuditTimeEnd")]
        [Validation(Required=false)]
        public long? AuditTimeEnd { get; set; }

        /// <summary>
        /// <para>The start time of the review.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1791937132000</para>
        /// </summary>
        [NameInMap("AuditTimeStart")]
        [Validation(Required=false)]
        public long? AuditTimeStart { get; set; }

        /// <summary>
        /// <para>The current page number.</para>
        /// <remarks>
        /// <para>Default value: 1.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The customer UID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1647796581073291</para>
        /// </summary>
        [NameInMap("CustomerUid")]
        [Validation(Required=false)]
        public string CustomerUid { get; set; }

        /// <summary>
        /// <para>IP</para>
        /// 
        /// <b>Example:</b>
        /// <para>12.3*.22.11</para>
        /// </summary>
        [NameInMap("Ip")]
        [Validation(Required=false)]
        public string Ip { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The task status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>auditing</b>: Under review.</description></item>
        /// <item><description><b>approved</b>: Approved.</description></item>
        /// <item><description><b>rejected</b>: Rejected.</description></item>
        /// <item><description><b>effective</b>: Effective.</description></item>
        /// <item><description><b>ineffective</b>: Ineffective.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>approved</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
