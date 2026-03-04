// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class MediaConvertOutputGroupConfig : TeaModel {
        /// <summary>
        /// <para>The filename for the manifest. This parameter is only applicable when Type is set to Hls or Dash.</para>
        /// 
        /// <b>Example:</b>
        /// <para>manifest</para>
        /// </summary>
        [NameInMap("ManifestName")]
        [Validation(Required=false)]
        public string ManifestName { get; set; }

        /// <summary>
        /// <para>The directory where all files for this output group are stored.</para>
        /// </summary>
        [NameInMap("OutputFileBase")]
        [Validation(Required=false)]
        public MediaObject OutputFileBase { get; set; }

        /// <summary>
        /// <para>The type of the output group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>File: Generates one or more standalone files.</description></item>
        /// <item><description>Hls: Generates HLS manifests.</description></item>
        /// <item><description>Dash: Generates DASH manifests.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Hls</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
