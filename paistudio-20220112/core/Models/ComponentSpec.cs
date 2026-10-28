// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class ComponentSpec : TeaModel {
        /// <summary>
        /// <para>The code directory configuration.</para>
        /// </summary>
        [NameInMap("CodeDir")]
        [Validation(Required=false)]
        public Location CodeDir { get; set; }

        /// <summary>
        /// <para>The command used for submit the job.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Command")]
        [Validation(Required=false)]
        public string Command { get; set; }

        /// <summary>
        /// <para>The hype parameter used by the algorithm.</para>
        /// </summary>
        [NameInMap("HyperParameters")]
        [Validation(Required=false)]
        public List<HyperParameterDefinition> HyperParameters { get; set; }

        /// <summary>
        /// <para>The docker image used by the job of this algorithm.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>registry.cn-shanghai.aliyuncs.com/pai-training/kmeans:v1.0.0</para>
        /// </summary>
        [NameInMap("Image")]
        [Validation(Required=false)]
        public string Image { get; set; }

        /// <summary>
        /// <para>The input for the algorithm.</para>
        /// </summary>
        [NameInMap("InputChannels")]
        [Validation(Required=false)]
        public List<Channel> InputChannels { get; set; }

        /// <summary>
        /// <para>Job type of the training job while running the algorithm.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TFJob</para>
        /// </summary>
        [NameInMap("JobType")]
        [Validation(Required=false)]
        public string JobType { get; set; }

        /// <summary>
        /// <para>The output metrics of the algorithm.</para>
        /// </summary>
        [NameInMap("MetricDefinitions")]
        [Validation(Required=false)]
        public List<MetricDefinition> MetricDefinitions { get; set; }

        /// <summary>
        /// <para>The outputs of the algorithm.</para>
        /// </summary>
        [NameInMap("OutputChannels")]
        [Validation(Required=false)]
        public List<Channel> OutputChannels { get; set; }

        /// <summary>
        /// <para>Resource requirements.</para>
        /// </summary>
        [NameInMap("ResourceRequirements")]
        [Validation(Required=false)]
        public List<ConditionExpression> ResourceRequirements { get; set; }

    }

}
