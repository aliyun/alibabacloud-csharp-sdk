// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetCodeReviewResponseBody : TeaModel {
        /// <summary>
        /// <para>The code review metadata.</para>
        /// </summary>
        [NameInMap("CodeReview")]
        [Validation(Required=false)]
        public GetCodeReviewResponseBodyCodeReview CodeReview { get; set; }
        public class GetCodeReviewResponseBodyCodeReview : TeaModel {
            /// <summary>
            /// <para>The node command of the root object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>WORKFLOW</para>
            /// </summary>
            [NameInMap("Command")]
            [Validation(Required=false)]
            public string Command { get; set; }

            /// <summary>
            /// <para>The creation time. The value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1793145600000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The account ID of the actual submitter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>209000000000000002</para>
            /// </summary>
            [NameInMap("Creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            /// <summary>
            /// <para>The review description provided at creation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Code review</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The account ID of the final approver. This field is empty if no approval decision has been made.</para>
            /// 
            /// <b>Example:</b>
            /// <para>209000000000000001</para>
            /// </summary>
            [NameInMap("FinalReviewer")]
            [Validation(Required=false)]
            public string FinalReviewer { get; set; }

            /// <summary>
            /// <para>The unique identifier of the review.</para>
            /// 
            /// <b>Example:</b>
            /// <para>review-id</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The update time. The value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1793145600000</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public long? ModifyTime { get; set; }

            /// <summary>
            /// <para>The ID of the root review object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8600000000000000001</para>
            /// </summary>
            [NameInMap("ObjectId")]
            [Validation(Required=false)]
            public string ObjectId { get; set; }

            /// <summary>
            /// <para>The name of the root review object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sales_workflow</para>
            /// </summary>
            [NameInMap("ObjectName")]
            [Validation(Required=false)]
            public string ObjectName { get; set; }

            /// <summary>
            /// <para>The object type of the root object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>WorkflowDefinition</para>
            /// </summary>
            [NameInMap("ObjectType")]
            [Validation(Required=false)]
            public string ObjectType { get; set; }

            /// <summary>
            /// <para>The workspace ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>23620</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The approval time. This field is empty if no approval decision has been made.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1793145660000</para>
            /// </summary>
            [NameInMap("ReviewTime")]
            [Validation(Required=false)]
            public long? ReviewTime { get; set; }

            /// <summary>
            /// <para>The account IDs of the designated reviewers.</para>
            /// </summary>
            [NameInMap("Reviewers")]
            [Validation(Required=false)]
            public List<string> Reviewers { get; set; }

            /// <summary>
            /// <para>The review status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Reviewing</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>request-id</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
