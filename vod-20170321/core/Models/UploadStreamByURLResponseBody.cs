// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class UploadStreamByURLResponseBody : TeaModel {
        /// <summary>
        /// <para>The OSS file URL of the transcoded stream.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://outin-31059bcee7810a200163e1c8dba****.oss-cn-shanghai.aliyuncs.com/lesson-01.mp4">http://outin-31059bcee7810a200163e1c8dba****.oss-cn-shanghai.aliyuncs.com/lesson-01.mp4</a></para>
        /// </summary>
        [NameInMap("FileURL")]
        [Validation(Required=false)]
        public string FileURL { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7AE96389-DF1E-598D-816B-7B40F13B4620</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The input URL of the transcoded stream. This value can be used as a request parameter of the <a href="https://help.aliyun.com/document_detail/106830.html">GetURLUploadInfos</a> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/lesson-01.mp4">https://example.com/lesson-01.mp4</a></para>
        /// </summary>
        [NameInMap("SourceURL")]
        [Validation(Required=false)]
        public string SourceURL { get; set; }

        /// <summary>
        /// <para>The job ID of the transcoded stream. This value can be used as a request parameter of the <a href="https://help.aliyun.com/document_detail/106830.html">GetURLUploadInfos</a> operation.</para>
        /// <para>ApsaraVideo VOD uses the job ID to uniquely identify a transcoded stream file. For more information, see <a href="https://help.aliyun.com/document_detail/52839.html">Basic data types - PlayInfo</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e304b34fb3d959f92baef97b6496****</para>
        /// </summary>
        [NameInMap("StreamJobId")]
        [Validation(Required=false)]
        public string StreamJobId { get; set; }

    }

}
