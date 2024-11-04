// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class UpdateVirtualResourceRequest : TeaModel {
        /// <summary>
        /// <para>The list of resources in the virtual resource group.</para>
        /// <remarks>
        /// <para> If you specify this parameter, previous data are overwritten.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Resources")]
        [Validation(Required=false)]
        public List<UpdateVirtualResourceRequestResources> Resources { get; set; }
        public class UpdateVirtualResourceRequestResources : TeaModel {
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
            /// <para>The Lingjun resource quota ID.</para>
            /// <remarks>
            /// <para> You must specify one and only one of the InstanceType, ResourceId, and QuotaId parameters.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>quota185lqf994k6</para>
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
            /// <para>eas-r-g55ieatgg3butwrn7a</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <para>The maximum price of preemptible instances in a public resource group.</para>
            /// <remarks>
            /// <para> If you do not specify this parameter, preemptible instances are not used.</para>
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
        /// <para>The new name for the virtual resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NewMyVirtualResource</para>
        /// </summary>
        [NameInMap("VirtualResourceName")]
        [Validation(Required=false)]
        public string VirtualResourceName { get; set; }

    }

}
