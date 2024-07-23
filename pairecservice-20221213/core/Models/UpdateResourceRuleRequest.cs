// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class UpdateResourceRuleRequest : TeaModel {
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
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
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("RuleComputingDefinition")]
        [Validation(Required=false)]
        public string RuleComputingDefinition { get; set; }

    }

}
