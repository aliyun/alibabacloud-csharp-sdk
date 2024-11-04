// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class CreateVirtualResourceRequest : TeaModel {
        /// <summary>
        /// <para>The list of resources in the virtual resource group.</para>
        /// </summary>
        [NameInMap("Resources")]
        [Validation(Required=false)]
        public List<CreateVirtualResourceRequestResources> Resources { get; set; }
        public class CreateVirtualResourceRequestResources : TeaModel {
            /// <summary>
            /// <para>The instance type of the public resource group.</para>
            /// <remarks>
            /// <para> You must specify one and only one of the InstanceType, ResourceId, and QuotaId parameters.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>ecs.s6-c1m2.xlarge</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>The priority of resource scheduling. A greater number specifies a higher priority.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// <para>Lingjun Resource Quota ID.</para>
            /// <remarks>
            /// <para> You must specify one and only one of the InstanceType, ResourceId, and QuotaId parameters.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>quota185lqxxxxxx</para>
            /// </summary>
            [NameInMap("QuotaId")]
            [Validation(Required=false)]
            public string QuotaId { get; set; }

            /// <summary>
            /// <para>The region where the resource resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <para>The ID of the dedicated resource group. For information about how to query the ID of a dedicated resource group, see <a href="https://help.aliyun.com/document_detail/412133.html">ListResources</a>.</para>
            /// <remarks>
            /// <para> You must specify one and only one of the InstanceType, ResourceId, and QuotaId parameters.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>eas-r-g55ieatgg3buxxxxxx</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <para>The maximum price of preemptible instances in a public resource group.</para>
            /// <remarks>
            /// <para> If you do not set this value, preemptible instances are not used.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>10.05</para>
            /// </summary>
            [NameInMap("SpotPriceLimit")]
            [Validation(Required=false)]
            public float? SpotPriceLimit { get; set; }

        }

        /// <summary>
        /// <para>The name of the virtual resource group. Default value: the ID of the virtual resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MyVirtualResource</para>
        /// </summary>
        [NameInMap("VirtualResourceName")]
        [Validation(Required=false)]
        public string VirtualResourceName { get; set; }

    }

}
