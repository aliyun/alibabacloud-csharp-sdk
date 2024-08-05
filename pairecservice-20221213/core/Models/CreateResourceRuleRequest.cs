// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class CreateResourceRuleRequest : TeaModel {
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("MetricOperationType")]
        [Validation(Required=false)]
        public string MetricOperationType { get; set; }

        [NameInMap("MetricPullInfo")]
        [Validation(Required=false)]
        public string MetricPullInfo { get; set; }

        [NameInMap("MetricPullPeriod")]
        [Validation(Required=false)]
        public string MetricPullPeriod { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("RuleComputingDefinition")]
        [Validation(Required=false)]
        public string RuleComputingDefinition { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("RuleItems")]
        [Validation(Required=false)]
        public List<CreateResourceRuleRequestRuleItems> RuleItems { get; set; }
        public class CreateResourceRuleRequestRuleItems : TeaModel {
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("MaxValue")]
            [Validation(Required=false)]
            public double? MaxValue { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("MinValue")]
            [Validation(Required=false)]
            public double? MinValue { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public double? Value { get; set; }

        }

    }

}
