// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class UpdateMigrationTaskRequest : TeaModel {
        /// <summary>
        /// <para>The namespace of the source cluster (for SLB traffic switching).</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("clusterNamespace")]
        [Validation(Required=false)]
        public string ClusterNamespace { get; set; }

        /// <summary>
        /// <para>The task description. For DNS-based Engine updates, only this field is modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Migration test</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The SLB service name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nginx-ingress-lb</para>
        /// </summary>
        [NameInMap("serviceName")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

        /// <summary>
        /// <para>The SLB instance ID. Required when the task is in the Initial state with SLB traffic switching. The type is determined by the prefix (lb- or nlb-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>lb-bp1xxxx</para>
        /// </summary>
        [NameInMap("slbId")]
        [Validation(Required=false)]
        public string SlbId { get; set; }

        /// <summary>
        /// <para>The traffic switching method. Required when advancing from the Initial state.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SLB</para>
        /// </summary>
        [NameInMap("switchType")]
        [Validation(Required=false)]
        public string SwitchType { get; set; }

        /// <summary>
        /// <para>Required. The update target. Determines whether to advance the task status or perform an engine operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Task</para>
        /// </summary>
        [NameInMap("target")]
        [Validation(Required=false)]
        public string Target { get; set; }

        /// <summary>
        /// <para>The list of backend server group bindings.</para>
        /// </summary>
        [NameInMap("virtualServices")]
        [Validation(Required=false)]
        public List<UpdateMigrationTaskRequestVirtualServices> VirtualServices { get; set; }
        public class UpdateMigrationTaskRequestVirtualServices : TeaModel {
            /// <summary>
            /// <para>The port. Valid values: 1 to 65535.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            /// <summary>
            /// <para>The protocol. Required for CLB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tcp</para>
            /// </summary>
            [NameInMap("protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <summary>
            /// <para>CLB VServerGroupId / NLB ServerGroupId</para>
            /// 
            /// <b>Example:</b>
            /// <para>rsp-xxxx</para>
            /// </summary>
            [NameInMap("virtualServiceGroupId")]
            [Validation(Required=false)]
            public string VirtualServiceGroupId { get; set; }

            /// <summary>
            /// <para>The group name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80-tcp</para>
            /// </summary>
            [NameInMap("virtualServiceGroupName")]
            [Validation(Required=false)]
            public string VirtualServiceGroupName { get; set; }

        }

        /// <summary>
        /// <para>The traffic switching weight for the legacy flow. Valid values: 0 to 100. Takes effect when the target is set to Engine.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("weight")]
        [Validation(Required=false)]
        public int? Weight { get; set; }

    }

}
