// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class CreateVodPackagingConfigurationShrinkRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>hls_3s</para>
        /// </summary>
        [NameInMap("ConfigurationName")]
        [Validation(Required=false)]
        public string ConfigurationName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>HLS 3s vod packaging</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>vod_hls</para>
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        [NameInMap("PackageConfig")]
        [Validation(Required=false)]
        public string PackageConfigShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>HLS</para>
        /// </summary>
        [NameInMap("Protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

    }

}
