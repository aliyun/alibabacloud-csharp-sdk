// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20251111.Models
{
    public class ListCorpNumbersResponseBody : TeaModel {
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
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListCorpNumbersResponseBodyData Data { get; set; }
        public class ListCorpNumbersResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of tenant numbers.</para>
            /// </summary>
            [NameInMap("CorpNumbers")]
            [Validation(Required=false)]
            public List<ListCorpNumbersResponseBodyDataCorpNumbers> CorpNumbers { get; set; }
            public class ListCorpNumbersResponseBodyDataCorpNumbers : TeaModel {
                /// <summary>
                /// <para>The list of instance names associated with the number.</para>
                /// </summary>
                [NameInMap("InstanceNames")]
                [Validation(Required=false)]
                public List<string> InstanceNames { get; set; }

                /// <summary>
                /// <para>The phone number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>057100001234</para>
                /// </summary>
                [NameInMap("Number")]
                [Validation(Required=false)]
                public string Number { get; set; }

                /// <summary>
                /// <para>The SIP trunk ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>159d4b8361804ebda21242216a8981c2</para>
                /// </summary>
                [NameInMap("SipTrunkId")]
                [Validation(Required=false)]
                public string SipTrunkId { get; set; }

                /// <summary>
                /// <para>The SIP trunk name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>trunk_1</para>
                /// </summary>
                [NameInMap("SipTrunkName")]
                [Validation(Required=false)]
                public string SipTrunkName { get; set; }

            }

            /// <summary>
            /// <para>The current page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
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
            /// <para>10</para>
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
        /// <para>The message returned by the API.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The list of variable values in the error message.</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public List<string> Params { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0956D5DA-0978-5DC9-94B0-C68527DA7475</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
