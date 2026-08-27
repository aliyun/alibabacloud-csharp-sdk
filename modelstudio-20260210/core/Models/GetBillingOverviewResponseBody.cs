// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ModelStudio20260210.Models
{
    public class GetBillingOverviewResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public GetBillingOverviewResponseBodyData Data { get; set; }
        public class GetBillingOverviewResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>USD</para>
            /// </summary>
            [NameInMap("currency")]
            [Validation(Required=false)]
            public string Currency { get; set; }

            [NameInMap("groups")]
            [Validation(Required=false)]
            public List<GetBillingOverviewResponseBodyDataGroups> Groups { get; set; }
            public class GetBillingOverviewResponseBodyDataGroups : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>3000</para>
                /// </summary>
                [NameInMap("amount")]
                [Validation(Required=false)]
                public string Amount { get; set; }

                [NameInMap("articleCodes")]
                [Validation(Required=false)]
                public List<string> ArticleCodes { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>inference</para>
                /// </summary>
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>模型调用</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.10</para>
                /// </summary>
                [NameInMap("percentage")]
                [Validation(Required=false)]
                public string Percentage { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>28729.32</para>
            /// </summary>
            [NameInMap("pretaxAmount")]
            [Validation(Required=false)]
            public string PretaxAmount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2499.28</para>
            /// </summary>
            [NameInMap("taxAmount")]
            [Validation(Required=false)]
            public string TaxAmount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>31228.60</para>
            /// </summary>
            [NameInMap("totalAmount")]
            [Validation(Required=false)]
            public string TotalAmount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>BB521414-5D38-5E66-AA66-963B2B4200E2</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
