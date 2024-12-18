// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Selectdb20230522.Models
{
    public class DescribeElasticRulesResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeElasticRulesResponseBodyData Data { get; set; }
        public class DescribeElasticRulesResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>selectdb-cn-nwy3jv1oa02-be</para>
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>selectdb-cn-7213cjv****</para>
            /// </summary>
            [NameInMap("DbInstanceId")]
            [Validation(Required=false)]
            public string DbInstanceId { get; set; }

            [NameInMap("Rules")]
            [Validation(Required=false)]
            public List<DescribeElasticRulesResponseBodyDataRules> Rules { get; set; }
            public class DescribeElasticRulesResponseBodyDataRules : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>selectdb.2xlarge</para>
                /// </summary>
                [NameInMap("ClusterClass")]
                [Validation(Required=false)]
                public string ClusterClass { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>00:00</para>
                /// </summary>
                [NameInMap("ElasticRuleStartTime")]
                [Validation(Required=false)]
                public string ElasticRuleStartTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Day</para>
                /// </summary>
                [NameInMap("ExecutionPeriod")]
                [Validation(Required=false)]
                public string ExecutionPeriod { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>5467</para>
                /// </summary>
                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public long? RuleId { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>F8900A96-67F7-5274-A41B-7722E1ECF8C9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
