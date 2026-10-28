// This file is auto-generated, don't edit it. Thanks.

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Darabonba;
using Darabonba.Utils;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class ListQuotaApplicationsDetailForTemplateRequest : Darabonba.Model {
        /// <summary>
        /// <para>The Alibaba Cloud account for which the quota increase is requested.</para>
        /// 
        /// <b>Example:</b>
        /// <para>135048337611****</para>
        /// </summary>
        [NameInMap("AliyunUid")]
        [Validation(Required=false)]
        public string AliyunUid { get; set; }

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
        /// <para>The maximum number of records to return for the current query.</para>
        /// <para>Valid values: 1 to 100. Default value: 30.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that marks the position from which the query starts.</para>
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
        /// <para>The abbreviation of the Alibaba Cloud service name.</para>
        /// <remarks>
        /// <para>For more information about how to obtain the abbreviation of an Alibaba Cloud service name, see the <c>ProductCode</c> parameter in <a href="https://help.aliyun.com/document_detail/440555.html">ListProducts</a>.</para>
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
        /// <item><description><para>CommonQuota: General quota.</para>
        /// </description></item>
        /// <item><description><para>FlowControl: API rate limit quota.</para>
        /// </description></item>
        /// <item><description><para>WhiteListLabel: Privilege quota.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CommonQuota</para>
        /// </summary>
        [NameInMap("QuotaCategory")]
        [Validation(Required=false)]
        public string QuotaCategory { get; set; }

        /// <summary>
        /// <para>The approval status of the quota increase request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Disagree: The request is rejected.</para>
        /// </description></item>
        /// <item><description><para>Agree: The request is approved.</para>
        /// </description></item>
        /// <item><description><para>Process: The request is in review.</para>
        /// </description></item>
        /// <item><description><para>Cancel: The request is closed.</para>
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

