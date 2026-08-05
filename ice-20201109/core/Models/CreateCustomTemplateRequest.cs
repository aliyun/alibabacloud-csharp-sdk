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
        /// <para>Transcoding template subtypes:</para>
        /// <list type="bullet">
        /// <item><description>1: normal transcoding template (Normal)</description></item>
        /// <item><description>2: audio transcoding template (AudioTranscode)</description></item>
        /// <item><description>3: container format conversion (Remux)</description></item>
        /// <item><description>4: Narrowband HD 1.0 (NarrowBandV1)</description></item>
        /// <item><description>5: Narrowband HD 2.0 (NarrowBandV2)</description></item>
        /// </list>
        /// <para>Snapshot template subtypes:</para>
        /// <list type="bullet">
        /// <item><description>1: normal snapshot/static snapshot (Normal)</description></item>
        /// <item><description>2: sprite snapshot (Sprite)</description></item>
        /// <item><description>3: WebVTT snapshot (WebVtt)</description></item>
        /// </list>
        /// <para>AI review template subtypes:</para>
        /// <list type="bullet">
        /// <item><description>1: video review (Video) </description></item>
        /// <item><description>2: audio review (Audio)</description></item>
        /// <item><description>3: image review (Image)</description></item>
        /// </list>
        /// <para>AI intelligent erasure template subtypes:</para>
        /// <list type="bullet">
        /// <item><description>1: logo erasure (VideoDelogo)</description></item>
        /// <item><description>2: subtitle erasure (VideoDetext)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Subtype")]
        [Validation(Required=false)]
        public int? Subtype { get; set; }

        /// <summary>
        /// <para>The template configuration. For detailed metric description, see <a href="https://help.aliyun.com/document_detail/448291.html">Template parameters</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Container&quot;:{&quot;Format&quot;:&quot;flv&quot;},&quot;Video&quot;:{},&quot;Audio&quot;:{}}</para>
        /// </summary>
        [NameInMap("TemplateConfig")]
        [Validation(Required=false)]
        public string TemplateConfig { get; set; }

        /// <summary>
        /// <para>The templatetype. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: transcoding template</description></item>
        /// <item><description>2: snapshot template</description></item>
        /// <item><description>3: animated image template</description></item>
        /// <item><description>4: image watermark template</description></item>
        /// <item><description>5: text watermark template</description></item>
        /// <item><description>6: subtitle template</description></item>
        /// <item><description>7: AI intelligent review</description></item>
        /// <item><description>8: AI intelligent cover</description></item>
        /// <item><description>9: AI intelligent erasure</description></item>
        /// <item><description>10: AI intelligent DNA template</description></item>
        /// <item><description>11: AI intelligent label template</description></item>
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
