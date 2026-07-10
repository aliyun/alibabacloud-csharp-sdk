// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20230522.Models
{
    public class CreateLangfuseOrgResponseBody : TeaModel {
        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateLangfuseOrgResponseBodyData Data { get; set; }
        public class CreateLangfuseOrgResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The time when the Langfuse organization was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-06-25T09:28:30.949Z</para>
            /// </summary>
            [NameInMap("CreatedAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            /// <summary>
            /// <para>The name of the Langfuse organization.</para>
            /// 
            /// <b>Example:</b>
            /// <para>org_name</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The Langfuse organization ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cmrbhzx930005jw****</para>
            /// </summary>
            [NameInMap("OrganizationId")]
            [Validation(Required=false)]
            public string OrganizationId { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>F5178C10-1407-4987-9133-DE4DC9119F75</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
