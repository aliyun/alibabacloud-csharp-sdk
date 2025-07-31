// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetDataServiceApiCallTrendResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetDataServiceApiCallTrendResponseBodyData Data { get; set; }
        public class GetDataServiceApiCallTrendResponseBodyData : TeaModel {
            [NameInMap("CallErrorImpactTrendList")]
            [Validation(Required=false)]
            public List<GetDataServiceApiCallTrendResponseBodyDataCallErrorImpactTrendList> CallErrorImpactTrendList { get; set; }
            public class GetDataServiceApiCallTrendResponseBodyDataCallErrorImpactTrendList : TeaModel {
                [NameInMap("ApiIdList")]
                [Validation(Required=false)]
                public List<long?> ApiIdList { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("ErrorApiCount")]
                [Validation(Required=false)]
                public int? ErrorApiCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ErrorAppCount")]
                [Validation(Required=false)]
                public int? ErrorAppCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2025-06-30 08:00</para>
                /// </summary>
                [NameInMap("Minute")]
                [Validation(Required=false)]
                public string Minute { get; set; }

            }

            [NameInMap("CallErrorTrendList")]
            [Validation(Required=false)]
            public List<GetDataServiceApiCallTrendResponseBodyDataCallErrorTrendList> CallErrorTrendList { get; set; }
            public class GetDataServiceApiCallTrendResponseBodyDataCallErrorTrendList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1021</para>
                /// </summary>
                [NameInMap("CallCount")]
                [Validation(Required=false)]
                public long? CallCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>102</para>
                /// </summary>
                [NameInMap("ErrorCount")]
                [Validation(Required=false)]
                public long? ErrorCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("Minute")]
                [Validation(Required=false)]
                public string Minute { get; set; }

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
        /// <para>internal error</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>82E78D6B-AA8F-1FEF-8AA3-5C9DA2A79140</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
