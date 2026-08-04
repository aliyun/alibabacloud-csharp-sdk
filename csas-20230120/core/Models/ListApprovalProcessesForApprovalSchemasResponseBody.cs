// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListApprovalProcessesForApprovalSchemasResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BE4FB974-11BC-5453-9BE1-1606A73EACA6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>A list of approval templates.</para>
        /// </summary>
        [NameInMap("Schemas")]
        [Validation(Required=false)]
        public List<ListApprovalProcessesForApprovalSchemasResponseBodySchemas> Schemas { get; set; }
        public class ListApprovalProcessesForApprovalSchemasResponseBodySchemas : TeaModel {
            /// <summary>
            /// <para>A collection of approval flows.</para>
            /// </summary>
            [NameInMap("Processes")]
            [Validation(Required=false)]
            public List<ListApprovalProcessesForApprovalSchemasResponseBodySchemasProcesses> Processes { get; set; }
            public class ListApprovalProcessesForApprovalSchemasResponseBodySchemasProcesses : TeaModel {
                /// <summary>
                /// <para>The time when the approval flow was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-10-25 10:44:09</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The description of the approval flow.</para>
                /// 
                /// <b>Example:</b>
                /// <para>这是一个审批流程</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The ID of the approval flow.</para>
                /// 
                /// <b>Example:</b>
                /// <para>approval-process-dc61e92ba5c5****</para>
                /// </summary>
                [NameInMap("ProcessId")]
                [Validation(Required=false)]
                public string ProcessId { get; set; }

                /// <summary>
                /// <para>The name of the approval flow.</para>
                /// 
                /// <b>Example:</b>
                /// <para>测试</para>
                /// </summary>
                [NameInMap("ProcessName")]
                [Validation(Required=false)]
                public string ProcessName { get; set; }

            }

            /// <summary>
            /// <para>The ID of the approval template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>approval-schema-090134f1ebff****</para>
            /// </summary>
            [NameInMap("SchemaId")]
            [Validation(Required=false)]
            public string SchemaId { get; set; }

        }

    }

}
