// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetApprovalTaskDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The backend response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The approval task details.</para>
        /// </summary>
        [NameInMap("DetailInfo")]
        [Validation(Required=false)]
        public GetApprovalTaskDetailResponseBodyDetailInfo DetailInfo { get; set; }
        public class GetApprovalTaskDetailResponseBodyDetailInfo : TeaModel {
            /// <summary>
            /// <para>The ID of the applicant.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user001</para>
            /// </summary>
            [NameInMap("ApplicantId")]
            [Validation(Required=false)]
            public string ApplicantId { get; set; }

            /// <summary>
            /// <para>The name of the applicant.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Zhang San</para>
            /// </summary>
            [NameInMap("ApplicantName")]
            [Validation(Required=false)]
            public string ApplicantName { get; set; }

            /// <summary>
            /// <para>The approval type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>APPROVE: Permission approval.</description></item>
            /// <item><description>MANAGE: Management.</description></item>
            /// <item><description>OTHERS: Others.</description></item>
            /// <item><description>ATOMIC: Atomic metric approval.</description></item>
            /// <item><description>BIZ_OBJECT: Business object approval.</description></item>
            /// <item><description>BIZ_PROCESS: Business activity approval.</description></item>
            /// <item><description>PUBLISH_APPROVE: Publish approval.</description></item>
            /// <item><description>BASELINE_APPROVE: Baseline approval.</description></item>
            /// <item><description>CODE_REVIEW: Asset approval.</description></item>
            /// <item><description>OBJECT_CODE_REVIEW: Code review.</description></item>
            /// <item><description>STANDARD_APPROVAL: Standard online approval.</description></item>
            /// <item><description>BATCH_STANDARD_APPROVAL: Batch standard online approval.</description></item>
            /// <item><description>STANDARD_OFFLINE_APPROVAL: Standard offline approval.</description></item>
            /// <item><description>BATCH_STANDARD_OFFLINE_APPROVAL: Batch standard offline approval.</description></item>
            /// <item><description>PRIVILEGE_TRANSFER_APPROVAL: Privilege transfer approval.</description></item>
            /// <item><description>QD_FEATURE_ONLINE: Tag listing.</description></item>
            /// <item><description>QD_FEATURE_OFFLINE: Tag delisting.</description></item>
            /// <item><description>QD_CLUSTER_ONLINE: Group online.</description></item>
            /// <item><description>QD_CLUSTER_OFFLINE: Group offline.</description></item>
            /// <item><description>QD_MEMBER_ADD_APP: Member added to application.</description></item>
            /// <item><description>QD_FEATURE_ADD_APP: Tag added to application.</description></item>
            /// <item><description>QD_CLUSTER_ADD_APP: Group added to application.</description></item>
            /// <item><description>QD_FEATURE_ADD_PROJECT: Tag added to project.</description></item>
            /// <item><description>QD_CLUSTER_ADD_PROJECT: Group added to project.</description></item>
            /// <item><description>TASK_DATA_DOWNLOAD: Data download.</description></item>
            /// <item><description>CUSTOM_OPERATE: Custom operation.</description></item>
            /// <item><description>PRIVACY_COMPUTING: Privacy-preserving computation.</description></item>
            /// <item><description>MDC_TOPIC_DIR_PUBLISH: Asset topic directory publishing.</description></item>
            /// <item><description>ASSET_PUBLISH: Asset listing approval.</description></item>
            /// <item><description>ASSET_UN_PUBLISH: Asset delisting approval.</description></item>
            /// <item><description>APPLICATION_CREATE: Application creation approval.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>DATA_SOURCE</para>
            /// </summary>
            [NameInMap("ApprovalType")]
            [Validation(Required=false)]
            public string ApprovalType { get; set; }

            /// <summary>
            /// <para>The list of approval process steps.</para>
            /// </summary>
            [NameInMap("ApproveProcessSteps")]
            [Validation(Required=false)]
            public List<GetApprovalTaskDetailResponseBodyDetailInfoApproveProcessSteps> ApproveProcessSteps { get; set; }
            public class GetApprovalTaskDetailResponseBodyDetailInfoApproveProcessSteps : TeaModel {
                /// <summary>
                /// <para>The list of candidate approver IDs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>user001,user002</para>
                /// </summary>
                [NameInMap("ApproveUserIds")]
                [Validation(Required=false)]
                public string ApproveUserIds { get; set; }

                /// <summary>
                /// <para>The list of candidate approver names.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Zhang San, Li Si</para>
                /// </summary>
                [NameInMap("ApproveUserNames")]
                [Validation(Required=false)]
                public string ApproveUserNames { get; set; }

                /// <summary>
                /// <para>The operation time. Format: yyyy-MM-dd HH:mm:ss.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-07-30 11:00:00</para>
                /// </summary>
                [NameInMap("OperateTime")]
                [Validation(Required=false)]
                public string OperateTime { get; set; }

                /// <summary>
                /// <para>The ID of the operator.</para>
                /// 
                /// <b>Example:</b>
                /// <para>user001</para>
                /// </summary>
                [NameInMap("OperateUserId")]
                [Validation(Required=false)]
                public string OperateUserId { get; set; }

                /// <summary>
                /// <para>The name of the operator.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Zhang San</para>
                /// </summary>
                [NameInMap("OperateUserName")]
                [Validation(Required=false)]
                public string OperateUserName { get; set; }

                /// <summary>
                /// <para>The operation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SUBMIT</para>
                /// </summary>
                [NameInMap("Operation")]
                [Validation(Required=false)]
                public string Operation { get; set; }

                /// <summary>
                /// <para>The step name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Submit application</para>
                /// </summary>
                [NameInMap("ProcessStepName")]
                [Validation(Required=false)]
                public string ProcessStepName { get; set; }

                /// <summary>
                /// <para>The approval comment.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Approved</para>
                /// </summary>
                [NameInMap("Reason")]
                [Validation(Required=false)]
                public string Reason { get; set; }

                /// <summary>
                /// <para>The approval result.</para>
                /// 
                /// <b>Example:</b>
                /// <para>APPROVED</para>
                /// </summary>
                [NameInMap("Result")]
                [Validation(Required=false)]
                public string Result { get; set; }

            }

            /// <summary>
            /// <para>The JSON string of the task details.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("BizContent")]
            [Validation(Required=false)]
            public string BizContent { get; set; }

            /// <summary>
            /// <para>The completion time. Format: yyyy-MM-dd HH:mm:ss. This field is empty if the task is not completed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-07-30 12:00:00</para>
            /// </summary>
            [NameInMap("FinishedAt")]
            [Validation(Required=false)]
            public string FinishedAt { get; set; }

            /// <summary>
            /// <para>The approval flow ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The source system.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Dataphin</para>
            /// </summary>
            [NameInMap("SourceSystem")]
            [Validation(Required=false)]
            public string SourceSystem { get; set; }

            /// <summary>
            /// <para>The approval status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>APPROVING: Approving.</description></item>
            /// <item><description>APPROVED: Approved.</description></item>
            /// <item><description>REJECTED: Rejected.</description></item>
            /// <item><description>REVOKED: Revoked.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>APPROVED</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The submission time. Format: yyyy-MM-dd HH:mm:ss.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-07-30 10:00:00</para>
            /// </summary>
            [NameInMap("SubmittedAt")]
            [Validation(Required=false)]
            public string SubmittedAt { get; set; }

            /// <summary>
            /// <para>The task name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Data source application</para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The backend response exception details.</para>
        /// 
        /// <b>Example:</b>
        /// <para>internal error</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>82E78D6B-AA8F-1FEF-8AA3-5C9DA2A79140</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
