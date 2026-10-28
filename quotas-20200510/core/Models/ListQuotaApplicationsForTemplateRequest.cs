// This file is auto-generated, don't edit it. Thanks.

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Darabonba;
using Darabonba.Utils;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class ListQuotaApplicationsForTemplateRequest : Darabonba.Model {
        /// <summary>
        /// <para>The end of the time range to query. The value is in UTC.</para>
        /// <remarks>
        /// <para>The interval between <c>ApplyStartTime</c> and <c>ApplyEndTime</c> must be 7 days or less. If you do not set these two parameters, quota applications submitted within the last 7 days are queried.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2023-05-22T16:00:00Z</para>
        /// </summary>
        [NameInMap("ApplyEndTime")]
        [Validation(Required=false)]
        public string ApplyEndTime { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. The value is in UTC.</para>
        /// <remarks>
        /// <para>The interval between <c>ApplyStartTime</c> and <c>ApplyEndTime</c> must be 7 days or less. If you do not set these two parameters, quota applications submitted within the last 7 days are queried.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2023-05-22T16:00:00Z</para>
        /// </summary>
        [NameInMap("ApplyStartTime")]
        [Validation(Required=false)]
        public string ApplyStartTime { get; set; }

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
        /// <para>The maximum number of results to return for a single request.</para>
        /// <para>Valid values: 1 to 100. Default value: 30.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that marks the start of the data to read.</para>
        /// <remarks>
        /// <para>If you do not set this parameter, the query starts from the beginning.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The abbreviation of the Alibaba Cloud service.</para>
        /// <remarks>
        /// <para>For more information about how to obtain the abbreviation of an Alibaba Cloud service, see the <c>ProductCode</c> parameter in <a href="https://help.aliyun.com/document_detail/440555.html">ListProducts</a>.</para>
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
        /// <item><description><para>CommonQuota: general quota.</para>
        /// </description></item>
        /// <item><description><para>FlowControl: API rate limit.</para>
        /// </description></item>
        /// <item><description><para>WhiteListLabel: privilege.</para>
        /// </description></item>
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

