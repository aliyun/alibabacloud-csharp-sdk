// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20230522.Models
{
    public class CreateLangfuseProjectResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateLangfuseProjectResponseBodyData Data { get; set; }
        public class CreateLangfuseProjectResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The time when the Langfuse project was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-06-24T10:14:33Z</para>
            /// </summary>
            [NameInMap("CreatedAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            /// <summary>
            /// <para>The Langfuse project name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>project_name</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The Langfuse organization ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cmrbhzx930005jw2q****</para>
            /// </summary>
            [NameInMap("OrganizationId")]
            [Validation(Required=false)]
            public string OrganizationId { get; set; }

            /// <summary>
            /// <para>The Langfuse project ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cmrbhzx930005jw2q****</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>2C7393F1-5FD1-5CEE-A2EA-270A2CF99693</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
