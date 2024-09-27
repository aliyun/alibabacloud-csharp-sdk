// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BPStudio20210931.Models
{
    public class GetResult4QueryInstancePrice4ModifyResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;PolicyType&quot;: &quot;&quot;,
        ///     &quot;AuthPrincipalOwnerId&quot;: &quot;&quot;,
        ///     &quot;EncodedDiagnosticMessage&quot;: &quot;&quot;,
        ///     &quot;AuthPrincipalType&quot;: &quot;&quot;,
        ///     &quot;AuthPrincipalDisplayName&quot;: &quot;&quot;,
        ///     &quot;NoPermissionType&quot;: &quot;&quot;,
        ///     &quot;AuthAction&quot;: &quot;&quot;
        ///   }</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetResult4QueryInstancePrice4ModifyResponseBodyData Data { get; set; }
        public class GetResult4QueryInstancePrice4ModifyResponseBodyData : TeaModel {
            [NameInMap("PriceList")]
            [Validation(Required=false)]
            public List<GetResult4QueryInstancePrice4ModifyResponseBodyDataPriceList> PriceList { get; set; }
            public class GetResult4QueryInstancePrice4ModifyResponseBodyDataPriceList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("DiscountAmount")]
                [Validation(Required=false)]
                public double? DiscountAmount { get; set; }

                [NameInMap("Error")]
                [Validation(Required=false)]
                public string Error { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>vpc</para>
                /// </summary>
                [NameInMap("NodeType")]
                [Validation(Required=false)]
                public string NodeType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("OriginalAmount")]
                [Validation(Required=false)]
                public double? OriginalAmount { get; set; }

                [NameInMap("PriceUnit")]
                [Validation(Required=false)]
                public string PriceUnit { get; set; }

                [NameInMap("PromotionName")]
                [Validation(Required=false)]
                public string PromotionName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("TradeAmount")]
                [Validation(Required=false)]
                public double? TradeAmount { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>SUCCESS</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>d9a3e99b-6954-4a16-ad51-954db4a528b7</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>A07FFDF2-78FA-1B48-9E38-88E833A93187</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
