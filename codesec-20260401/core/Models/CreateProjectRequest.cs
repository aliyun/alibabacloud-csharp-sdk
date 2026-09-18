// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CodeSec20260401.Models
{
    public class CreateProjectRequest : TeaModel {
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
        public CreateProjectRequestEngines Engines { get; set; }
        public class CreateProjectRequestEngines : TeaModel {
            /// <summary>
            /// <para>Specifies whether SAST is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("sast")]
            [Validation(Required=false)]
            public bool? Sast { get; set; }

            /// <summary>
            /// <para>The engine-level configuration.</para>
            /// </summary>
            [NameInMap("sastConfig")]
            [Validation(Required=false)]
            public CreateProjectRequestEnginesSastConfig SastConfig { get; set; }
            public class CreateProjectRequestEnginesSastConfig : TeaModel {
                /// <summary>
                /// <para>Specifies whether to generate remediation suggestions.</para>
                /// </summary>
                [NameInMap("remediation")]
                [Validation(Required=false)]
                public bool? Remediation { get; set; }

            }

            /// <summary>
            /// <para>Specifies whether SCA is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("sca")]
            [Validation(Required=false)]
            public bool? Sca { get; set; }

            /// <summary>
            /// <para>The engine-level configuration.</para>
            /// </summary>
            [NameInMap("scaConfig")]
            [Validation(Required=false)]
            public CreateProjectRequestEnginesScaConfig ScaConfig { get; set; }
            public class CreateProjectRequestEnginesScaConfig : TeaModel {
                /// <summary>
                /// <para>Specifies whether to generate remediation suggestions.</para>
                /// </summary>
                [NameInMap("remediation")]
                [Validation(Required=false)]
                public bool? Remediation { get; set; }

            }

        }

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
        public CreateProjectRequestSource Source { get; set; }
        public class CreateProjectRequestSource : TeaModel {
            /// <summary>
            /// <para>The project type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>api</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
