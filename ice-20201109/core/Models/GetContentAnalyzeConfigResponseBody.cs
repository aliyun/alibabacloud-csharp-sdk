// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetContentAnalyzeConfigResponseBody : TeaModel {
        [NameInMap("ContentAnalyzeConfig")]
        [Validation(Required=false)]
        public GetContentAnalyzeConfigResponseBodyContentAnalyzeConfig ContentAnalyzeConfig { get; set; }
        public class GetContentAnalyzeConfigResponseBodyContentAnalyzeConfig : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Auto")]
            [Validation(Required=false)]
            public bool? Auto { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>TEXT,FACE</para>
            /// </summary>
            [NameInMap("SaveType")]
            [Validation(Required=false)]
            public string SaveType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>S00000101-100070</para>
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>31FEC819-2344-5771-9366-9172DB0D26C9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
