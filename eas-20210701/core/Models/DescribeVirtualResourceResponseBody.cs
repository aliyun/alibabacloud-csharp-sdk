// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class DescribeVirtualResourceResponseBody : TeaModel {
        /// <summary>
        /// <para>The time when the virtual resource group was created, in UTC in RFC 3339 format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-10-16T17:52:49Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>Indicates whether the protection period for spot instances is disabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DisableSpotProtectionPeriod")]
        [Validation(Required=false)]
        public bool? DisableSpotProtectionPeriod { get; set; }

        /// <summary>
        /// <para>The set of features of the virtual resource group, which identifies the capabilities supported by the resource group.</para>
        /// </summary>
        [NameInMap("Features")]
        [Validation(Required=false)]
        public List<string> Features { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>40325405-579C-4D82****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of resources contained in the virtual resource group.</para>
        /// </summary>
        [NameInMap("Resources")]
        [Validation(Required=false)]
        public List<DescribeVirtualResourceResponseBodyResources> Resources { get; set; }
        public class DescribeVirtualResourceResponseBodyResources : TeaModel {
            /// <summary>
            /// <para>The instance type of the public resource group.</para>
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
            /// <para>3</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// <para>The Lingjun resource quota ID.</para>
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
            /// <para>The dedicated resource group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eas-r-g55ieatgg3buxxxxxx</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <para>The maximum price for spot instances in the public resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.05</para>
            /// </summary>
            [NameInMap("SpotPriceLimit")]
            [Validation(Required=false)]
            public float? SpotPriceLimit { get; set; }

        }

        /// <summary>
        /// <para>The number of deployed services.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ServiceCount")]
        [Validation(Required=false)]
        public int? ServiceCount { get; set; }

        /// <summary>
        /// <para>The time when the virtual resource group was last updated, in UTC in RFC 3339 format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-10-16T19:52:49Z</para>
        /// </summary>
        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// <para>The virtual resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eas-vr-npovr28onap1xxxxxx</para>
        /// </summary>
        [NameInMap("VirtualResourceId")]
        [Validation(Required=false)]
        public string VirtualResourceId { get; set; }

        /// <summary>
        /// <para>The name of the virtual resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MyVirtualResource</para>
        /// </summary>
        [NameInMap("VirtualResourceName")]
        [Validation(Required=false)]
        public string VirtualResourceName { get; set; }

    }

}
