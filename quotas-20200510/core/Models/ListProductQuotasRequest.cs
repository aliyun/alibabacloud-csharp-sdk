// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class ListProductQuotasRequest : TeaModel {
        /// <summary>
        /// <para>The quota dimensions.</para>
        /// </summary>
        [NameInMap("Dimensions")]
        [Validation(Required=false)]
        public List<ListProductQuotasRequestDimensions> Dimensions { get; set; }
        public class ListProductQuotasRequestDimensions : TeaModel {
            /// <summary>
            /// <para>The key of the quota dimension.</para>
            /// <remarks>
            /// <para>The value range of N depends on the number of dimensions supported by the corresponding cloud service.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>regionId</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the quota dimension.</para>
            /// <remarks>
            /// <para>The value range of N depends on the number of dimensions supported by the corresponding cloud service.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The dimension group code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>entconsole_w1j3ms****</para>
        /// </summary>
        [NameInMap("GroupCode")]
        [Validation(Required=false)]
        public string GroupCode { get; set; }

        /// <summary>
        /// <para>The search keyword for the quota.</para>
        /// <remarks>
        /// <para>This parameter applies only to Elastic Computing Service server instance type quotas (ecs-spec). The search scope includes <c>QuotaName</c> and <c>QuotaActionCode</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>security</para>
        /// </summary>
        [NameInMap("KeyWord")]
        [Validation(Required=false)]
        public string KeyWord { get; set; }

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
        /// <para>The token for the next query.</para>
        /// <list type="bullet">
        /// <item><description>For the first query or when no subsequent query is required, you do not need to specify this parameter.</description></item>
        /// <item><description>If a subsequent query is required, set the value to the NextToken value returned by the previous API call.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The abbreviated name of the cloud service.</para>
        /// <remarks>
        /// <para>For more information about how to obtain the abbreviated name of a cloud service, see <c>ProductCode</c> in <a href="https://help.aliyun.com/document_detail/440555.html">ListProducts</a>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
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
        /// <para>q_security-groups</para>
        /// </summary>
        [NameInMap("QuotaActionCode")]
        [Validation(Required=false)]
        public string QuotaActionCode { get; set; }

        /// <summary>
        /// <para>The quota category.</para>
        /// <para>Default value: CommonQuota.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FlowControl</para>
        /// </summary>
        [NameInMap("QuotaCategory")]
        [Validation(Required=false)]
        public string QuotaCategory { get; set; }

        /// <summary>
        /// <para>The sorting method supported by the quota.</para>
        /// <remarks>
        /// <para>This parameter applies only to Elastic Computing Service server instance type quotas (ecs-spec). If the Settings are not specified, it is left empty.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>TIME</para>
        /// </summary>
        [NameInMap("SortField")]
        [Validation(Required=false)]
        public string SortField { get; set; }

        /// <summary>
        /// <para>The sorting method supported by the quota.</para>
        /// <remarks>
        /// <para>This parameter applies only to Elastic Computing Service server instance type quotas (ecs-spec). If the Settings are not specified, it is left empty.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Ascending</para>
        /// </summary>
        [NameInMap("SortOrder")]
        [Validation(Required=false)]
        public string SortOrder { get; set; }

    }

}
