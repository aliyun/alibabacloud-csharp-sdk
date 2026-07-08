// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class InitiatePptCreationV2Request : TeaModel {
        /// <summary>
        /// <para>The unique ID of the external user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("ExternalUserId")]
        [Validation(Required=false)]
        public string ExternalUserId { get; set; }

        /// <summary>
        /// <para>Specifies whether the request originates from a mobile client.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsMobile")]
        [Validation(Required=false)]
        public bool? IsMobile { get; set; }

        /// <summary>
        /// <para>The presentation outline, formatted in Markdown.</para>
        /// 
        /// <b>Example:</b>
        /// <h1>中国传统文化艺术的魅力</h1>
        /// <h2>1. 传统文化艺术的源远流长</h2>
        /// <h3>1.1 中国古代艺术发展历程</h3>
        /// <h4>1.1.1 古代绘画艺术的演变</h4>
        /// <list type="bullet">
        /// <item><description>从新石器时代的彩陶绘画到东汉时期帛画的出现，绘画形式不断丰富，展现了古人对美的独特追求。唐代绘画风格多样，吴道子的《送子天王图》线条流畅，色彩绚丽，体现了唐代绘画的高超技艺。</description></item>
        /// </list>
        /// <h4>1.1.2 书法艺术的传承与创新</h4>
        /// <list type="bullet">
        /// <item><description>书法从甲骨文到楷书、行书、草书，历经数千年演变，承载着中华文化的深厚内涵。王羲之的《兰亭序》被誉为“天下第一行书”，其笔法精妙，结构严谨，展现了书法艺术的巅峰。</description></item>
        /// </list>
        /// </summary>
        [NameInMap("Outline")]
        [Validation(Required=false)]
        public string Outline { get; set; }

        /// <summary>
        /// <para>The ID of the PPT template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("PptTemplateId")]
        [Validation(Required=false)]
        public int? PptTemplateId { get; set; }

        /// <summary>
        /// <para>The template type. The default value is <c>1</c>. Valid values: <c>1</c> (system template) and <c>2</c> (enterprise template).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PptTemplateType")]
        [Validation(Required=false)]
        public int? PptTemplateType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>中国传统文化艺术的魅力</para>
        /// </summary>
        [NameInMap("PptTitle")]
        [Validation(Required=false)]
        public string PptTitle { get; set; }

        /// <summary>
        /// <para>The type of process to initiate. Valid values:<br>
        /// <c>0</c>: Generates only a signature to initialize the front-end SDK for the full creation process.<br>
        /// <c>1</c>: Generates a signature and a process ID. Use this option if you have a custom front-end page for templates before you initialize the SDK.<br>
        /// <c>2</c>: Generates an artifact ID, which allows for direct editing of the artifact.<br>
        /// <c>3</c>: Generates an export task ID. You can poll this ID to retrieve the export result.<br><br><br><br></para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ProcessType")]
        [Validation(Required=false)]
        public int? ProcessType { get; set; }

        /// <summary>
        /// <para>The ID of the task.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8a7dfece-f204-4380-a7d0-a13d37de3924</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>The ID of the workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>llm-2setzb9x4ewsd</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
