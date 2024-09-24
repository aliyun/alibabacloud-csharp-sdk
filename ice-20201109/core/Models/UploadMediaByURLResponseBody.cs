// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class UploadMediaByURLResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para><b><b>83B7-7F87-4792-BFE9-63CD2137</b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("UploadJobs")]
        [Validation(Required=false)]
        public List<UploadMediaByURLResponseBodyUploadJobs> UploadJobs { get; set; }
        public class UploadMediaByURLResponseBodyUploadJobs : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>20ce1e05dba64576b96e9683879f0***</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>f476988629f54a7b8a4ba90d1a6c7***</para>
            /// </summary>
            [NameInMap("MediaId")]
            [Validation(Required=false)]
            public string MediaId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://example****.mp4">http://example****.mp4</a></para>
            /// </summary>
            [NameInMap("SourceURL")]
            [Validation(Required=false)]
            public string SourceURL { get; set; }

        }

    }

}
