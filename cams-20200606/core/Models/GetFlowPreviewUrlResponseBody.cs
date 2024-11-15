// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class GetFlowPreviewUrlResponseBody : TeaModel {
        /// <summary>
        /// <para>If OK is returned, the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetFlowPreviewUrlResponseBodyData Data { get; set; }
        public class GetFlowPreviewUrlResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The Flow ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6dd31e1b7cc940fc99e293d9952b5b79</para>
            /// </summary>
            [NameInMap("FlowId")]
            [Validation(Required=false)]
            public string FlowId { get; set; }

            /// <summary>
            /// <para>The temporary preview URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://url">https://url</a></para>
            /// </summary>
            [NameInMap("PreviewUrl")]
            [Validation(Required=false)]
            public string PreviewUrl { get; set; }

            /// <summary>
            /// <para>The time when the preview URL expires. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1700617436633</para>
            /// </summary>
            [NameInMap("PreviewUrlExpires")]
            [Validation(Required=false)]
            public long? PreviewUrlExpires { get; set; }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>90E63D28-E31D-1EB2-8939-A94866411B2O</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
