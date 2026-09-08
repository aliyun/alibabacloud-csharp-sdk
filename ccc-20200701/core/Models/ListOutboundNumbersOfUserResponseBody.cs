// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ListOutboundNumbersOfUserResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListOutboundNumbersOfUserResponseBodyData Data { get; set; }
        public class ListOutboundNumbersOfUserResponseBodyData : TeaModel {
            /// <summary>
            /// <para>A list of phone numbers.</para>
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListOutboundNumbersOfUserResponseBodyDataList> List { get; set; }
            public class ListOutboundNumbersOfUserResponseBodyDataList : TeaModel {
                /// <summary>
                /// <para>The city where the phone number is located.</para>
                /// 
                /// <b>Example:</b>
                /// <para>乐山</para>
                /// </summary>
                [NameInMap("City")]
                [Validation(Required=false)]
                public string City { get; set; }

                /// <summary>
                /// <para>The phone number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0830019****</para>
                /// </summary>
                [NameInMap("Number")]
                [Validation(Required=false)]
                public string Number { get; set; }

                [NameInMap("Provider")]
                [Validation(Required=false)]
                public string Provider { get; set; }

                /// <term><b>Obsolete</b></term>
                [NameInMap("ProviderCode")]
                [Validation(Required=false)]
                [Obsolete]
                public string ProviderCode { get; set; }

                /// <term><b>Obsolete</b></term>
                [NameInMap("ProviderDisplayName")]
                [Validation(Required=false)]
                [Obsolete]
                public string ProviderDisplayName { get; set; }

                [NameInMap("ProviderShortName")]
                [Validation(Required=false)]
                public string ProviderShortName { get; set; }

                [NameInMap("ProviderType")]
                [Validation(Required=false)]
                public string ProviderType { get; set; }

                /// <summary>
                /// <para>The province where the phone number is located.</para>
                /// 
                /// <b>Example:</b>
                /// <para>四川</para>
                /// </summary>
                [NameInMap("Province")]
                [Validation(Required=false)]
                public string Province { get; set; }

            }

            /// <summary>
            /// <para>The page number. Valid values: 1 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries per page. Valid values: 1 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>无</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EEEE671A-3E24-4A04-81E6-6C4F5B39DF75</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
