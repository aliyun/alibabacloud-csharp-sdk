// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class UpdateModelGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The response status code. Ok is returned for success, and a specific business error code is returned for failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ok</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The business result returned by the model group operation.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public UpdateModelGroupResponseBodyData Data { get; set; }
        public class UpdateModelGroupResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The summary of the most recent group configuration delivery returned by GetModelGroup. This is independent of API publishing and entitlement status. It is omitted when no task exists and does not indicate success. The configuration applies to the current version only when the revision matches the current version. List operations do not guarantee this field is populated.</para>
            /// </summary>
            [NameInMap("configurationDeployment")]
            [Validation(Required=false)]
            public UpdateModelGroupResponseBodyDataConfigurationDeployment ConfigurationDeployment { get; set; }
            public class UpdateModelGroupResponseBodyDataConfigurationDeployment : TeaModel {
                /// <summary>
                /// <para>The identity of the group configuration task, which is used for tracking only. It cannot be accessed by GetLogicalModelDeployment or RetryLogicalModelDeployment.</para>
                /// 
                /// <b>Example:</b>
                /// <para>op-d00000000000000000000</para>
                /// </summary>
                [NameInMap("operationId")]
                [Validation(Required=false)]
                public string OperationId { get; set; }

                /// <summary>
                /// <para>The group version corresponding to this task, which may be earlier than the current group version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("revision")]
                [Validation(Required=false)]
                public long? Revision { get; set; }

                /// <summary>
                /// <para>The status. Valid values: Pending, Running, Succeeded, Failed, or PartiallyFailed.</para>
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
            /// <para>Model group for business integration</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The control plane delivery status and revision number for model access entitlements.</para>
            /// </summary>
            [NameInMap("entitlementState")]
            [Validation(Required=false)]
            public UpdateModelGroupResponseBodyDataEntitlementState EntitlementState { get; set; }
            public class UpdateModelGroupResponseBodyDataEntitlementState : TeaModel {
                /// <summary>
                /// <para>The applied authorization revision number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("appliedRevision")]
                [Validation(Required=false)]
                public long? AppliedRevision { get; set; }

                /// <summary>
                /// <para>The expected authorization revision number to be delivered.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("desiredRevision")]
                [Validation(Required=false)]
                public long? DesiredRevision { get; set; }

                /// <summary>
                /// <para>The error description when processing fails. This field is empty when no errors occur.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Configuration delivery failed</para>
                /// </summary>
                [NameInMap("errorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                /// <summary>
                /// <para>The status. Valid values: Pending, Applying, Committed, or Failed. Committed only indicates that the control plane has submitted and read back the configuration, and does not guarantee ACK from all pods.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Committed</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>The ID of the AI gateway instance to which the resource belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>gw-d00000000000000000000</para>
            /// </summary>
            [NameInMap("gatewayId")]
            [Validation(Required=false)]
            public string GatewayId { get; set; }

            /// <summary>
            /// <para>The collection of model card identifiers.</para>
            /// </summary>
            [NameInMap("modelCardIds")]
            [Validation(Required=false)]
            public List<string> ModelCardIds { get; set; }

            /// <summary>
            /// <para>The ID of the model group. Use the modelGroupId returned by CreateModelGroup.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mg-d00000000000000000000</para>
            /// </summary>
            [NameInMap("modelGroupId")]
            [Validation(Required=false)]
            public string ModelGroupId { get; set; }

            /// <summary>
            /// <para>The name of the model group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>beta-model-group</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The update time in RFC 3339 format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-11-12T00:00:00Z</para>
            /// </summary>
            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// <para>The current version of the object, which is used for conditional validation during updates or deletions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public long? Version { get; set; }

        }

        /// <summary>
        /// <para>The response message, which describes the request processing result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID, which is generated by the system and used to locate this call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
