// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ReviewRectifyFlowRequest : TeaModel {
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
        /// <para>The ID of the operator user.</para>
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
        [NameInMap("ReviewCommand")]
        [Validation(Required=false)]
        public ReviewRectifyFlowRequestReviewCommand ReviewCommand { get; set; }
        public class ReviewRectifyFlowRequestReviewCommand : TeaModel {
            /// <summary>
            /// <para>The acceptance description. This parameter is optional and can contain up to 128 characters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <para>The ID of the rectification process. This operation is allowed only when the process is pending acceptance.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>616543434760</para>
            /// </summary>
            [NameInMap("RectifyId")]
            [Validation(Required=false)]
            public long? RectifyId { get; set; }

            /// <summary>
            /// <para>The acceptance result. Valid values: PASSED and REJECTED.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PASSED</para>
            /// </summary>
            [NameInMap("ReviewResult")]
            [Validation(Required=false)]
            public string ReviewResult { get; set; }

        }

    }

}
