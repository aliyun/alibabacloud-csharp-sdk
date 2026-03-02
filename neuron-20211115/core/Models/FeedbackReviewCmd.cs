// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Neuron20211115.Models
{
    public class FeedbackReviewCmd : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>符合规范</para>
        /// </summary>
        [NameInMap("feedbackPbcAPI")]
        [Validation(Required=false)]
        public string FeedbackPbcAPI { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>符合规范</para>
        /// </summary>
        [NameInMap("feedbackPbcInstruction")]
        [Validation(Required=false)]
        public string FeedbackPbcInstruction { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>符合规范</para>
        /// </summary>
        [NameInMap("feedbackPbcSchema")]
        [Validation(Required=false)]
        public string FeedbackPbcSchema { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>服务安全</para>
        /// </summary>
        [NameInMap("feedbackSecurity")]
        [Validation(Required=false)]
        public string FeedbackSecurity { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>服务可运行</para>
        /// </summary>
        [NameInMap("feedbackServiceAvailable")]
        [Validation(Required=false)]
        public string FeedbackServiceAvailable { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("reviewId")]
        [Validation(Required=false)]
        public long? ReviewId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>REVIEW_FAILED</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
