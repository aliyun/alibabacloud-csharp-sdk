// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CodeSec20260401.Models
{
    public class CreateProjectResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("configRevision")]
        [Validation(Required=false)]
        public long? ConfigRevision { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2026-08-27T00:53:46.774Z</para>
        /// </summary>
        [NameInMap("createdAt")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3221</para>
        /// </summary>
        [NameInMap("createdBy")]
        [Validation(Required=false)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>This is default function description by fc-deploy component</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("engines")]
        [Validation(Required=false)]
        public CreateProjectResponseBodyEngines Engines { get; set; }
        public class CreateProjectResponseBodyEngines : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("sast")]
            [Validation(Required=false)]
            public bool? Sast { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("sca")]
            [Validation(Required=false)]
            public bool? Sca { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>111</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>such as ignoring low-severity vulnerabilities, etc.</para>
        /// </summary>
        [NameInMap("instructionPrompt")]
        [Validation(Required=false)]
        public string InstructionPrompt { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>name</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>9A1F403F-0A85-5578-8B7C-55E3E9408659</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("source")]
        [Validation(Required=false)]
        public CreateProjectResponseBodySource Source { get; set; }
        public class CreateProjectResponseBodySource : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>api</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2026-08-27T00:53:46.774Z</para>
        /// </summary>
        [NameInMap("updatedAt")]
        [Validation(Required=false)]
        public string UpdatedAt { get; set; }

    }

}
