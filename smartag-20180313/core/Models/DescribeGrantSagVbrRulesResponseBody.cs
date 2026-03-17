// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class DescribeGrantSagVbrRulesResponseBody : TeaModel {
        [NameInMap("GrantRules")]
        [Validation(Required=false)]
        public DescribeGrantSagVbrRulesResponseBodyGrantRules GrantRules { get; set; }
        public class DescribeGrantSagVbrRulesResponseBodyGrantRules : TeaModel {
            [NameInMap("GrantRule")]
            [Validation(Required=false)]
            public List<DescribeGrantSagVbrRulesResponseBodyGrantRulesGrantRule> GrantRule { get; set; }
            public class DescribeGrantSagVbrRulesResponseBodyGrantRulesGrantRule : TeaModel {
                [NameInMap("Bound")]
                [Validation(Required=false)]
                public bool? Bound { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("SmartAGId")]
                [Validation(Required=false)]
                public string SmartAGId { get; set; }

                [NameInMap("SmartAGUid")]
                [Validation(Required=false)]
                public long? SmartAGUid { get; set; }

                [NameInMap("VbrInstanceId")]
                [Validation(Required=false)]
                public string VbrInstanceId { get; set; }

                [NameInMap("VbrRegionId")]
                [Validation(Required=false)]
                public string VbrRegionId { get; set; }

                [NameInMap("VbrUid")]
                [Validation(Required=false)]
                public long? VbrUid { get; set; }

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
        /// <para>The number of entries returned per page.</para>
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
        /// <para>46E98E69-FBA2-423E-9E5A-A3C6D843FED1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of authorization rules.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
