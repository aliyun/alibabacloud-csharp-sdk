// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class GetRamPolicyExportTaskResponseBody : TeaModel {
        [NameInMap("ramPolicyExportTask")]
        [Validation(Required=false)]
        public GetRamPolicyExportTaskResponseBodyRamPolicyExportTask RamPolicyExportTask { get; set; }
        public class GetRamPolicyExportTaskResponseBodyRamPolicyExportTask : TeaModel {
            [NameInMap("authorizationAccountIds")]
            [Validation(Required=false)]
            public List<long?> AuthorizationAccountIds { get; set; }

            [NameInMap("authorizationActions")]
            [Validation(Required=false)]
            public List<string> AuthorizationActions { get; set; }

            [NameInMap("authorizationRegionIds")]
            [Validation(Required=false)]
            public List<string> AuthorizationRegionIds { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-06-16T10:03:39Z</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>mod-66c23a9cc0cacddf</para>
            /// </summary>
            [NameInMap("moduleId")]
            [Validation(Required=false)]
            public string ModuleId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>v1</para>
            /// </summary>
            [NameInMap("moduleVersion")]
            [Validation(Required=false)]
            public string ModuleVersion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>rpe-40252e48f9286a</para>
            /// </summary>
            [NameInMap("ramPolicyExportTaskId")]
            [Validation(Required=false)]
            public string RamPolicyExportTaskId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ramName</para>
            /// </summary>
            [NameInMap("ramRole")]
            [Validation(Required=false)]
            public string RamRole { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Available</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>12345678/default/rampolicytask/rpe-4399111870d7e6b0f11a</para>
            /// </summary>
            [NameInMap("taskOutputPath")]
            [Validation(Required=false)]
            public string TaskOutputPath { get; set; }

            [NameInMap("terraformProviderVersion")]
            [Validation(Required=false)]
            public string TerraformProviderVersion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Manual</para>
            /// </summary>
            [NameInMap("triggerStrategy")]
            [Validation(Required=false)]
            public string TriggerStrategy { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3E49127A-BB65-5CCD-AB93-0EC0A43E5446</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
