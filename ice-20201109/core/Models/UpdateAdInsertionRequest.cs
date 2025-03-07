// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class UpdateAdInsertionRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable ad marker passthrough. Default value: OFF.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>OFF: Disable.</description></item>
        /// <item><description>ON: Enable.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ON</para>
        /// </summary>
        [NameInMap("AdMarkerPassthrough")]
        [Validation(Required=false)]
        public string AdMarkerPassthrough { get; set; }

        /// <summary>
        /// <para>The request URL of the ad decision server (ADS). HTTP and HTTPS are supported. The maximum length is 2,048 characters.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://ads.com/ad1?param1=%5Bpalyer_params.p1%5D">http://ads.com/ad1?param1=[palyer_params.p1]</a></para>
        /// </summary>
        [NameInMap("AdsUrl")]
        [Validation(Required=false)]
        public string AdsUrl { get; set; }

        /// <summary>
        /// <para>The CDN prefix for ad segments. HTTP and HTTPS are supported. The maximum length is 512 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://cdn.com/">http://cdn.com/</a></para>
        /// </summary>
        [NameInMap("CdnAdSegmentUrlPrefix")]
        [Validation(Required=false)]
        public string CdnAdSegmentUrlPrefix { get; set; }

        /// <summary>
        /// <para>The CDN prefix for content segments. HTTP and HTTPS are supported. The maximum length is 512 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://cdn.com/">http://cdn.com/</a></para>
        /// </summary>
        [NameInMap("CdnContentSegmentUrlPrefix")]
        [Validation(Required=false)]
        public string CdnContentSegmentUrlPrefix { get; set; }

        /// <summary>
        /// <para>A JSON string that specifies the player parameter variables and aliases. Format: { &quot;player_params.{name}&quot;: { &quot;{key}&quot;: &quot;{value}&quot; } }. You can add up to 20 player_params.{name} entries. The name field can be up to 150 characters in length. Each player parameter can include up to 50 key-value pairs. A key can be up to 150 characters long, and a value can be up to 500 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{ &quot;player_params.p1&quot;: { &quot;1&quot;: &quot;abc&quot; } }</para>
        /// </summary>
        [NameInMap("ConfigAliases")]
        [Validation(Required=false)]
        public string ConfigAliases { get; set; }

        /// <summary>
        /// <para>The URL prefix for the source content. HTTP and HTTPS are supported. The maximum length is 512 characters.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://source.com/">https://source.com/</a></para>
        /// </summary>
        [NameInMap("ContentUrlPrefix")]
        [Validation(Required=false)]
        public string ContentUrlPrefix { get; set; }

        /// <summary>
        /// <para>The configuration name, which cannot be modified.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my_ad</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Specifies the maximum duration of underfilled time allowed in an ad break. Unit: seconds. Default value: 8 seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("PersonalizationThreshold")]
        [Validation(Required=false)]
        public int? PersonalizationThreshold { get; set; }

        /// <summary>
        /// <para>The HTTP or HTTPS URL of the slate ad. Only MP4 format is supported. The maximum length is 2,048 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://storage.com/slate1.mp4">http://storage.com/slate1.mp4</a></para>
        /// </summary>
        [NameInMap("SlateAdUrl")]
        [Validation(Required=false)]
        public string SlateAdUrl { get; set; }

    }

}
