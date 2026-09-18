// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CodeSec20260401.Models
{
    public class CreateProjectShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is default function description by fc-deploy component</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The engine switches for the project or scan snapshot. Only SAST and SCA are supported.</para>
        /// </summary>
        [NameInMap("engines")]
        [Validation(Required=false)]
        public string EnginesShrink { get; set; }

        /// <summary>
        /// <para>The natural language prompt that describes scanning or result processing preferences, such as ignoring low-risk vulnerabilities.</para>
        /// 
        /// <b>Example:</b>
        /// <para>such as ignoring low-severity vulnerabilities, etc.</para>
        /// </summary>
        [NameInMap("instructionPrompt")]
        [Validation(Required=false)]
        public string InstructionPrompt { get; set; }

        /// <summary>
        /// <para>The project name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user_paswd_103</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The project source.</para>
        /// </summary>
        [NameInMap("source")]
        [Validation(Required=false)]
        public string SourceShrink { get; set; }

    }

}
