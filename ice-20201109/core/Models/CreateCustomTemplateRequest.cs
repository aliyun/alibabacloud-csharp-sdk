// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class CreateCustomTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The template name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-template</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The template subtype.</para>
        /// <para>Valid values for transcoding templates:</para>
        /// <list type="bullet">
        /// <item><description>1 (Normal): regular template.</description></item>
        /// <item><description>2 (AudioTranscode): audio transcoding template.</description></item>
        /// <item><description>3 (Remux): container format conversion template.</description></item>
        /// <item><description>4 (NarrowBandV1): Narrowband HD 1.0 template.</description></item>
        /// <item><description>5 (NarrowBandV2): Narrowband HD 2.0 template.</description></item>
        /// </list>
        /// <para>Valid values for snapshot templates:</para>
        /// <list type="bullet">
        /// <item><description>1 (Normal): regular template.</description></item>
        /// <item><description>2 (Sprite): sprite template.</description></item>
        /// <item><description>3 (WebVtt): WebVTT template.</description></item>
        /// </list>
        /// <para>Valid values for AI-assisted content moderation templates:</para>
        /// <list type="bullet">
        /// <item><description>1 (Video): video moderation template.</description></item>
        /// <item><description>2 (Audio): audio moderation template.</description></item>
        /// <item><description>3 (Image): image moderation template.</description></item>
        /// </list>
        /// <para>Valid values for AI-assisted intelligent erasure templates.</para>
        /// <list type="bullet">
        /// <item><description>1 (VideoDelogo): logo erasure template.</description></item>
        /// <item><description>2 (VideoDetext): subtitle erasure template.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Subtype")]
        [Validation(Required=false)]
        public int? Subtype { get; set; }

        /// <summary>
        /// <para>The template configurations. For more information, see <a href="https://help.aliyun.com/document_detail/448291.html">Template parameters</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Container&quot;:{&quot;Format&quot;:&quot;flv&quot;},&quot;Video&quot;:{},&quot;Audio&quot;:{}}</para>
        /// </summary>
        [NameInMap("TemplateConfig")]
        [Validation(Required=false)]
        public string TemplateConfig { get; set; }

        /// <summary>
        /// <para>The template type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: transcoding template.</description></item>
        /// <item><description>2: snapshot template.</description></item>
        /// <item><description>3: animated image template.</description></item>
        /// <item><description>4\. image watermark template.</description></item>
        /// <item><description>5: text watermark template.</description></item>
        /// <item><description>6: subtitle template.</description></item>
        /// <item><description>7: AI-assisted content moderation template.</description></item>
        /// <item><description>8: AI-assisted intelligent thumbnail template.</description></item>
        /// <item><description>9: AI-assisted intelligent erasure template.</description></item>
        /// <item><description>10: AI-assisted media fingerprint analysis template.</description></item>
        /// <item><description>11: AI-assisted smart tagging template.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

    }

}
