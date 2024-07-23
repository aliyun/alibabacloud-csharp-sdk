// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class AddPipelineRequest : TeaModel {
        /// <summary>
        /// <para>The name of the MPS queue. The name can be up to 128 bytes in size.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-pipeline</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The Message Service (MNS) configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Topic&quot;:&quot;mts-topic-1&quot;}</para>
        /// </summary>
        [NameInMap("NotifyConfig")]
        [Validation(Required=false)]
        public string NotifyConfig { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The role.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AliyunMTSDefaultRole</para>
        /// </summary>
        [NameInMap("Role")]
        [Validation(Required=false)]
        public string Role { get; set; }

        /// <summary>
        /// <para>The type of the MPS queue. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Boost</b>: MPS queue with transcoding speed boosted.</description></item>
        /// <item><description><b>Standard</b>: standard MPS queue.</description></item>
        /// <item><description><b>NarrowBandHDV2</b>: MPS queue that supports Narrowband HD 2.0.</description></item>
        /// <item><description><b>AIVideoCover</b>: MPS queue for intelligent snapshot capture.</description></item>
        /// <item><description><b>AIVideoTag</b>: MPS queue for video tagging. The supported regions are China (Shanghai), China (Beijing), and China (Hangzhou).</description></item>
        /// </list>
        /// <para>Default value: <b>Standard</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Standard</para>
        /// </summary>
        [NameInMap("Speed")]
        [Validation(Required=false)]
        public string Speed { get; set; }

        /// <summary>
        /// <para>The level of the MPS queue. Valid values: <b>1 to 3</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SpeedLevel")]
        [Validation(Required=false)]
        public long? SpeedLevel { get; set; }

    }

}
