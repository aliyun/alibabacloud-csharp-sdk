// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class UpdateMigrationTaskRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("clusterNamespace")]
        [Validation(Required=false)]
        public string ClusterNamespace { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>迁移测试</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>nginx-ingress-lb</para>
        /// </summary>
        [NameInMap("serviceName")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>lb-bp1xxxx</para>
        /// </summary>
        [NameInMap("slbId")]
        [Validation(Required=false)]
        public string SlbId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>SLB</para>
        /// </summary>
        [NameInMap("switchType")]
        [Validation(Required=false)]
        public string SwitchType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Task</para>
        /// </summary>
        [NameInMap("target")]
        [Validation(Required=false)]
        public string Target { get; set; }

        [NameInMap("virtualServices")]
        [Validation(Required=false)]
        public List<UpdateMigrationTaskRequestVirtualServices> VirtualServices { get; set; }
        public class UpdateMigrationTaskRequestVirtualServices : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>tcp</para>
            /// </summary>
            [NameInMap("protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>rsp-xxxx</para>
            /// </summary>
            [NameInMap("virtualServiceGroupId")]
            [Validation(Required=false)]
            public string VirtualServiceGroupId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>80-tcp</para>
            /// </summary>
            [NameInMap("virtualServiceGroupName")]
            [Validation(Required=false)]
            public string VirtualServiceGroupName { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("weight")]
        [Validation(Required=false)]
        public int? Weight { get; set; }

    }

}
