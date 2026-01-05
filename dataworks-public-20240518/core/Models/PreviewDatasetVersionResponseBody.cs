// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class PreviewDatasetVersionResponseBody : TeaModel {
        /// <summary>
        /// <para>Preview results</para>
        /// </summary>
        [NameInMap("PreviewResult")]
        [Validation(Required=false)]
        public PreviewDatasetVersionResponseBodyPreviewResult PreviewResult { get; set; }
        public class PreviewDatasetVersionResponseBodyPreviewResult : TeaModel {
            /// <summary>
            /// <para>Content</para>
            /// 
            /// <b>Example:</b>
            /// <para>this is content</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>File name</para>
            /// 
            /// <b>Example:</b>
            /// <para>parth/data.csv</para>
            /// </summary>
            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// <para>The MIME type</para>
            /// 
            /// <b>Example:</b>
            /// <para>text/plain</para>
            /// </summary>
            [NameInMap("MimeType")]
            [Validation(Required=false)]
            public string MimeType { get; set; }

            /// <summary>
            /// <para>Preview availability</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SupportPreview")]
            [Validation(Required=false)]
            public bool? SupportPreview { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>A6C6B486-E3A2-5D52-9E76-D9380485DXXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
