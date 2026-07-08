// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class InitiatePptCreationRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("ExternalUserId")]
        [Validation(Required=false)]
        public string ExternalUserId { get; set; }

        /// <summary>
        /// <para>The outline.</para>
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
        /// <para>The task ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>95c2fbe6-5a20-4fc2-8a93-376ed05fbe13</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>The unique ID of the Alibaba Cloud Model Studio workspace. For more information, see <a href="https://help.aliyun.com/document_detail/2782167.html">Obtain a workspace ID</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>llm-3fy94b2rtadt01qa</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
