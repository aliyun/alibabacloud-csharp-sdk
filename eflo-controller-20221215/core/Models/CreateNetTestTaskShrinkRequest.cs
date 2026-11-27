// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class CreateNetTestTaskShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i119982311660892626523</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The cluster name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Eflo-YJ-Test-Cluster</para>
        /// </summary>
        [NameInMap("ClusterName")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        /// <summary>
        /// <para>The communication test configurations. This field is required when the network test type is communication library testing.</para>
        /// </summary>
        [NameInMap("CommTest")]
        [Validation(Required=false)]
        public string CommTestShrink { get; set; }

        /// <summary>
        /// <para>The delay test configurations. This field is required when the network test type is latency testing.</para>
        /// </summary>
        [NameInMap("DelayTest")]
        [Validation(Required=false)]
        public string DelayTestShrink { get; set; }

        /// <summary>
        /// <para>The network test type. Examples: DelayTest for latency testing, TrafficTest for traffic testing, and CommTest for communication library testing.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DelayTest</para>
        /// </summary>
        [NameInMap("NetTestType")]
        [Validation(Required=false)]
        public string NetTestType { get; set; }

        /// <summary>
        /// <para>The network mode. This parameter is required. If you do not specify this parameter, the API returns a 400 error and prompts that the field is missing (NetworkMode field required).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("NetworkMode")]
        [Validation(Required=false)]
        public string NetworkMode { get; set; }

        /// <summary>
        /// <para>The test port number. This parameter is required. If you do not specify this parameter, the API returns a 400 error and prompts that the field is missing (Port field required).</para>
        /// 
        /// <b>Example:</b>
        /// <para>23604</para>
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public string Port { get; set; }

        /// <summary>
        /// <para>The traffic test configurations. If the traffic model TrafficModel is Fullmesh, leave this field empty.</para>
        /// </summary>
        [NameInMap("TrafficTest")]
        [Validation(Required=false)]
        public string TrafficTestShrink { get; set; }

    }

}
