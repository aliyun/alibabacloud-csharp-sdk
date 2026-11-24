// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class ListQuotaApplicationsRequest : TeaModel {
        /// <summary>
        /// <para>The quota dimensions.
        /// The properties of the quota item. The combination of dimensions and the quota ID (QuotaActionCode) uniquely identifies a quota item.</para>
        /// <remarks>
        /// <para>The dimensions are required for some cloud services. You can call the <a href="~~ListProductQuotaDimensions~~">ListProductQuotaDimensions</a> operation to query the quota dimensions supported by a cloud service. The Requisite response parameter indicates whether a dimension is required.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Dimensions")]
        [Validation(Required=false)]
        public List<ListQuotaApplicationsRequestDimensions> Dimensions { get; set; }
        public class ListQuotaApplicationsRequestDimensions : TeaModel {
            /// <summary>
            /// <para>The key of the quota dimension.</para>
            /// <remarks>
            /// <para>Dimensions.N.Key and Dimensions.N.Value must be specified at the same time. The value range of N depends on the number of dimensions supported by the corresponding cloud service. You can call the <a href="~~ListProductQuotaDimensions~~">ListProductQuotaDimensions</a> operation to query the quota dimensions supported by the cloud service. The length of the returned array is the value of N.</para>
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
            /// <para>Dimensions.N.Key and Dimensions.N.Value must be specified at the same time. The value range of N depends on the number of dimensions supported by the corresponding cloud service. You can call the <a href="~~ListProductQuotaDimensions~~">ListProductQuotaDimensions</a> operation to query the quota dimensions supported by the cloud service. The length of the returned array is the value of N.</para>
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
        /// <para>The search keyword for quota increase applications.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Cluster</para>
        /// </summary>
        [NameInMap("KeyWord")]
        [Validation(Required=false)]
        public string KeyWord { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return for the current query.</para>
        /// <para>Valid values: 1 to 200. Default value: 30.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token that specifies the start position of the query. An empty value indicates that the query starts from the beginning.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The abbreviation of the cloud service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>csk</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>The quota ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>q_i5uzm3</para>
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
        /// <item><description><para>Withdrawn: Withdrawn.</para>
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
