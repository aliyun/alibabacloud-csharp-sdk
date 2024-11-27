// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mssp20161228.Models
{
    public class GetAttackedAssetDealResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetAttackedAssetDealResponseBodyData Data { get; set; }
        public class GetAttackedAssetDealResponseBodyData : TeaModel {
            [NameInMap("EcsTrendList")]
            [Validation(Required=false)]
            public List<GetAttackedAssetDealResponseBodyDataEcsTrendList> EcsTrendList { get; set; }
            public class GetAttackedAssetDealResponseBodyDataEcsTrendList : TeaModel {
                [NameInMap("Date")]
                [Validation(Required=false)]
                public string Date { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("DealCount")]
                [Validation(Required=false)]
                public long? DealCount { get; set; }

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
        /// <para>1E74F11C-B4A8-5774-962C-02003BA8504E</para>
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
