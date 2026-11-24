// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class CreateBackendReportResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of failed combinations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("FailedCount")]
        [Validation(Required=false)]
        public int? FailedCount { get; set; }

        /// <summary>
        /// <para>The processing results of each combination of user and report object. If some combinations fail, the operation still returns the results of all combinations.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<CreateBackendReportResponseBodyItems> Items { get; set; }
        public class CreateBackendReportResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The ID of the approval instance generated after the combination is successfully created. This parameter is not returned if the creation fails.</para>
            /// 
            /// <b>Example:</b>
            /// <para>approval-6b5188a28634****</para>
            /// </summary>
            [NameInMap("ApprovalId")]
            [Validation(Required=false)]
            public string ApprovalId { get; set; }

            /// <summary>
            /// <para>The error code returned when the current combination fails to be created. This parameter is not returned if the creation is successful.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TargetNotFound</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>The effective status of the report. If the creation is successful, Enabled is returned, which indicates that the report is valid.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Enabled</para>
            /// </summary>
            [NameInMap("EffectStatus")]
            [Validation(Required=false)]
            public string EffectStatus { get; set; }

            /// <summary>
            /// <para>The error message returned when the current combination fails to be created. This parameter is not returned if the creation is successful.</para>
            /// 
            /// <b>Example:</b>
            /// <para>target user is not found</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The report object corresponding to the current combination. The fields vary based on the policy type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;ApplicationId&quot;:&quot;pa-application-92b60359213a****&quot;}]</para>
            /// </summary>
            [NameInMap("ReportObject")]
            [Validation(Required=false)]
            public object ReportObject { get; set; }

            /// <summary>
            /// <para>The report type. If the creation is successful, BackendReport is returned, which indicates a backend report.</para>
            /// 
            /// <b>Example:</b>
            /// <para>BackendReport</para>
            /// </summary>
            [NameInMap("ReportType")]
            [Validation(Required=false)]
            public string ReportType { get; set; }

            /// <summary>
            /// <para>The approval status. If the creation is successful, Approved is returned, which indicates that the request is approved.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Approved</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>Indicates whether the current combination is successfully created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

            /// <summary>
            /// <para>The target user corresponding to the current combination.</para>
            /// </summary>
            [NameInMap("Target")]
            [Validation(Required=false)]
            public CreateBackendReportResponseBodyItemsTarget Target { get; set; }
            public class CreateBackendReportResponseBodyItemsTarget : TeaModel {
                /// <summary>
                /// <para>The SASE user ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>su_1b91e674235a25e4117faf5c36a8ad4e69a14303247fb7d9f2046ce8b372****</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

        }

        /// <summary>
        /// <para>The number of deduplicated report objects.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ObjectCount")]
        [Validation(Required=false)]
        public int? ObjectCount { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>D6707286-A50E-57B1-B2CF-EFAC59E8****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of successfully created combinations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SuccessCount")]
        [Validation(Required=false)]
        public int? SuccessCount { get; set; }

        /// <summary>
        /// <para>The number of deduplicated target users.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TargetCount")]
        [Validation(Required=false)]
        public int? TargetCount { get; set; }

        /// <summary>
        /// <para>The total number of combinations of users and report objects after expansion.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
