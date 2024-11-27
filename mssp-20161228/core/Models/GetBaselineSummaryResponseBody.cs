// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mssp20161228.Models
{
    public class GetBaselineSummaryResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetBaselineSummaryResponseBodyData Data { get; set; }
        public class GetBaselineSummaryResponseBodyData : TeaModel {
            [NameInMap("TrendDTOList")]
            [Validation(Required=false)]
            public List<GetBaselineSummaryResponseBodyDataTrendDTOList> TrendDTOList { get; set; }
            public class GetBaselineSummaryResponseBodyDataTrendDTOList : TeaModel {
                [NameInMap("Date")]
                [Validation(Required=false)]
                public string Date { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("DealCount")]
                [Validation(Required=false)]
                public long? DealCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("FindCount")]
                [Validation(Required=false)]
                public long? FindCount { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>67D61738-5E38-5164-947A-34E3850D493A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
