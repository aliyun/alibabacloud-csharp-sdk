// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class SubmitRectifyFlowForReviewRequest : TeaModel {
        /// <summary>
        /// <para>The tenant ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

        /// <summary>
        /// <para>The operator user ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

        /// <summary>
        /// <para>The business request parameters.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("SubmitCommand")]
        [Validation(Required=false)]
        public SubmitRectifyFlowForReviewRequestSubmitCommand SubmitCommand { get; set; }
        public class SubmitRectifyFlowForReviewRequestSubmitCommand : TeaModel {
            /// <summary>
            /// <para>The description of the rectification result. This parameter is required and can be up to 128 characters in length.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <para>The ID of the rectification process. Submission is allowed only when the process is in the rectifying or re-rectifying state.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>358710058950</para>
            /// </summary>
            [NameInMap("RectifyId")]
            [Validation(Required=false)]
            public long? RectifyId { get; set; }

        }

    }

}
