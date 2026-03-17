// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class DescribeGrantSagRulesResponseBody : TeaModel {
        [NameInMap("GrantRules")]
        [Validation(Required=false)]
        public DescribeGrantSagRulesResponseBodyGrantRules GrantRules { get; set; }
        public class DescribeGrantSagRulesResponseBodyGrantRules : TeaModel {
            [NameInMap("GrantRule")]
            [Validation(Required=false)]
            public List<DescribeGrantSagRulesResponseBodyGrantRulesGrantRule> GrantRule { get; set; }
            public class DescribeGrantSagRulesResponseBodyGrantRulesGrantRule : TeaModel {
                [NameInMap("CcnInstanceId")]
                [Validation(Required=false)]
                public string CcnInstanceId { get; set; }

                [NameInMap("CcnUid")]
                [Validation(Required=false)]
                public long? CcnUid { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                [NameInMap("GrantTrafficService")]
                [Validation(Required=false)]
                public bool? GrantTrafficService { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("SmartAGId")]
                [Validation(Required=false)]
                public string SmartAGId { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page.</para>
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
        /// <para>6E1674AC-083C-4031-B047-7A66E418E0C6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
