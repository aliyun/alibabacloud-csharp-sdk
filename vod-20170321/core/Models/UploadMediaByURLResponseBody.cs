// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class UploadMediaByURLResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25818875-5F78-4AF6-D7393642CA58****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the upload job.</para>
        /// </summary>
        [NameInMap("UploadJobs")]
        [Validation(Required=false)]
        public List<UploadMediaByURLResponseBodyUploadJobs> UploadJobs { get; set; }
        public class UploadMediaByURLResponseBodyUploadJobs : TeaModel {
            /// <summary>
            /// <para>The ID of the upload job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ad90a501b1b94fb72374ad005046****</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>The URL of the source file that is uploaded in the upload job.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://example****.mp4">http://example****.mp4</a></para>
            /// </summary>
            [NameInMap("SourceURL")]
            [Validation(Required=false)]
            public string SourceURL { get; set; }

        }

    }

}
