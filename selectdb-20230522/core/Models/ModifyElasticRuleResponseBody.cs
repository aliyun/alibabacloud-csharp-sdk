// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Selectdb20230522.Models
{
    public class ModifyElasticRuleResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ModifyElasticRuleResponseBodyData Data { get; set; }
        public class ModifyElasticRuleResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>selectdb.2xlarge</para>
            /// </summary>
            [NameInMap("ClusterClass")]
            [Validation(Required=false)]
            public string ClusterClass { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>selectdb-cn-zpr3if5wq03-be</para>
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
            /// <para>29252</para>
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public long? RuleId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5ED62C81-9948-5612-81E1-EA3853752306</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
