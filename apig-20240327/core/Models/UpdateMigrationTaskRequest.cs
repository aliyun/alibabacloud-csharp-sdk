// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class UpdateMigrationTaskRequest : TeaModel {
        /// <summary>
        /// <para>The namespace of the source cluster for SLB traffic switching.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("clusterNamespace")]
        [Validation(Required=false)]
        public string ClusterNamespace { get; set; }

        /// <summary>
        /// <para>The description of the task. When the target is Engine and the switch type is DNS, only this field can be updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Migration test</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the SLB service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nginx-ingress-lb</para>
        /// </summary>
        [NameInMap("serviceName")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

        /// <summary>
        /// <para>The ID of the SLB instance. This parameter is required when the status is advanced to Initial and the switch type is SLB. The instance type is determined by the prefix lb- or nlb-.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lb-bp1xxxx</para>
        /// </summary>
        [NameInMap("slbId")]
        [Validation(Required=false)]
        public string SlbId { get; set; }

        /// <summary>
        /// <para>The traffic switching method. This parameter is required when the status is advanced to Initial.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SLB</para>
        /// </summary>
        [NameInMap("switchType")]
        [Validation(Required=false)]
        public string SwitchType { get; set; }

        /// <summary>
        /// <para>Required. The update target, which determines whether to advance the status or perform an engine operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Task</para>
        /// </summary>
        [NameInMap("target")]
        [Validation(Required=false)]
        public string Target { get; set; }

        /// <summary>
        /// <para>The list of backend group bindings.</para>
        /// </summary>
        [NameInMap("virtualServices")]
        [Validation(Required=false)]
        public List<UpdateMigrationTaskRequestVirtualServices> VirtualServices { get; set; }
        public class UpdateMigrationTaskRequestVirtualServices : TeaModel {
            /// <summary>
            /// <para>The port number. Valid values: 1 to 65535.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            /// <summary>
            /// <para>The protocol. This parameter is required for CLB.</para>
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
            /// <para>The name of the group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80-tcp</para>
            /// </summary>
            [NameInMap("virtualServiceGroupName")]
            [Validation(Required=false)]
            public string VirtualServiceGroupName { get; set; }

        }

        /// <summary>
        /// <para>The traffic switching weight for the legacy process. Valid values: 0 to 100. This parameter takes effect when the target is Engine.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("weight")]
        [Validation(Required=false)]
        public int? Weight { get; set; }

    }

}
