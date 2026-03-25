// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DescribeGrantRulesToCenResponseBody : TeaModel {
        [NameInMap("GrantRules")]
        [Validation(Required=false)]
        public DescribeGrantRulesToCenResponseBodyGrantRules GrantRules { get; set; }
        public class DescribeGrantRulesToCenResponseBodyGrantRules : TeaModel {
            [NameInMap("GrantRule")]
            [Validation(Required=false)]
            public List<DescribeGrantRulesToCenResponseBodyGrantRulesGrantRule> GrantRule { get; set; }
            public class DescribeGrantRulesToCenResponseBodyGrantRulesGrantRule : TeaModel {
                [NameInMap("CenId")]
                [Validation(Required=false)]
                public string CenId { get; set; }

                [NameInMap("CenOwnerId")]
                [Validation(Required=false)]
                public long? CenOwnerId { get; set; }

                [NameInMap("ChildInstanceId")]
                [Validation(Required=false)]
                public string ChildInstanceId { get; set; }

                [NameInMap("ChildInstanceOwnerId")]
                [Validation(Required=false)]
                public long? ChildInstanceOwnerId { get; set; }

                [NameInMap("ChildInstanceRegionId")]
                [Validation(Required=false)]
                public string ChildInstanceRegionId { get; set; }

                [NameInMap("ChildInstanceType")]
                [Validation(Required=false)]
                public string ChildInstanceType { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>PayByCenOwner</para>
                /// </summary>
                [NameInMap("EffectiveOrderType")]
                [Validation(Required=false)]
                public string EffectiveOrderType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>PayByCenOwner</para>
                /// </summary>
                [NameInMap("OrderType")]
                [Validation(Required=false)]
                public string OrderType { get; set; }

            }

        }

        /// <summary>
        /// <list type="bullet">
        /// <item><description>If no value is specified for <b>MaxResults</b>, query results are returned in one batch. The value of <b>MaxResults</b> indicates the total number of entries.</description></item>
        /// <item><description>If a value is specified for <b>MaxResults</b>, it indicates that you need to query results in batches. The value of <b>MaxResults</b> in the response indicates the number of entries in the current batch.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <para>The returned value of NextToken is a pagination token, which can be used in the next request to retrieve a new page of results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If <b>NextToken</b> is empty, no next page exists.</description></item>
        /// <item><description>If a value of <b>NextToken</b> was returned in the previous query, specify the value to obtain the next set of results.</description></item>
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
        /// <para>4906B209-8613-5C19-9CC9-B7A3FFDA731C</para>
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
        public long? TotalCount { get; set; }

    }

}
