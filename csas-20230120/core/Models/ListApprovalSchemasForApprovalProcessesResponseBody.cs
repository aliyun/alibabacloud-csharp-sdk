// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListApprovalSchemasForApprovalProcessesResponseBody : TeaModel {
        [NameInMap("Processes")]
        [Validation(Required=false)]
        public List<ListApprovalSchemasForApprovalProcessesResponseBodyProcesses> Processes { get; set; }
        public class ListApprovalSchemasForApprovalProcessesResponseBodyProcesses : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>approval-process-35ee09077ee9****</para>
            /// </summary>
            [NameInMap("ProcessId")]
            [Validation(Required=false)]
            public string ProcessId { get; set; }

            [NameInMap("Schemas")]
            [Validation(Required=false)]
            public List<ListApprovalSchemasForApprovalProcessesResponseBodyProcessesSchemas> Schemas { get; set; }
            public class ListApprovalSchemasForApprovalProcessesResponseBodyProcessesSchemas : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2024-03-15 14:44:07</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsDefault")]
                [Validation(Required=false)]
                public bool? IsDefault { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>DlpSend</para>
                /// </summary>
                [NameInMap("PolicyType")]
                [Validation(Required=false)]
                public string PolicyType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{&quot;form&quot;: {&quot;labelCol&quot;: 6,&quot;wrapperCol&quot;: 12}}</para>
                /// </summary>
                [NameInMap("SchemaContent")]
                [Validation(Required=false)]
                public string SchemaContent { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>approval-schema-090134f1ebff****</para>
                /// </summary>
                [NameInMap("SchemaId")]
                [Validation(Required=false)]
                public string SchemaId { get; set; }

                [NameInMap("SchemaName")]
                [Validation(Required=false)]
                public string SchemaName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1715680940</para>
                /// </summary>
                [NameInMap("SchemaVersion")]
                [Validation(Required=false)]
                public long? SchemaVersion { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>58D6B23E-E5DA-5418-8F61-51A3B5A30049</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
