// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryApprovalInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D787E1A3-A93C-424A-B626-C2B05DF8D885</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The result of the API operation.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public QueryApprovalInfoResponseBodyResult Result { get; set; }
        public class QueryApprovalInfoResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The array of approval flow information.</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<QueryApprovalInfoResponseBodyResultData> Data { get; set; }
            public class QueryApprovalInfoResponseBodyResultData : TeaModel {
                /// <summary>
                /// <para>The QBI user ID of the applicant.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1359508</para>
                /// </summary>
                [NameInMap("ApplicantId")]
                [Validation(Required=false)]
                public string ApplicantId { get; set; }

                /// <summary>
                /// <para>The nickname of the applicant.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Li Fei</para>
                /// </summary>
                [NameInMap("ApplicantName")]
                [Validation(Required=false)]
                public string ApplicantName { get; set; }

                /// <summary>
                /// <para>The ID of the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>64813ef6da58e80eef8ed2f9</para>
                /// </summary>
                [NameInMap("ApplicationId")]
                [Validation(Required=false)]
                public string ApplicationId { get; set; }

                /// <summary>
                /// <para>The reason for the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Required for development</para>
                /// </summary>
                [NameInMap("ApplyReason")]
                [Validation(Required=false)]
                public string ApplyReason { get; set; }

                /// <summary>
                /// <para>The QBI user ID of the approver.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sdasascasxasd</para>
                /// </summary>
                [NameInMap("ApproverId")]
                [Validation(Required=false)]
                public string ApproverId { get; set; }

                /// <summary>
                /// <para>The nickname of the approver.</para>
                /// 
                /// <b>Example:</b>
                /// <para>data_fusion_002</para>
                /// </summary>
                [NameInMap("ApproverName")]
                [Validation(Required=false)]
                public string ApproverName { get; set; }

                /// <summary>
                /// <para>Indicates whether the resource has been deleted. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: The resource has been deleted.</description></item>
                /// <item><description>false: The resource has not been deleted.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("DeleteFlag")]
                [Validation(Required=false)]
                public bool? DeleteFlag { get; set; }

                /// <summary>
                /// <para>The expiration time of the permission.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1708568097135</para>
                /// </summary>
                [NameInMap("ExpireDate")]
                [Validation(Required=false)]
                public long? ExpireDate { get; set; }

                /// <summary>
                /// <para>The approval status of the permission. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: Pending approval, which corresponds to 0 in the request parameters.</description></item>
                /// <item><description>1: Approved, which corresponds to 1 in the request parameters.</description></item>
                /// <item><description>2: Rejected, which corresponds to 1 in the request parameters.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("FlagStatus")]
                [Validation(Required=false)]
                public int? FlagStatus { get; set; }

                /// <summary>
                /// <para>The time when the application was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1687315758</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public long? GmtCreate { get; set; }

                /// <summary>
                /// <para>The time when the application was modified.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1640595729000</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public long? GmtModified { get; set; }

                /// <summary>
                /// <para>The reason for handling the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Required for development</para>
                /// </summary>
                [NameInMap("HandleReason")]
                [Validation(Required=false)]
                public string HandleReason { get; set; }

                /// <summary>
                /// <para>The ID of the resource for which permissions are requested.</para>
                /// 
                /// <b>Example:</b>
                /// <para>acl-ct4t2e4u2x4ej1bzur</para>
                /// </summary>
                [NameInMap("ResourceId")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

                /// <summary>
                /// <para>The name of the resource for which permissions are requested, such as the report name or workspace name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Test resource</para>
                /// </summary>
                [NameInMap("ResourceName")]
                [Validation(Required=false)]
                public string ResourceName { get; set; }

                /// <summary>
                /// <para>The type of the resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DASHBOARD</para>
                /// </summary>
                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

                /// <summary>
                /// <para>The name of the workspace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Test workspace</para>
                /// </summary>
                [NameInMap("WorkspaceName")]
                [Validation(Required=false)]
                public string WorkspaceName { get; set; }

            }

            /// <summary>
            /// <para>The current page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Page")]
            [Validation(Required=false)]
            public int? Page { get; set; }

            /// <summary>
            /// <para>The number of records on the current page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The start position of the current page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Start")]
            [Validation(Required=false)]
            public int? Start { get; set; }

            /// <summary>
            /// <para>The total number of records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

            /// <summary>
            /// <para>The total number of pages.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalPages")]
            [Validation(Required=false)]
            public int? TotalPages { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the API operation is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The operation is successful.</description></item>
        /// <item><description>false: The operation fails.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
