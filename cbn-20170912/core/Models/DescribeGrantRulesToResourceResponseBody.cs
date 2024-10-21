// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DescribeGrantRulesToResourceResponseBody : TeaModel {
        /// <summary>
        /// <para>The permissions that are granted to the CEN instance.</para>
        /// </summary>
        [NameInMap("GrantRules")]
        [Validation(Required=false)]
        public List<DescribeGrantRulesToResourceResponseBodyGrantRules> GrantRules { get; set; }
        public class DescribeGrantRulesToResourceResponseBodyGrantRules : TeaModel {
            /// <summary>
            /// <para>The ID of the CEN instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cen-44m0p68spvlrqq****</para>
            /// </summary>
            [NameInMap("CenId")]
            [Validation(Required=false)]
            public string CenId { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account to which the CEN instance belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1250123456123456</para>
            /// </summary>
            [NameInMap("CenOwnerId")]
            [Validation(Required=false)]
            public long? CenOwnerId { get; set; }

            /// <summary>
            /// <para>The timestamp when the permissions were granted. The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-01-24T16:46Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The entity that pays the fees of the network instance. Valid values: Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>PayByCenOwner</b>: The fees of the connections and data forwarding on the transit router are paid by the Alibaba Cloud account to which the CEN instance belongs.</description></item>
            /// <item><description><b>PayByResourceOwner</b>: The fees of the connections and data forwarding on the transit router are paid by the Alibaba Cloud account to which the network instance belongs.</description></item>
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
        /// <item><description>If no value is specified for <b>MaxResults</b>, query results are returned in one batch. The value of <b>MaxResults</b> indicates the total number of entries.</description></item>
        /// <item><description>If a value is specified for <b>MaxResults</b>, query results are returned in batches. The value of <b>MaxResults</b> in the response indicates the number of entries in the current batch.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The returned value of NextToken is a pagination token, which can be used in the next request to retrieve a new page of results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If the <b>NextToken</b> parameter is empty, no next page exists.</description></item>
        /// <item><description>If a value is returned for <b>NextToken</b>, the value is the token that determines the start point of the next query.</description></item>
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
