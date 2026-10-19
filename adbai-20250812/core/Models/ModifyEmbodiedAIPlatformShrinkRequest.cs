// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ADBAI20250812.Models
{
    public class ModifyEmbodiedAIPlatformShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amv-bp11q28kvl688****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The total number of devices.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("DeviceCount")]
        [Validation(Required=false)]
        public string DeviceCount { get; set; }

        /// <summary>
        /// <para>The name of the embodied AI multimodal data platform.</para>
        /// <remarks>
        /// <para>The name must be 1 to 16 characters in length and can contain lowercase letters, digits, and underscores (_). It must start with a letter and end with a letter or digit.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eap_platform</para>
        /// </summary>
        [NameInMap("PlatformName")]
        [Validation(Required=false)]
        public string PlatformName { get; set; }

        /// <summary>
        /// <para>The Ray specifications of the platform.</para>
        /// </summary>
        [NameInMap("RayConfig")]
        [Validation(Required=false)]
        public string RayConfigShrink { get; set; }

        /// <summary>
        /// <para>The configuration of development and training resources.</para>
        /// </summary>
        [NameInMap("RayTrainConfig")]
        [Validation(Required=false)]
        public string RayTrainConfigShrink { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <remarks>
        /// <para>You can call the DescribeRegions operation to query the region ID of a specified Data Lakehouse Edition cluster.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The Webserver specification of the platform.</para>
        /// 
        /// <b>Example:</b>
        /// <para>large</para>
        /// </summary>
        [NameInMap("WebserverSpecName")]
        [Validation(Required=false)]
        public string WebserverSpecName { get; set; }

    }

}
