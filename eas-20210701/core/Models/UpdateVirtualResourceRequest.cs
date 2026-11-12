// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class UpdateVirtualResourceRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to disable the protection period for spot instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DisableSpotProtectionPeriod")]
        [Validation(Required=false)]
        public bool? DisableSpotProtectionPeriod { get; set; }

        /// <summary>
        /// <para>The list of resources contained in the virtual resource group.</para>
        /// <remarks>
        /// <para>Notice: If specified, the previous data is overwritten.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Resources")]
        [Validation(Required=false)]
        public List<UpdateVirtualResourceRequestResources> Resources { get; set; }
        public class UpdateVirtualResourceRequestResources : TeaModel {
            /// <summary>
            /// <para>The instance type of the public resource group.</para>
            /// <remarks>
            /// <para>Notice: You must specify exactly one of the following fields: InstanceType, ResourceId, and QuotaId.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>ecs.s6-c1m2.xlarge</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>The scheduling priority of the resource. A larger value indicates a higher scheduling priority.</para>
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
            /// <para>Notice: You must specify exactly one of the following fields: InstanceType, ResourceId, and QuotaId.</para>
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
            /// <para>The ID of the dedicated resource group. For more information about how to query the ID of a dedicated resource group, see <a href="https://help.aliyun.com/document_detail/412133.html">ListResources</a>.</para>
            /// <remarks>
            /// <para>Notice: You must specify exactly one of the following fields: InstanceType, ResourceId, and QuotaId.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>eas-r-g55ieatgg3butwrn7a</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <para>The maximum price for spot instances in the public resource group.
            /// <notice>If not specified, spot instances are not used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.05</para>
            /// </summary>
            [NameInMap("SpotPriceLimit")]
            [Validation(Required=false)]
            public float? SpotPriceLimit { get; set; }

        }

        /// <summary>
        /// <para>The new name of the virtual resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NewMyVirtualResource</para>
        /// </summary>
        [NameInMap("VirtualResourceName")]
        [Validation(Required=false)]
        public string VirtualResourceName { get; set; }

    }

}
