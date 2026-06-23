// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DianJin20240628.Models
{
    public class RecognizeIntentionResponseBody : TeaModel {
        /// <summary>
        /// <para>Processing time in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("cost")]
        [Validation(Required=false)]
        public long? Cost { get; set; }

        /// <summary>
        /// <para>Response data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public RecognizeIntentionResponseBodyData Data { get; set; }
        public class RecognizeIntentionResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Analysis process.</para>
            /// 
            /// <b>Example:</b>
            /// <para>客户回答的内容与提供的意图列表描述均不匹配，没有表达出对账单、还款、天气或其他服务的具体需求或问题。</para>
            /// </summary>
            [NameInMap("analysisProcess")]
            [Validation(Required=false)]
            public string AnalysisProcess { get; set; }

            /// <summary>
            /// <para>Intent code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>-1</para>
            /// </summary>
            [NameInMap("intentionCode")]
            [Validation(Required=false)]
            public string IntentionCode { get; set; }

            /// <summary>
            /// <para>Intent name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>其它</para>
            /// </summary>
            [NameInMap("intentionName")]
            [Validation(Required=false)]
            public string IntentionName { get; set; }

            /// <summary>
            /// <para>Intent script.</para>
            /// 
            /// <b>Example:</b>
            /// <para>朱先生，理解您可能对天气感兴趣，但更重要的是您的账户情况。请让我们专注于您未偿还的款项，这对您的信用健康至关重要。</para>
            /// </summary>
            [NameInMap("intentionScript")]
            [Validation(Required=false)]
            public string IntentionScript { get; set; }

            /// <summary>
            /// <para>Recommended intent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>客户试图回避谈论逾期还款的话题</para>
            /// </summary>
            [NameInMap("recommendIntention")]
            [Validation(Required=false)]
            public string RecommendIntention { get; set; }

            /// <summary>
            /// <para>Recommended script.</para>
            /// 
            /// <b>Example:</b>
            /// <para>朱先生，理解您可能对天气感兴趣，但更重要的是您的账户情况。请让我们专注于您未偿还的款项，这对您的信用健康至关重要。</para>
            /// </summary>
            [NameInMap("recommendScript")]
            [Validation(Required=false)]
            public string RecommendScript { get; set; }

        }

        /// <summary>
        /// <para>Data type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("dataType")]
        [Validation(Required=false)]
        public string DataType { get; set; }

        /// <summary>
        /// <para>Error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("errCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>Error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ok</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>003D019A-1BB3-53EC-A0D2-CE76DA5D73B1</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request succeeded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>Timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-04-24 11:54:34</para>
        /// </summary>
        [NameInMap("time")]
        [Validation(Required=false)]
        public string Time { get; set; }

    }

}
