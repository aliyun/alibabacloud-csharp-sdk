// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class ListQuotaApplicationsDetailForTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The Alibaba Cloud account that submitted the quota increase application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>135048337611****</para>
        /// </summary>
        [NameInMap("AliyunUid")]
        [Validation(Required=false)]
        public string AliyunUid { get; set; }

        /// <summary>
        /// <para>The ID of the batch quota application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d314d6ae-867d-484c-9009-3d421a80****</para>
        /// </summary>
        [NameInMap("BatchQuotaApplicationId")]
        [Validation(Required=false)]
        public string BatchQuotaApplicationId { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return for the current query.</para>
        /// <para>Valid values: 1 to 100. Default value: 30.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that specifies the starting position of the query.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the query starts from the beginning.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The abbreviation of the cloud service name.</para>
        /// <remarks>
        /// <para>For more information about how to obtain the abbreviation of a cloud service name, see <c>ProductCode</c> in <a href="https://help.aliyun.com/document_detail/440555.html">ListProducts</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ecs</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>The quota ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.c5.large</para>
        /// </summary>
        [NameInMap("QuotaActionCode")]
        [Validation(Required=false)]
        public string QuotaActionCode { get; set; }

        /// <summary>
        /// <para>The quota type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CommonQuota: General quota.</description></item>
        /// <item><description>FlowControl: API rate limit.</description></item>
        /// <item><description>WhiteListLabel: Privilege.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CommonQuota</para>
        /// </summary>
        [NameInMap("QuotaCategory")]
        [Validation(Required=false)]
        public string QuotaCategory { get; set; }

        /// <summary>
        /// <para>The approval status of the quota increase application. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Disagree: Rejected.</para>
        /// </description></item>
        /// <item><description><para>Agree: Approved.</para>
        /// </description></item>
        /// <item><description><para>Process: Under review.</para>
        /// </description></item>
        /// <item><description><para>Cancel: Closed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Agree</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
