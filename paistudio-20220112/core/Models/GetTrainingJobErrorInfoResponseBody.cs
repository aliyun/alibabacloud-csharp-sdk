// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class GetTrainingJobErrorInfoResponseBody : TeaModel {
        [NameInMap("ErrorInfo")]
        [Validation(Required=false)]
        public GetTrainingJobErrorInfoResponseBodyErrorInfo ErrorInfo { get; set; }
        public class GetTrainingJobErrorInfoResponseBodyErrorInfo : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>additional info</para>
            /// </summary>
            [NameInMap("AdditionalInfo")]
            [Validation(Required=false)]
            public string AdditionalInfo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
