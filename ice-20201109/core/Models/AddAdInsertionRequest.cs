// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class AddAdInsertionRequest : TeaModel {
        /// <summary>
        /// <para>内容URL前缀</para>
        /// 
        /// <b>Example:</b>
        /// <para>ON</para>
        /// </summary>
        [NameInMap("AdMarkerPassthrough")]
        [Validation(Required=false)]
        public string AdMarkerPassthrough { get; set; }

        /// <summary>
        /// <para>广告策略服务器URL</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://ads.com/ad1?param1=%5Bpalyer_params.p1%5D">http://ads.com/ad1?param1=[palyer_params.p1]</a></para>
        /// </summary>
        [NameInMap("AdsUrl")]
        [Validation(Required=false)]
        public string AdsUrl { get; set; }

        /// <summary>
        /// <para>广告分片的CDN前缀</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://cdn.com/">http://cdn.com/</a></para>
        /// </summary>
        [NameInMap("CdnAdSegmentUrlPrefix")]
        [Validation(Required=false)]
        public string CdnAdSegmentUrlPrefix { get; set; }

        /// <summary>
        /// <para>视频内容分片的CDN前缀</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://cdn.com/">http://cdn.com/</a></para>
        /// </summary>
        [NameInMap("CdnContentSegmentUrlPrefix")]
        [Validation(Required=false)]
        public string CdnContentSegmentUrlPrefix { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><b><b>0311a423d11a5f7dee713535</b></b></para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>动态配置别名</para>
        /// 
        /// <b>Example:</b>
        /// <para>{ &quot;player_params.p1&quot;: { &quot;1&quot;: &quot;abc&quot; } }</para>
        /// </summary>
        [NameInMap("ConfigAliases")]
        [Validation(Required=false)]
        public string ConfigAliases { get; set; }

        /// <summary>
        /// <para>内容URL前缀</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://source.com/">https://source.com/</a></para>
        /// </summary>
        [NameInMap("ContentUrlPrefix")]
        [Validation(Required=false)]
        public string ContentUrlPrefix { get; set; }

        /// <summary>
        /// <para>代表资源一级ID的资源属性字段</para>
        /// <para>This parameter is required.</para>
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

}
