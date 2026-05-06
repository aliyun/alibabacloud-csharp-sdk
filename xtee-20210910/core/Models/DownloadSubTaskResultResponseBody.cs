// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DownloadSubTaskResultResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public string HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>E01E1B4A-6747-5329-9046-B6D6B2D91349</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultObject")]
        [Validation(Required=false)]
        public DownloadSubTaskResultResponseBodyResultObject ResultObject { get; set; }
        public class DownloadSubTaskResultResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://mass.alipay.com/enhance/afts/file/n5XnQounknwAAAAAZfAAAAgAhvocAAFr?t=2hrPX0at3hhaRjlScory9JzLGiLchaonac5suH-Z1BgDAAAAZAABHPpobI2j">https://mass.alipay.com/enhance/afts/file/n5XnQounknwAAAAAZfAAAAgAhvocAAFr?t=2hrPX0at3hhaRjlScory9JzLGiLchaonac5suH-Z1BgDAAAAZAABHPpobI2j</a></para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

    }

}
