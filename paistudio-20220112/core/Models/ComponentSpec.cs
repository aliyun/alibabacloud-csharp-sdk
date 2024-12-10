// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class ComponentSpec : TeaModel {
        [NameInMap("CodeDir")]
        [Validation(Required=false)]
        public Location CodeDir { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Command")]
        [Validation(Required=false)]
        public string Command { get; set; }

        [NameInMap("HyperParameters")]
        [Validation(Required=false)]
        public List<HyperParameterDefinition> HyperParameters { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Image")]
        [Validation(Required=false)]
        public string Image { get; set; }

        [NameInMap("InputChannels")]
        [Validation(Required=false)]
        public List<Channel> InputChannels { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("JobType")]
        [Validation(Required=false)]
        public string JobType { get; set; }

        [NameInMap("MetricDefinitions")]
        [Validation(Required=false)]
        public List<MetricDefinition> MetricDefinitions { get; set; }

        [NameInMap("OutputChannels")]
        [Validation(Required=false)]
        public List<Channel> OutputChannels { get; set; }

        [NameInMap("ResourceRequirements")]
        [Validation(Required=false)]
        public List<ConditionExpression> ResourceRequirements { get; set; }

    }

}
