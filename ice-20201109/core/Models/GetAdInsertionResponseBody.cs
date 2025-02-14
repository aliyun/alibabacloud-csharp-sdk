// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetAdInsertionResponseBody : TeaModel {
        [NameInMap("Config")]
        [Validation(Required=false)]
        public GetAdInsertionResponseBodyConfig Config { get; set; }
        public class GetAdInsertionResponseBodyConfig : TeaModel {
            /// <summary>
            /// <para>广告标记透传</para>
            /// 
            /// <b>Example:</b>
            /// <para>ON</para>
            /// </summary>
            [NameInMap("AdMarkerPassthrough")]
            [Validation(Required=false)]
            public string AdMarkerPassthrough { get; set; }

            /// <summary>
            /// <para>广告策略服务器URL</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://ads.com/ad1?param1=%5Bpalyer_params.p1%5D">http://ads.com/ad1?param1=[palyer_params.p1]</a></para>
            /// </summary>
            [NameInMap("AdsUrl")]
            [Validation(Required=false)]
            public string AdsUrl { get; set; }

            /// <summary>
            /// <para>CDN配置</para>
            /// </summary>
            [NameInMap("CdnConfig")]
            [Validation(Required=false)]
            public GetAdInsertionResponseBodyConfigCdnConfig CdnConfig { get; set; }
            public class GetAdInsertionResponseBodyConfigCdnConfig : TeaModel {
                /// <summary>
                /// <para>广告分片的CDN前缀</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://cdn.com/">http://cdn.com/</a></para>
                /// </summary>
                [NameInMap("AdSegmentUrlPrefix")]
                [Validation(Required=false)]
                public string AdSegmentUrlPrefix { get; set; }

                /// <summary>
                /// <para>视频内容分片的CDN前缀</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://cdn.com/">http://cdn.com/</a></para>
                /// </summary>
                [NameInMap("ContentSegmentUrlPrefix")]
                [Validation(Required=false)]
                public string ContentSegmentUrlPrefix { get; set; }

            }

            /// <summary>
            /// <para>动态配置别名</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///       &quot;player_params.p1&quot;: {
            ///             &quot;1&quot;: &quot;abc&quot;
            ///       }
            /// }</para>
            /// </summary>
            [NameInMap("ConfigAliases")]
            [Validation(Required=false)]
            public string ConfigAliases { get; set; }

            /// <summary>
            /// <para>内容URL前缀</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://source.com/">https://source.com/</a></para>
            /// </summary>
            [NameInMap("ContentUrlPrefix")]
            [Validation(Required=false)]
            public string ContentUrlPrefix { get; set; }

            /// <summary>
            /// <para>创建时间</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-06-13T08:26:09Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>修改时间</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-06-13T08:26:09Z</para>
            /// </summary>
            [NameInMap("LastModified")]
            [Validation(Required=false)]
            public string LastModified { get; set; }

            /// <summary>
            /// <para>清单播放端点配置</para>
            /// </summary>
            [NameInMap("ManifestEndpointConfig")]
            [Validation(Required=false)]
            public GetAdInsertionResponseBodyConfigManifestEndpointConfig ManifestEndpointConfig { get; set; }
            public class GetAdInsertionResponseBodyConfigManifestEndpointConfig : TeaModel {
                /// <summary>
                /// <para>HLS清单播放端点前缀</para>
                /// </summary>
                [NameInMap("HlsPrefix")]
                [Validation(Required=false)]
                public string HlsPrefix { get; set; }

            }

            /// <summary>
            /// <para>广告插入配置名称</para>
            /// 
            /// <b>Example:</b>
            /// <para>my_ad</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>个性化配置阈值</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("PersonalizationThreshold")]
            [Validation(Required=false)]
            public int? PersonalizationThreshold { get; set; }

            /// <summary>
            /// <para>slate广告URL</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://storage.com/slate1.mp4">http://storage.com/slate1.mp4</a></para>
            /// </summary>
            [NameInMap("SlateAdUrl")]
            [Validation(Required=false)]
            public string SlateAdUrl { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para><b><b><b>3B-0E1A-586A-AC29-742247</b></b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
