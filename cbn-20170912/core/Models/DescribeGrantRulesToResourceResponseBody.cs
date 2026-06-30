// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DescribeGrantRulesToResourceResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of permission records.</para>
        /// </summary>
        [NameInMap("GrantRules")]
        [Validation(Required=false)]
        public List<DescribeGrantRulesToResourceResponseBodyGrantRules> GrantRules { get; set; }
        public class DescribeGrantRulesToResourceResponseBodyGrantRules : TeaModel {
            /// <summary>
            /// <para>The ID of the Cloud Enterprise Network (CEN) instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cen-44m0p68spvlrqq****</para>
            /// </summary>
            [NameInMap("CenId")]
            [Validation(Required=false)]
            public string CenId { get; set; }

            /// <summary>
            /// <para>The ID of the main account that owns the Cloud Enterprise Network (CEN) instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1250123456123456</para>
            /// </summary>
            [NameInMap("CenOwnerId")]
            [Validation(Required=false)]
            public long? CenOwnerId { get; set; }

            /// <summary>
            /// <para>The timestamp when the permission was granted. The value is in UTC and follows the ISO 8601 standard: <c>YYYY-MM-DDThh:mmZ</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-01-24T16:46Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>PayByCenOwner</para>
            /// </summary>
            [NameInMap("EffectiveOrderType")]
            [Validation(Required=false)]
            public string EffectiveOrderType { get; set; }

            /// <summary>
            /// <para>The payer for the network instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>PayByCenOwner</b>: The CEN instance owner pays the Transit Router connection and data processing fees for the network instance.</para>
            /// </description></item>
            /// <item><description><para><b>PayByResourceOwner</b>: The network instance owner pays the Transit Router connection and data processing fees for the network instance.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PayByCenOwner</para>
            /// </summary>
            [NameInMap("OrderType")]
            [Validation(Required=false)]
            public string OrderType { get; set; }

        }

        /// <summary>
        /// <list type="bullet">
        /// <item><description><para>If the <b>MaxResults</b> parameter was not included in the request, this field indicates the total number of entries.</para>
        /// </description></item>
        /// <item><description><para>If the <b>MaxResults</b> parameter was included in the request, this field indicates the number of entries on the current page.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token to use in your next request to retrieve a new page of results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>If the <b>NextToken</b> parameter is empty, no more results are available.</para>
        /// </description></item>
        /// <item><description><para>If a value is returned for <b>NextToken</b>, use it for the next request to get the next page of results.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FFmyTO70tTpLG6I3FmYAXGKPd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C6E5992C-A57B-5A6C-9B26-568074DC68BA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
