// This file is auto-generated, don't edit it. Thanks.

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Darabonba;
using Darabonba.Utils;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class ListQuotaApplicationsRequest : Darabonba.Model {
        /// <summary>
        /// <para>The quota dimensions.
        /// The dimensions are properties of a quota item. A combination of dimensions (Dimensions) and a quota ID (QuotaActionCode) uniquely identifies a quota item.</para>
        /// <remarks>
        /// <para>Some cloud services require dimensions. You can call <a href="~~ListProductQuotaDimensions~~">ListProductQuotaDimensions</a> to query the quota dimensions supported by a cloud service. The <c>Requisite</c> response parameter indicates whether a dimension is required.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Dimensions")]
        [Validation(Required=false)]
        public List<ListQuotaApplicationsRequestDimensions> Dimensions { get; set; }
        public class ListQuotaApplicationsRequestDimensions : Darabonba.Model {
            /// <summary>
            /// <para>The key of the quota dimension.</para>
            /// <remarks>
            /// <para><c>Dimensions.N.Key</c> and <c>Dimensions.N.Value</c> must be specified together. The valid values of N depend on the number of dimensions supported by the cloud service. You can call <a href="~~ListProductQuotaDimensions~~">ListProductQuotaDimensions</a> to query the quota dimensions supported by a cloud service. The length of the returned array is the value of N.</para>
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
            /// <para><c>Dimensions.N.Key</c> and <c>Dimensions.N.Value</c> must be specified together. The valid values of N depend on the number of dimensions supported by the cloud service. You can call <a href="~~ListProductQuotaDimensions~~">ListProductQuotaDimensions</a> to query the quota dimensions supported by a cloud service. The length of the returned array is the value of N.</para>
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
        /// <para>The keyword for searching quota increase applications.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Cluster</para>
        /// </summary>
        [NameInMap("KeyWord")]
        [Validation(Required=false)]
        public string KeyWord { get; set; }

        /// <summary>
        /// <para>The maximum number of records to return in this query.</para>
        /// <para>Valid values: 1 to 200. Default value: 30.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that marks the position from which you want to start the query. Leave this parameter empty to query from the beginning.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The abbreviation of the cloud service name.</para>
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
        /// <para>The quota category. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CommonQuota: general quota.</description></item>
        /// <item><description>FlowControl: API rate limit.</description></item>
        /// <item><description>WhiteListLabel: privilege.</description></item>
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

