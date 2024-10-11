// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class UploadStreamByURLResponseBody : TeaModel {
        /// <summary>
        /// <para>The URL of the OSS object.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://outin-31059bcee7810a200163e1c8dba****.oss-cn-shanghai.aliyuncs.com/lesson-01.mp4">http://outin-31059bcee7810a200163e1c8dba****.oss-cn-shanghai.aliyuncs.com/lesson-01.mp4</a></para>
        /// </summary>
        [NameInMap("FileURL")]
        [Validation(Required=false)]
        public string FileURL { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7AE96389-DF1E-598D-816B-7B40F13B4620</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The URL of the input stream. This parameter is used when you call the <a href="https://help.aliyun.com/document_detail/106830.html">GetURLUploadInfos</a> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/lesson-01.mp4">https://example.com/lesson-01.mp4</a></para>
        /// </summary>
        [NameInMap("SourceURL")]
        [Validation(Required=false)]
        public string SourceURL { get; set; }

        /// <summary>
        /// <para>The ID of the stream upload job. This parameter is used when you call the <a href="https://help.aliyun.com/document_detail/106830.html">GetURLUploadInfos</a> operation.</para>
        /// <para>In ApsaraVideo VOD, you can upload only one transcoded stream in an upload job. For more information, see the PlayInfo: the playback information about a video stream section in <a href="https://help.aliyun.com/document_detail/52839.html">Basic structures</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e304b34fb3d959f92baef97b6496****</para>
        /// </summary>
        [NameInMap("StreamJobId")]
        [Validation(Required=false)]
        public string StreamJobId { get; set; }

    }

}
