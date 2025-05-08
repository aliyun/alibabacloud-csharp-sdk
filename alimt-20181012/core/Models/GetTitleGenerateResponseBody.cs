// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alimt20181012.Models
{
    public class GetTitleGenerateResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetTitleGenerateResponseBodyData Data { get; set; }
        public class GetTitleGenerateResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>10pcs 80ml Kitchen Disposable Plastic Sauce Cup Pot Chutney Container</para>
            /// </summary>
            [NameInMap("Titles")]
            [Validation(Required=false)]
            public string Titles { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ok</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>DC2DCCC9-C3DF-4F59-8D8E-78185729F16D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
