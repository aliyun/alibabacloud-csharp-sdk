// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class GetIdentityProviderSyncScopeResponseBody : TeaModel {
        /// <summary>
        /// <para>The business status code of the API request. SUCCESS indicates that the request is successful, but does not indicate that the asynchronous synchronization task is completed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The business data returned by the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;syncScope&quot;:{&quot;mode&quot;:&quot;SelectedDepartments&quot;,&quot;departmentIds&quot;:[&quot;10001&quot;]},&quot;selectedDepartments&quot;:[{&quot;id&quot;:&quot;10001&quot;,&quot;name&quot;:&quot;R&amp;D Department&quot;,&quot;exists&quot;:true}],&quot;estimateStatus&quot;:&quot;Ready&quot;,&quot;expandedDepartmentCount&quot;:2,&quot;estimatedUserCount&quot;:12}</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetIdentityProviderSyncScopeResponseBodyData Data { get; set; }
        public class GetIdentityProviderSyncScopeResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The estimation status of the user count for the synchronization scope. The count is available only when the status is Ready. A missing count in other states cannot be considered as 0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Ready</para>
            /// </summary>
            [NameInMap("estimateStatus")]
            [Validation(Required=false)]
            public string EstimateStatus { get; set; }

            /// <summary>
            /// <para>The estimated number of users in the saved synchronization scope. This parameter is returned only when estimateStatus is Ready and the downstream system provides the value. It does not represent the number of users that have been synchronized.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("estimatedUserCount")]
            [Validation(Required=false)]
            public long? EstimatedUserCount { get; set; }

            /// <summary>
            /// <para>The estimated number of departments including sub-departments. This parameter is returned only when estimateStatus is Ready and the downstream system provides the value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("expandedDepartmentCount")]
            [Validation(Required=false)]
            public long? ExpandedDepartmentCount { get; set; }

            /// <summary>
            /// <para>The names and validity of the saved selected departments. This parameter can be an empty array when the mode is AllAuthorized. An empty array does not indicate that the organization has no departments.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;id&quot;:&quot;10001&quot;,&quot;name&quot;:&quot;R&amp;D Department&quot;,&quot;exists&quot;:true}]</para>
            /// </summary>
            [NameInMap("selectedDepartments")]
            [Validation(Required=false)]
            public List<GetIdentityProviderSyncScopeResponseBodyDataSelectedDepartments> SelectedDepartments { get; set; }
            public class GetIdentityProviderSyncScopeResponseBodyDataSelectedDepartments : TeaModel {
                /// <summary>
                /// <para>Indicates whether the selected department still exists. A value of false indicates that the selection is invalid and the synchronization scope must be reconfirmed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("exists")]
                [Validation(Required=false)]
                public bool? Exists { get; set; }

                /// <summary>
                /// <para>The unique identifier of the department returned by the identity provider. When querying the sub-departments of this node, use this value as parentDepartmentId.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10001</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The name of the department returned by the identity provider.</para>
                /// 
                /// <b>Example:</b>
                /// <para>R&amp;D Department</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>The saved synchronization scope downstream. AllAuthorized indicates the address book scope authorized for the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;mode&quot;:&quot;SelectedDepartments&quot;,&quot;departmentIds&quot;:[&quot;10001&quot;]}</para>
            /// </summary>
            [NameInMap("syncScope")]
            [Validation(Required=false)]
            public GetIdentityProviderSyncScopeResponseBodyDataSyncScope SyncScope { get; set; }
            public class GetIdentityProviderSyncScopeResponseBodyDataSyncScope : TeaModel {
                /// <summary>
                /// <para>When the mode is SelectedDepartments, this parameter contains at least one non-empty department ID, which should be obtained from ListIdentityProviderDepartments. When the mode is AllAuthorized, pass an empty array or omit this parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[&quot;10001&quot;]</para>
                /// </summary>
                [NameInMap("departmentIds")]
                [Validation(Required=false)]
                public List<string> DepartmentIds { get; set; }

                /// <summary>
                /// <para>The scope mode. Valid values: AllAuthorized (the entire authorized scope, limited by the application\&quot;s address book authorization) and SelectedDepartments (the selected departments and all their sub-departments). When explicitly submitting syncScope, a valid mode must be provided and verified by the backend.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SelectedDepartments</para>
                /// </summary>
                [NameInMap("mode")]
                [Validation(Required=false)]
                public string Mode { get; set; }

            }

        }

        /// <summary>
        /// <para>The HTTP status code of the API request. It does not indicate the execution result of the asynchronous task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The response message of the API request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The unique identifier of the request. Provide this value when troubleshooting issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>01234567-89AB-CDEF-0123-456789ABCDEF</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the API request is successful. To check whether the asynchronous task is completed, query the task status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
