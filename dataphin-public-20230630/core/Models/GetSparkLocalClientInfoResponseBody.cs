// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetSparkLocalClientInfoResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetSparkLocalClientInfoResponseBodyData> Data { get; set; }
        public class GetSparkLocalClientInfoResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>XXXX-XXXX-XXXX-XXXX</para>
            /// </summary>
            [NameInMap("ClientFileResourceId")]
            [Validation(Required=false)]
            public string ClientFileResourceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>spark-cleint.zip</para>
            /// </summary>
            [NameInMap("ClientFileResourceName")]
            [Validation(Required=false)]
            public string ClientFileResourceName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>spark-clinet</para>
            /// </summary>
            [NameInMap("ClientName")]
            [Validation(Required=false)]
            public string ClientName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true/false</para>
            /// </summary>
            [NameInMap("Editable")]
            [Validation(Required=false)]
            public bool? Editable { get; set; }

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
        /// <b>Example:</b>
        /// <para>75DD06F8-1661-5A6E-B0A6-7E23133BDC60</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
