// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenITag20220616.Models
{
    public class ViewPlugin : TeaModel {
        /// <summary>
        /// <para>Field mapping to a field in the dataset.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>url</para>
        /// </summary>
        [NameInMap("BindField")]
        [Validation(Required=false)]
        public string BindField { get; set; }

        /// <summary>
        /// <para>Array transformation UDF.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("Convertor")]
        [Validation(Required=false)]
        public string Convertor { get; set; }

        /// <summary>
        /// <para>Whether to handle cross-domain requests.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("CorsProxy")]
        [Validation(Required=false)]
        public bool? CorsProxy { get; set; }

        /// <summary>
        /// <para>Whether to display the original image.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DisplayOriImg")]
        [Validation(Required=false)]
        public bool? DisplayOriImg { get; set; }

        /// <summary>
        /// <para>Extra information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Exif")]
        [Validation(Required=false)]
        public Dictionary<string, object> Exif { get; set; }

        /// <summary>
        /// <para>Whether to hide.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Hide")]
        [Validation(Required=false)]
        public bool? Hide { get; set; }

        /// <summary>
        /// <para>Nested widgets.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("Plugins")]
        [Validation(Required=false)]
        public Dictionary<string, object> Plugins { get; set; }

        /// <summary>
        /// <para>List of associated questions.</para>
        /// </summary>
        [NameInMap("RelationQuestionIds")]
        [Validation(Required=false)]
        public List<string> RelationQuestionIds { get; set; }

        /// <summary>
        /// <para>Widget type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Image: Image.</description></item>
        /// <item><description>Text: Text.</description></item>
        /// <item><description>Video: Video.</description></item>
        /// <item><description>Audio: Audio.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Text</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>Access information.</para>
        /// </summary>
        [NameInMap("VisitInfo")]
        [Validation(Required=false)]
        public ViewPluginVisitInfo VisitInfo { get; set; }
        public class ViewPluginVisitInfo : TeaModel {
            /// <summary>
            /// <para>AFTS configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;expiredTime&quot;:1}</para>
            /// </summary>
            [NameInMap("aftsConf")]
            [Validation(Required=false)]
            public Dictionary<string, object> AftsConf { get; set; }

            /// <summary>
            /// <para>OSS configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;ossEndpoint&quot;:&quot;&quot;,&quot;ossAk&quot;:&quot;&quot;,&quot;ossAs&quot;:&quot;&quot;,&quot;ossOwner&quot;:&quot;&quot;,&quot;ossBucket&quot;:&quot;&quot;,&quot;folder&quot;:&quot;&quot;,&quot;expiredTime&quot;:&quot;&quot;}</para>
            /// </summary>
            [NameInMap("ossConf")]
            [Validation(Required=false)]
            public Dictionary<string, object> OssConf { get; set; }

        }

    }

}
