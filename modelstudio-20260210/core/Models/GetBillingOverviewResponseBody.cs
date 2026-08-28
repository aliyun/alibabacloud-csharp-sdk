// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ModelStudio20260210.Models
{
    public class GetBillingOverviewResponseBody : TeaModel {
        /// <summary>
        /// <para>The request result code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The bill overview data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetBillingOverviewResponseBodyData Data { get; set; }
        public class GetBillingOverviewResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The currency of the amount.</para>
            /// 
            /// <b>Example:</b>
            /// <para>USD</para>
            /// </summary>
            [NameInMap("currency")]
            [Validation(Required=false)]
            public string Currency { get; set; }

            /// <summary>
            /// <para>The top N groups sorted by amount in descending order.</para>
            /// </summary>
            [NameInMap("groups")]
            [Validation(Required=false)]
            public List<GetBillingOverviewResponseBodyDataGroups> Groups { get; set; }
            public class GetBillingOverviewResponseBodyDataGroups : TeaModel {
                /// <summary>
                /// <para>The amount of the current group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3000</para>
                /// </summary>
                [NameInMap("amount")]
                [Validation(Required=false)]
                public string Amount { get; set; }

                /// <summary>
                /// <para>The list of commodity codes associated with the current group.</para>
                /// </summary>
                [NameInMap("articleCodes")]
                [Validation(Required=false)]
                public List<string> ArticleCodes { get; set; }

                /// <summary>
                /// <para>The grouping dimension value. A null value is returned as DIMENSION_FILTER_NULL_VALUE.</para>
                /// 
                /// <b>Example:</b>
                /// <para>inference</para>
                /// </summary>
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The display name of the group, which is affected by the locale parameter. A null value is displayed as -.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Model invocation</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The ratio of the group amount to the total amount of the top N groups.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.10</para>
                /// </summary>
                [NameInMap("percentage")]
                [Validation(Required=false)]
                public string Percentage { get; set; }

            }

            /// <summary>
            /// <para>The total pretax amount.</para>
            /// 
            /// <b>Example:</b>
            /// <para>28729.32</para>
            /// </summary>
            [NameInMap("pretaxAmount")]
            [Validation(Required=false)]
            public string PretaxAmount { get; set; }

            /// <summary>
            /// <para>The total tax amount.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2499.28</para>
            /// </summary>
            [NameInMap("taxAmount")]
            [Validation(Required=false)]
            public string TaxAmount { get; set; }

            /// <summary>
            /// <para>The total amount.</para>
            /// 
            /// <b>Example:</b>
            /// <para>31228.60</para>
            /// </summary>
            [NameInMap("totalAmount")]
            [Validation(Required=false)]
            public string TotalAmount { get; set; }

        }

        /// <summary>
        /// <para>The request result message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>BB521414-5D38-5E66-AA66-963B2B4200E2</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
