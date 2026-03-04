// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class MediaConvertOutputGroup : TeaModel {
        /// <summary>
        /// <para>The output group configuration.</para>
        /// </summary>
        [NameInMap("GroupConfig")]
        [Validation(Required=false)]
        public MediaConvertOutputGroupConfig GroupConfig { get; set; }

        /// <summary>
        /// <para>The name of the output group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hls-group</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>A list of individual output stream configurations. Each object in this array defines a specific rendition.</para>
        /// </summary>
        [NameInMap("Outputs")]
        [Validation(Required=false)]
        public List<MediaConvertOutputGroupOutput> Outputs { get; set; }

    }

}
