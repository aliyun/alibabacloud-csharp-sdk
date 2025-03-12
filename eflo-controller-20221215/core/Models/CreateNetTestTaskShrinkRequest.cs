// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class CreateNetTestTaskShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Cluster ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>i119982311660892626523</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>Cluster name</para>
        /// 
        /// <b>Example:</b>
        /// <para>Eflo-YJ-Test-Cluster</para>
        /// </summary>
        [NameInMap("ClusterName")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        /// <summary>
        /// <para>Required when the test type is communication library testing</para>
        /// </summary>
        [NameInMap("CommTest")]
        [Validation(Required=false)]
        public string CommTestShrink { get; set; }

        /// <summary>
        /// <para>Fill in this field when the network test type is delay testing.</para>
        /// </summary>
        [NameInMap("DelayTest")]
        [Validation(Required=false)]
        public string DelayTestShrink { get; set; }

        /// <summary>
        /// <para>Network test type.
        /// For example: DelayTest for latency testing, TrafficTest for traffic testing, CommTest for communication library testing.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DelayTest</para>
        /// </summary>
        [NameInMap("NetTestType")]
        [Validation(Required=false)]
        public string NetTestType { get; set; }

        /// <summary>
        /// <para>Network mode</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("NetworkMode")]
        [Validation(Required=false)]
        public string NetworkMode { get; set; }

        /// <summary>
        /// <para>Test port number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>23604</para>
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public string Port { get; set; }

        /// <summary>
        /// <para>This field is empty if the TrafficModel is Fullmesh.</para>
        /// </summary>
        [NameInMap("TrafficTest")]
        [Validation(Required=false)]
        public string TrafficTestShrink { get; set; }

    }

}
