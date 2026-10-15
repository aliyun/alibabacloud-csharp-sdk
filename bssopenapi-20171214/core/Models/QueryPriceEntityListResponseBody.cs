// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QueryPriceEntityListResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryPriceEntityListResponseBodyData Data { get; set; }
        public class QueryPriceEntityListResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of pricing entities.</para>
            /// </summary>
            [NameInMap("PriceEntityInfoList")]
            [Validation(Required=false)]
            public List<QueryPriceEntityListResponseBodyDataPriceEntityInfoList> PriceEntityInfoList { get; set; }
            public class QueryPriceEntityListResponseBodyDataPriceEntityInfoList : TeaModel {
                /// <summary>
                /// <para>The code of the pricing entity.</para>
                /// 
                /// <b>Example:</b>
                /// <para>instance_type</para>
                /// </summary>
                [NameInMap("PriceEntityCode")]
                [Validation(Required=false)]
                public string PriceEntityCode { get; set; }

                /// <summary>
                /// <para>The name of the pricing entity.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ECS Instance</para>
                /// </summary>
                [NameInMap("PriceEntityName")]
                [Validation(Required=false)]
                public string PriceEntityName { get; set; }

                /// <summary>
                /// <para>The list of pricing factors for the pricing entity.</para>
                /// </summary>
                [NameInMap("PriceFactorList")]
                [Validation(Required=false)]
                public List<QueryPriceEntityListResponseBodyDataPriceEntityInfoListPriceFactorList> PriceFactorList { get; set; }
                public class QueryPriceEntityListResponseBodyDataPriceEntityInfoListPriceFactorList : TeaModel {
                    /// <summary>
                    /// <para>The code of the pricing factor.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>vm_region_no</para>
                    /// </summary>
                    [NameInMap("PriceFactorCode")]
                    [Validation(Required=false)]
                    public string PriceFactorCode { get; set; }

                    /// <summary>
                    /// <para>The name of the pricing factor.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Region</para>
                    /// </summary>
                    [NameInMap("PriceFactorName")]
                    [Validation(Required=false)]
                    public string PriceFactorName { get; set; }

                    /// <summary>
                    /// <para>The list of pricing factor values.</para>
                    /// </summary>
                    [NameInMap("PriceFactorValueList")]
                    [Validation(Required=false)]
                    public List<string> PriceFactorValueList { get; set; }

                }

            }

        }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Successful！</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>79EE7556-0CFD-44EB-9CD6-B3B526E3A85F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
