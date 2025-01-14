// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListApprovalProcessesForApprovalSchemasResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>BE4FB974-11BC-5453-9BE1-1606A73EACA6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Schemas")]
        [Validation(Required=false)]
        public List<ListApprovalProcessesForApprovalSchemasResponseBodySchemas> Schemas { get; set; }
        public class ListApprovalProcessesForApprovalSchemasResponseBodySchemas : TeaModel {
            [NameInMap("Processes")]
            [Validation(Required=false)]
            public List<ListApprovalProcessesForApprovalSchemasResponseBodySchemasProcesses> Processes { get; set; }
            public class ListApprovalProcessesForApprovalSchemasResponseBodySchemasProcesses : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2022-10-25 10:44:09</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>approval-process-dc61e92ba5c5****</para>
                /// </summary>
                [NameInMap("ProcessId")]
                [Validation(Required=false)]
                public string ProcessId { get; set; }

                [NameInMap("ProcessName")]
                [Validation(Required=false)]
                public string ProcessName { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>approval-schema-090134f1ebff****</para>
            /// </summary>
            [NameInMap("SchemaId")]
            [Validation(Required=false)]
            public string SchemaId { get; set; }

        }

    }

}
