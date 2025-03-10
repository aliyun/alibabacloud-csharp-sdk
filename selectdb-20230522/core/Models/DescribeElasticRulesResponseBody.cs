// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Selectdb20230522.Models
{
    public class DescribeElasticRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeElasticRulesResponseBodyData Data { get; set; }
        public class DescribeElasticRulesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The cluster ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>selectdb-cn-nwy3jv1oa02-be</para>
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>selectdb-cn-7213cjv****</para>
            /// </summary>
            [NameInMap("DbInstanceId")]
            [Validation(Required=false)]
            public string DbInstanceId { get; set; }

            /// <summary>
            /// <para>The details of the rules.</para>
            /// </summary>
            [NameInMap("Rules")]
            [Validation(Required=false)]
            public List<DescribeElasticRulesResponseBodyDataRules> Rules { get; set; }
            public class DescribeElasticRulesResponseBodyDataRules : TeaModel {
                /// <summary>
                /// <para>The rule for computing resources of the required cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>selectdb.2xlarge</para>
                /// </summary>
                [NameInMap("ClusterClass")]
                [Validation(Required=false)]
                public string ClusterClass { get; set; }

                /// <summary>
                /// <para>The time when you want to execute the scheduled scaling rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:00</para>
                /// </summary>
                [NameInMap("ElasticRuleStartTime")]
                [Validation(Required=false)]
                public string ElasticRuleStartTime { get; set; }

                /// <summary>
                /// <para>The execution cycle.</para>
                /// <para>Valid value:</para>
                /// <list type="bullet">
                /// <item><description>Day</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Day</para>
                /// </summary>
                [NameInMap("ExecutionPeriod")]
                [Validation(Required=false)]
                public string ExecutionPeriod { get; set; }

                /// <summary>
                /// <para>The rule ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5467</para>
                /// </summary>
                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public long? RuleId { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F8900A96-67F7-5274-A41B-7722E1ECF8C9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
