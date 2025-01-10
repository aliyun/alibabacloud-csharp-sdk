// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class GetHotelScreenSaverStyleResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>73C67**6FA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<GetHotelScreenSaverStyleResponseBodyResult> Result { get; set; }
        public class GetHotelScreenSaverStyleResponseBodyResult : TeaModel {
            [NameInMap("CnName")]
            [Validation(Required=false)]
            public string CnName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>common-weather</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>common-weather</para>
            /// </summary>
            [NameInMap("EnName")]
            [Validation(Required=false)]
            public string EnName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://img.***.png">https://img.***.png</a></para>
            /// </summary>
            [NameInMap("PicUrl")]
            [Validation(Required=false)]
            public string PicUrl { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("StatusCode")]
        [Validation(Required=false)]
        public int? StatusCode { get; set; }

    }

}
