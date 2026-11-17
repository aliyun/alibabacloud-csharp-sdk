// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ListModelGroupsResponseBody : TeaModel {
        /// <summary>
        /// <para>The response status code. The value is Ok for a successful request, or a specific business error code for a failed request.</para>
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
        public ListModelGroupsResponseBodyData Data { get; set; }
        public class ListModelGroupsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of model groups returned on the current page.</para>
            /// </summary>
            [NameInMap("items")]
            [Validation(Required=false)]
            public List<ListModelGroupsResponseBodyDataItems> Items { get; set; }
            public class ListModelGroupsResponseBodyDataItems : TeaModel {
                /// <summary>
                /// <para>The summary of the most recent group configuration deployment returned by GetModelGroup. This is independent of the API release and entitlement status. If no task exists, this field is omitted and does not indicate success. The deployment represents the current version only when the revision matches the current version. This field is not guaranteed to be populated in list operations.</para>
                /// </summary>
                [NameInMap("configurationDeployment")]
                [Validation(Required=false)]
                public ListModelGroupsResponseBodyDataItemsConfigurationDeployment ConfigurationDeployment { get; set; }
                public class ListModelGroupsResponseBodyDataItemsConfigurationDeployment : TeaModel {
                    /// <summary>
                    /// <para>The identity of the group configuration task, which is used for tracking only. This task cannot be accessed by GetLogicalModelDeployment or RetryLogicalModelDeployment.</para>
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
                    /// <para>The status of the deployment. Valid values: Pending, Running, Succeeded, Failed, and PartiallyFailed.</para>
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
                /// <para>The control plane delivery status and revision number of the model access entitlement.</para>
                /// </summary>
                [NameInMap("entitlementState")]
                [Validation(Required=false)]
                public ListModelGroupsResponseBodyDataItemsEntitlementState EntitlementState { get; set; }
                public class ListModelGroupsResponseBodyDataItemsEntitlementState : TeaModel {
                    /// <summary>
                    /// <para>The applied entitlement revision number.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("appliedRevision")]
                    [Validation(Required=false)]
                    public long? AppliedRevision { get; set; }

                    /// <summary>
                    /// <para>The desired entitlement revision number to be delivered.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("desiredRevision")]
                    [Validation(Required=false)]
                    public long? DesiredRevision { get; set; }

                    /// <summary>
                    /// <para>The error message when processing fails. This field is empty if no errors occur.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Configuration delivery failed</para>
                    /// </summary>
                    [NameInMap("errorMessage")]
                    [Validation(Required=false)]
                    public string ErrorMessage { get; set; }

                    /// <summary>
                    /// <para>The status of the entitlement. Valid values: Pending, Applying, Committed, and Failed. Committed indicates that the control plane has submitted and read back the configuration, but does not guarantee acknowledgment from all pods.</para>
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
                /// <para>The model group ID. Use the modelGroupId returned by CreateModelGroup.</para>
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
                /// <para>The update time in RFC3339 format.</para>
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
            /// <para>The maximum number of records returned per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("maxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            /// <summary>
            /// <para>The pagination token returned from the previous page. Do not specify this parameter when you query the first page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eyJvZmZzZXQiOjIwfQ==</para>
            /// </summary>
            [NameInMap("nextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// <para>The total number of records that match the current query conditions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("totalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

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
        /// <para>The request ID, which is generated by the system and used to trace the call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
