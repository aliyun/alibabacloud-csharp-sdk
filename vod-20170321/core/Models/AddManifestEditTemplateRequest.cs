// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class AddManifestEditTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The name of the template. Spaces are allowed.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>add-multilang-tracks</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The video encoding configuration, such as <c>{&quot;Codec&quot;:&quot;H.264&quot;,&quot;Bitrate&quot;:&quot;5000000&quot;}</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Codec&quot;:&quot;H.264&quot;,&quot;Bitrate&quot;:&quot;5000000&quot;}</para>
        /// </summary>
        [NameInMap("Templates")]
        [Validation(Required=false)]
        public string Templates { get; set; }

    }

}
