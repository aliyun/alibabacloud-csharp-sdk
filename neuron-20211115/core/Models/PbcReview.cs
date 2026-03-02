// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Neuron20211115.Models
{
    public class PbcReview : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("developerId")]
        [Validation(Required=false)]
        public long? DeveloperId { get; set; }

        [NameInMap("developerName")]
        [Validation(Required=false)]
        public string DeveloperName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>符合规范</para>
        /// </summary>
        [NameInMap("feedbackPbcApi")]
        [Validation(Required=false)]
        public string FeedbackPbcApi { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>符合规范</para>
        /// </summary>
        [NameInMap("feedbackPbcInstruction")]
        [Validation(Required=false)]
        public string FeedbackPbcInstruction { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>符合pbc规格规范</para>
        /// </summary>
        [NameInMap("feedbackPbcSchema")]
        [Validation(Required=false)]
        public string FeedbackPbcSchema { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>服务安全</para>
        /// </summary>
        [NameInMap("feedbackSecurity")]
        [Validation(Required=false)]
        public string FeedbackSecurity { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>服务可用</para>
        /// </summary>
        [NameInMap("feedbackServiceAvailable")]
        [Validation(Required=false)]
        public string FeedbackServiceAvailable { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("marketId")]
        [Validation(Required=false)]
        public long? MarketId { get; set; }

        [NameInMap("marketName")]
        [Validation(Required=false)]
        public string MarketName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>基础商品</para>
        /// </summary>
        [NameInMap("pbcName")]
        [Validation(Required=false)]
        public string PbcName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://catalog.e2.aliyun.com/pbc/product">https://catalog.e2.aliyun.com/pbc/product</a></para>
        /// </summary>
        [NameInMap("pbcUrl")]
        [Validation(Required=false)]
        public string PbcUrl { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-04-01T00:00:00.000Z</para>
        /// </summary>
        [NameInMap("pbcVersion")]
        [Validation(Required=false)]
        public string PbcVersion { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("remainTime")]
        [Validation(Required=false)]
        public string RemainTime { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("reviewerId")]
        [Validation(Required=false)]
        public long? ReviewerId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>REVIEWING</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
