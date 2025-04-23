// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class GetRamPolicyExportTaskVersionResponseBody : TeaModel {
        [NameInMap("ramPolicyExportTaskVersion")]
        [Validation(Required=false)]
        public GetRamPolicyExportTaskVersionResponseBodyRamPolicyExportTaskVersion RamPolicyExportTaskVersion { get; set; }
        public class GetRamPolicyExportTaskVersionResponseBodyRamPolicyExportTaskVersion : TeaModel {
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
            /// <para>2022-07-18T06:32:06Z</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("elapsedTime")]
            [Validation(Required=false)]
            public long? ElapsedTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>v1</para>
            /// </summary>
            [NameInMap("exportVersion")]
            [Validation(Required=false)]
            public string ExportVersion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>the ram policy export task has time out, The maximum running time is 1 hour</para>
            /// </summary>
            [NameInMap("failedReason")]
            [Validation(Required=false)]
            public string FailedReason { get; set; }

            [NameInMap("missingActions")]
            [Validation(Required=false)]
            public List<string> MissingActions { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>mod-4357ffeebf6b577c4afa</para>
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

            [NameInMap("noSupportResourceTypes")]
            [Validation(Required=false)]
            public List<string> NoSupportResourceTypes { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>&quot;{
            ///     &quot;version&quot;: &quot;1&quot;,
            ///     &quot;statement&quot;: [
            ///       {
            ///         &quot;effect&quot;: &quot;Allow&quot;,
            ///         &quot;action&quot;: [
            ///           &quot;ecs:<em>&quot;
            ///         ],
            ///         &quot;resource&quot;: [
            ///           &quot;</em>&quot;
            ///         ],
            ///         &quot;condition&quot;: null,
            ///         &quot;supportVariables&quot;: []
            ///       }
            ///     ]
            ///   }&quot;</para>
            /// </summary>
            [NameInMap("policyDocument")]
            [Validation(Required=false)]
            public string PolicyDocument { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>rpe-43ffe0252e48f9286a</para>
            /// </summary>
            [NameInMap("ramPolicyExportTaskId")]
            [Validation(Required=false)]
            public string RamPolicyExportTaskId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("terraformProviderVersion")]
            [Validation(Required=false)]
            public string TerraformProviderVersion { get; set; }

            [NameInMap("unauthorizedActions")]
            [Validation(Required=false)]
            public List<string> UnauthorizedActions { get; set; }

            [NameInMap("warnMessage")]
            [Validation(Required=false)]
            public string WarnMessage { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>E2D0E863-1651-5E58-823F-B451C8C24615</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
