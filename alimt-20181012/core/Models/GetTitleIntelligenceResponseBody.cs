// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alimt20181012.Models
{
    public class GetTitleIntelligenceResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetTitleIntelligenceResponseBodyData Data { get; set; }
        public class GetTitleIntelligenceResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>Custom Hello Kitty PVC Cartoon Apple for Home Garden Complete Apple Bath Shower</para>
            /// </summary>
            [NameInMap("Titles")]
            [Validation(Required=false)]
            public string Titles { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>D70487B4-8891-4D24-BB64-8788E53671FB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
