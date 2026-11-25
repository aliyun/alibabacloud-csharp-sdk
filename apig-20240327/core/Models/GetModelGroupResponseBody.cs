// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class GetModelGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The response status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ok</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetModelGroupResponseBodyData Data { get; set; }
        public class GetModelGroupResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The summary of the latest group configuration deployment, which is independent of API publishing and entitlement status. This field is not returned when no deployment task exists, and its presence does not indicate success. It represents the current version only when the revision matches the current version. List operations do not guarantee that this field is populated.</para>
            /// </summary>
            [NameInMap("configurationDeployment")]
            [Validation(Required=false)]
            public GetModelGroupResponseBodyDataConfigurationDeployment ConfigurationDeployment { get; set; }
            public class GetModelGroupResponseBodyDataConfigurationDeployment : TeaModel {
                /// <summary>
                /// <para>The operation ID of the group configuration task, which is used for tracking only. It cannot be used for GetLogicalModelDeployment or RetryLogicalModelDeployment.</para>
                /// 
                /// <b>Example:</b>
                /// <para>op-xxxxxxxx</para>
                /// </summary>
                [NameInMap("operationId")]
                [Validation(Required=false)]
                public string OperationId { get; set; }

                /// <summary>
                /// <para>The model group version corresponding to the task, which may be earlier than the current version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("revision")]
                [Validation(Required=false)]
                public long? Revision { get; set; }

                /// <summary>
                /// <para>The configuration deployment status. Valid values: Pending, Running, Succeeded, Failed, and PartiallyFailed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Succeeded</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>The description of the model group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>A model group for conversational scenarios</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The entitlement status information.</para>
            /// </summary>
            [NameInMap("entitlementState")]
            [Validation(Required=false)]
            public GetModelGroupResponseBodyDataEntitlementState EntitlementState { get; set; }
            public class GetModelGroupResponseBodyDataEntitlementState : TeaModel {
                /// <summary>
                /// <para>The applied entitlement revision.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("appliedRevision")]
                [Validation(Required=false)]
                public long? AppliedRevision { get; set; }

                /// <summary>
                /// <para>The desired entitlement revision.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("desiredRevision")]
                [Validation(Required=false)]
                public long? DesiredRevision { get; set; }

                /// <summary>
                /// <para>The error message when entitlement fails. This field is not returned when no error occurs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Entitlement synchronization failed</para>
                /// </summary>
                [NameInMap("errorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                /// <summary>
                /// <para>The entitlement status. Valid values: Pending, Applying, Committed, and Failed. Committed indicates only that the control plane has successfully submitted and read back the status, and does not mean that all nodes have acknowledged it.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Committed</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>The ID of the gateway instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>gw-xxxxxxxx</para>
            /// </summary>
            [NameInMap("gatewayId")]
            [Validation(Required=false)]
            public string GatewayId { get; set; }

            /// <summary>
            /// <para>The list of model card IDs included in the model group.</para>
            /// </summary>
            [NameInMap("modelCardIds")]
            [Validation(Required=false)]
            public List<string> ModelCardIds { get; set; }

            /// <summary>
            /// <para>The ID of the model group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mg-xxxxxxxx</para>
            /// </summary>
            [NameInMap("modelGroupId")]
            [Validation(Required=false)]
            public string ModelGroupId { get; set; }

            /// <summary>
            /// <para>The name of the model group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>chat-group</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The last update time in ISO 8601 (RFC 3339) format in the UTC time zone, such as 2026-05-15T10:00:00Z.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-05-15T10:00:00Z</para>
            /// </summary>
            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// <para>The version number of the model group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public long? Version { get; set; }

        }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>393E2630-DBE7-5221-AB35-9E740675491A</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
