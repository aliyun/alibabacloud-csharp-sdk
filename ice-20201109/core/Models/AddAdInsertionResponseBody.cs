// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class AddAdInsertionResponseBody : TeaModel {
        /// <summary>
        /// <para>The ad insertion configuration.</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public AddAdInsertionResponseBodyConfig Config { get; set; }
        public class AddAdInsertionResponseBodyConfig : TeaModel {
            /// <summary>
            /// <para>Indicates whether ad marker passthrough is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ON</para>
            /// </summary>
            [NameInMap("AdMarkerPassthrough")]
            [Validation(Required=false)]
            public string AdMarkerPassthrough { get; set; }

            /// <summary>
            /// <para>The request URL of ADS.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://ads.com/ad1?param1=%5Bpalyer_params.p1%5D">http://ads.com/ad1?param1=[palyer_params.p1]</a></para>
            /// </summary>
            [NameInMap("AdsUrl")]
            [Validation(Required=false)]
            public string AdsUrl { get; set; }

            /// <summary>
            /// <para>The CDN configurations.</para>
            /// </summary>
            [NameInMap("CdnConfig")]
            [Validation(Required=false)]
            public AddAdInsertionResponseBodyConfigCdnConfig CdnConfig { get; set; }
            public class AddAdInsertionResponseBodyConfigCdnConfig : TeaModel {
                /// <summary>
                /// <para>The CDN prefix for ad segments.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://cdn.com/">http://cdn.com/</a></para>
                /// </summary>
                [NameInMap("AdSegmentUrlPrefix")]
                [Validation(Required=false)]
                public string AdSegmentUrlPrefix { get; set; }

                /// <summary>
                /// <para>The CDN prefix for content segments.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://cdn.com/">http://cdn.com/</a></para>
                /// </summary>
                [NameInMap("ContentSegmentUrlPrefix")]
                [Validation(Required=false)]
                public string ContentSegmentUrlPrefix { get; set; }

            }

            /// <summary>
            /// <para>The player parameter variables and aliases.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{ &quot;player_params.p1&quot;: { &quot;1&quot;: &quot;abc&quot; } }</para>
            /// </summary>
            [NameInMap("ConfigAliases")]
            [Validation(Required=false)]
            public string ConfigAliases { get; set; }

            /// <summary>
            /// <para>The URL prefix for the source content.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://source.com/">https://source.com/</a></para>
            /// </summary>
            [NameInMap("ContentUrlPrefix")]
            [Validation(Required=false)]
            public string ContentUrlPrefix { get; set; }

            /// <summary>
            /// <para>The time when the configuration was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-06-13T08:26:09Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The time when the configuration was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-06-13T08:26:09Z</para>
            /// </summary>
            [NameInMap("LastModified")]
            [Validation(Required=false)]
            public string LastModified { get; set; }

            /// <summary>
            /// <para>The playback endpoint configuration.</para>
            /// </summary>
            [NameInMap("ManifestEndpointConfig")]
            [Validation(Required=false)]
            public AddAdInsertionResponseBodyConfigManifestEndpointConfig ManifestEndpointConfig { get; set; }
            public class AddAdInsertionResponseBodyConfigManifestEndpointConfig : TeaModel {
                /// <summary>
                /// <para>The prefix of the playback endpoint for HLS manifests.</para>
                /// </summary>
                [NameInMap("HlsPrefix")]
                [Validation(Required=false)]
                public string HlsPrefix { get; set; }

            }

            /// <summary>
            /// <para>The name of the ad insertion configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my_ad</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The personalization threshold.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("PersonalizationThreshold")]
            [Validation(Required=false)]
            public int? PersonalizationThreshold { get; set; }

            /// <summary>
            /// <para>The URL of the slate ad.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://storage.com/slate1.mp4">http://storage.com/slate1.mp4</a></para>
            /// </summary>
            [NameInMap("SlateAdUrl")]
            [Validation(Required=false)]
            public string SlateAdUrl { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b><b>3B-0E1A-586A-AC29-742247</b></b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
