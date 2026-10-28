// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class ResourceInfos : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c1a2b3c4d5e6f7a8b9c0d1e2f3a4b5c6</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The ECS instance type information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.gn5-c8g1.2xlarge</para>
        /// </summary>
        [NameInMap("EcsSpec")]
        [Validation(Required=false)]
        public string EcsSpec { get; set; }

        /// <summary>
        /// <para>The GPU card type.</para>
        /// </summary>
        [NameInMap("GpuCardType")]
        [Validation(Required=false)]
        public string GpuCardType { get; set; }

        /// <summary>
        /// <para>The machine model.</para>
        /// </summary>
        [NameInMap("MachineModel")]
        [Validation(Required=false)]
        public string MachineModel { get; set; }

        /// <summary>
        /// <para>The maximum quota.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("MaxQuota")]
        [Validation(Required=false)]
        public long? MaxQuota { get; set; }

        /// <summary>
        /// <para>The network pod ID.</para>
        /// </summary>
        [NameInMap("NetworkPodId")]
        [Validation(Required=false)]
        public string NetworkPodId { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The used quota.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("UsedQuota")]
        [Validation(Required=false)]
        public long? UsedQuota { get; set; }

        /// <summary>
        /// <para>The user ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456789</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <para>The username.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
