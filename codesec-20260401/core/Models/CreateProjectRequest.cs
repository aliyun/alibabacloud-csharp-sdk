// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CodeSec20260401.Models
{
    public class CreateProjectRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>This is default function description by fc-deploy component</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("engines")]
        [Validation(Required=false)]
        public CreateProjectRequestEngines Engines { get; set; }
        public class CreateProjectRequestEngines : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("sast")]
            [Validation(Required=false)]
            public bool? Sast { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("sca")]
            [Validation(Required=false)]
            public bool? Sca { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>such as ignoring low-severity vulnerabilities, etc.</para>
        /// </summary>
        [NameInMap("instructionPrompt")]
        [Validation(Required=false)]
        public string InstructionPrompt { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user_paswd_103</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("source")]
        [Validation(Required=false)]
        public CreateProjectRequestSource Source { get; set; }
        public class CreateProjectRequestSource : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>api</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
