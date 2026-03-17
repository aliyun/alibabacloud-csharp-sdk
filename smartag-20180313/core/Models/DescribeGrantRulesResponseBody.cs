// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class DescribeGrantRulesResponseBody : TeaModel {
        [NameInMap("GrantRules")]
        [Validation(Required=false)]
        public DescribeGrantRulesResponseBodyGrantRules GrantRules { get; set; }
        public class DescribeGrantRulesResponseBodyGrantRules : TeaModel {
            [NameInMap("GrantRule")]
            [Validation(Required=false)]
            public List<DescribeGrantRulesResponseBodyGrantRulesGrantRule> GrantRule { get; set; }
            public class DescribeGrantRulesResponseBodyGrantRulesGrantRule : TeaModel {
                [NameInMap("CcnInstanceId")]
                [Validation(Required=false)]
                public string CcnInstanceId { get; set; }

                [NameInMap("CcnUid")]
                [Validation(Required=false)]
                public long? CcnUid { get; set; }

                [NameInMap("CenInstanceId")]
                [Validation(Required=false)]
                public string CenInstanceId { get; set; }

                [NameInMap("CenUid")]
                [Validation(Required=false)]
                public long? CenUid { get; set; }

                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public long? GmtCreate { get; set; }

                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public long? GmtModified { get; set; }

                [NameInMap("GrantRuleId")]
                [Validation(Required=false)]
                public string GrantRuleId { get; set; }

                [NameInMap("GrantTrafficService")]
                [Validation(Required=false)]
                public bool? GrantTrafficService { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FA579C2D-84A0-4BA1-B9C3-1E5A3B15F1B6</para>
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
