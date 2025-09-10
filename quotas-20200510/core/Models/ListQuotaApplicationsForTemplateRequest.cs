// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class ListQuotaApplicationsForTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The UTC time when the quota application ends.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-05-22T16:00:00Z</para>
        /// </summary>
        [NameInMap("ApplyEndTime")]
        [Validation(Required=false)]
        public string ApplyEndTime { get; set; }

        /// <summary>
        /// <para>The UTC time when the quota application starts.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-05-22T16:00:00Z</para>
        /// </summary>
        [NameInMap("ApplyStartTime")]
        [Validation(Required=false)]
        public string ApplyStartTime { get; set; }

        /// <summary>
        /// <para>The ID of the quota application batch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d314d6ae-867d-484c-9009-3d421a80****</para>
        /// </summary>
        [NameInMap("BatchQuotaApplicationId")]
        [Validation(Required=false)]
        public string BatchQuotaApplicationId { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return for a single request.</para>
        /// <para>Valid values: 1 to 100. Default value: 30.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that marks the position from which you want to start the query.</para>
        /// <remarks>
        /// <para> An empty value indicates that the query starts from the beginning.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The abbreviation of the Alibaba Cloud service name.</para>
        /// <remarks>
        /// <para> To query the abbreviation of an Alibaba Cloud service name, call the <a href="https://help.aliyun.com/document_detail/440555.html">ListProducts</a> operation and check the value of <c>ProductCode</c> in the response.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ecs-spec</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>The quota ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.g5.2xlarge</para>
        /// </summary>
        [NameInMap("QuotaActionCode")]
        [Validation(Required=false)]
        public string QuotaActionCode { get; set; }

        /// <summary>
        /// <para>The type of the quota. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CommonQuota: general quota</description></item>
        /// <item><description>FlowControl: API rate limit</description></item>
        /// <item><description>WhiteListLabel: privilege</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CommonQuota</para>
        /// </summary>
        [NameInMap("QuotaCategory")]
        [Validation(Required=false)]
        public string QuotaCategory { get; set; }

    }

}
