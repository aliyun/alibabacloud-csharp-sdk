// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class CreateVodPackagingConfigurationShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The name of the packaging configuration. The name must be unique in an account and can be up to 128 characters in length. Letters, digits, underscores (_), and hyphens (-) are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hls_3s</para>
        /// </summary>
        [NameInMap("ConfigurationName")]
        [Validation(Required=false)]
        public string ConfigurationName { get; set; }

        /// <summary>
        /// <para>The description of the packaging configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HLS 3s vod packaging</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the packaging group. The name can be up to 128 characters in length. Letters, digits, underscores (_), and hyphens (-) are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vod_hls</para>
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// <para>The packaging configuration.</para>
        /// </summary>
        [NameInMap("PackageConfig")]
        [Validation(Required=false)]
        public string PackageConfigShrink { get; set; }

        /// <summary>
        /// <para>The package type.</para>
        /// <list type="bullet">
        /// <item><description>HLS: packages content into TS segments for delivery over the HLS protocol.</description></item>
        /// <item><description>HLS_CMAF: packages content into CMAF segments for delivery over the HLS protocol.</description></item>
        /// <item><description>DASH: packages content for delivery over the DASH protocol.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>HLS</para>
        /// </summary>
        [NameInMap("Protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

    }

}
