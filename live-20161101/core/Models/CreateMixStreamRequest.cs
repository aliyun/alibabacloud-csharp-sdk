// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class CreateMixStreamRequest : TeaModel {
        /// <summary>
        /// <para>The callback URL. The value is a JSON array. If a callback event is triggered, ApsaraVideo Live sends an HTTP POST request to the URL. The content is included in the HTTP request body.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;CallbackUrl&quot;:&quot;<a href="http://aliyundoc.com%22%7D">http://aliyundoc.com&quot;}</a></para>
        /// </summary>
        [NameInMap("CallbackConfig")]
        [Validation(Required=false)]
        public string CallbackConfig { get; set; }

        /// <summary>
        /// <para>The main streaming domain.</para>
        /// <remarks>
        /// <para> Only domain names that reside in the China (Shanghai) and China (Beijing) regions are supported.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The input streams. The value is a JSON array.</para>
        /// <para>For more information, see <b>InputStreamConfig</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;LayoutChildId&quot;:1,&quot;ResourceType&quot;:&quot;live&quot;,&quot;ResourceValue&quot;:&quot;rtmp://example.net/live/f2139ec2b8d6a191068cd<b><b>ea9064d?auth_key=1600947017-0-0-0b5645fe35d21a65ab92b394bd4d</b></b>&quot;,&quot;LayoutConfig&quot;:{&quot;FillMode&quot;:&quot;fit&quot;,&quot;PositionRefer&quot;:&quot;topLeft&quot;,&quot;FillPositionNormalized&quot;:[0,0],&quot;FillSizeNormalized&quot;:[1,1]}}]</para>
        /// </summary>
        [NameInMap("InputStreamList")]
        [Validation(Required=false)]
        public string InputStreamList { get; set; }

        /// <summary>
        /// <para>The ID of the layout. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>MixStreamLayout-1-1</b></description></item>
        /// <item><description><b>MixStreamLayout-2-1</b></description></item>
        /// <item><description><b>MixStreamLayout-2-2</b></description></item>
        /// <item><description><b>MixStreamLayout-2-3</b></description></item>
        /// <item><description><b>MixStreamLayout-3-1</b></description></item>
        /// <item><description><b>MixStreamLayout-3-2</b></description></item>
        /// <item><description><b>MixStreamLayout-4-1</b></description></item>
        /// <item><description><b>USERDEFINED</b>: If you do not use a preset layout, set this parameter to <b>USERDEFINED</b>.</description></item>
        /// </list>
        /// <remarks>
        /// <para> For more information, see <a href="https://help.aliyun.com/document_detail/199361.html">Preset layouts for stream mixing</a>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MixStreamLayout-1-1</para>
        /// </summary>
        [NameInMap("LayoutId")]
        [Validation(Required=false)]
        public string LayoutId { get; set; }

        /// <summary>
        /// <para>The configuration of the output stream. The value is a JSON string.</para>
        /// <para>For more information, see <b>OutputConfig</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;AppName&quot;:&quot;liveApp****&quot;,&quot;StreamName&quot;:&quot;9a78fb3f5c508be0122746f677a3****&quot;,&quot;MixStreamTemplate&quot;:&quot;lp_hd_v&quot;,&quot;ExpireDuration&quot;:&quot;86400&quot;}</para>
        /// </summary>
        [NameInMap("OutputConfig")]
        [Validation(Required=false)]
        public string OutputConfig { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
