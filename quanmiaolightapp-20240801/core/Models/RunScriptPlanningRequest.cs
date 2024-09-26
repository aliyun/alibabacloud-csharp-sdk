// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.QuanMiaoLightApp20240801.Models
{
    public class RunScriptPlanningRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>故事尽可能狗血</para>
        /// </summary>
        [NameInMap("additionalNote")]
        [Validation(Required=false)]
        public string AdditionalNote { get; set; }

        [NameInMap("dialogueInScene")]
        [Validation(Required=false)]
        public bool? DialogueInScene { get; set; }

        [NameInMap("plotConflict")]
        [Validation(Required=false)]
        public bool? PlotConflict { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>都市战神</para>
        /// </summary>
        [NameInMap("scriptName")]
        [Validation(Required=false)]
        public string ScriptName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("scriptShotCount")]
        [Validation(Required=false)]
        public int? ScriptShotCount { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>在一个宁静的小镇上，每个家庭都在同一天收到一个神秘的、没有标记的包裹。</para>
        /// </summary>
        [NameInMap("scriptSummary")]
        [Validation(Required=false)]
        public string ScriptSummary { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>现代，都市，爱情，玄幻</para>
        /// </summary>
        [NameInMap("scriptTypeKeyword")]
        [Validation(Required=false)]
        public string ScriptTypeKeyword { get; set; }

    }

}
