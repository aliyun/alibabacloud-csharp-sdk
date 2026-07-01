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
        /// <item><description><para>1 (Normal): regular template.</para>
        /// </description></item>
        /// <item><description><para>2 (AudioTranscode): audio transcoding template.</para>
        /// </description></item>
        /// <item><description><para>3 (Remux): container format conversion template.</para>
        /// </description></item>
        /// <item><description><para>4 (NarrowBandV1): Narrowband HD 1.0 template.</para>
        /// </description></item>
        /// <item><description><para>5 (NarrowBandV2): Narrowband HD 2.0 template.</para>
        /// </description></item>
        /// </list>
        /// <para>Valid values for snapshot templates:</para>
        /// <list type="bullet">
        /// <item><description><para>1 (Normal): regular template.</para>
        /// </description></item>
        /// <item><description><para>2 (Sprite): sprite template.</para>
        /// </description></item>
        /// <item><description><para>3 (WebVtt): WebVTT template.</para>
        /// </description></item>
        /// </list>
        /// <para>Valid values for AI-assisted content moderation templates:</para>
        /// <list type="bullet">
        /// <item><description><para>1 (Video): video moderation template.</para>
        /// </description></item>
        /// <item><description><para>2 (Audio): audio moderation template.</para>
        /// </description></item>
        /// <item><description><para>3 (Image): image moderation template.</para>
        /// </description></item>
        /// </list>
        /// <para>Valid values for AI-assisted intelligent erasure templates.</para>
        /// <list type="bullet">
        /// <item><description><para>1 (VideoDelogo): logo erasure template.</para>
        /// </description></item>
        /// <item><description><para>2 (VideoDetext): subtitle erasure template.</para>
        /// </description></item>
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
        /// <item><description><para>1: transcoding template.</para>
        /// </description></item>
        /// <item><description><para>2: snapshot template.</para>
        /// </description></item>
        /// <item><description><para>3: animated image template.</para>
        /// </description></item>
        /// <item><description><para>4\. image watermark template.</para>
        /// </description></item>
        /// <item><description><para>5: text watermark template.</para>
        /// </description></item>
        /// <item><description><para>6: subtitle template.</para>
        /// </description></item>
        /// <item><description><para>7: AI-assisted content moderation template.</para>
        /// </description></item>
        /// <item><description><para>8: AI-assisted intelligent thumbnail template.</para>
        /// </description></item>
        /// <item><description><para>9: AI-assisted intelligent erasure template.</para>
        /// </description></item>
        /// <item><description><para>10: AI-assisted media fingerprint analysis template.</para>
        /// </description></item>
        /// <item><description><para>11: AI-assisted smart tagging template.</para>
        /// </description></item>
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
