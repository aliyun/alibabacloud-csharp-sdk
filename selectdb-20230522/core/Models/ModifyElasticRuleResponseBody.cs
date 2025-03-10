// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Selectdb20230522.Models
{
    public class ModifyElasticRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ModifyElasticRuleResponseBodyData Data { get; set; }
        public class ModifyElasticRuleResponseBodyData : TeaModel {
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
            /// <para>The cluster ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>selectdb-cn-zpr3if5wq03-be</para>
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
            /// <para>The time when the scheduled scaling rule is executed.</para>
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
            /// <para>29252</para>
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public long? RuleId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5ED62C81-9948-5612-81E1-EA3853752306</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
