// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class DownloadRecordingResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Download parameters for the recording file.</para>
        /// </summary>
        [NameInMap("DownloadParams")]
        [Validation(Required=false)]
        public DownloadRecordingResponseBodyDownloadParams DownloadParams { get; set; }
        public class DownloadRecordingResponseBodyDownloadParams : TeaModel {
            /// <summary>
            /// <para>The name of the recording file, typically a universally unique identifier (UUID).</para>
            /// 
            /// <b>Example:</b>
            /// <para>281eb174-3865-41c1-9274-7b6813edadab.wav</para>
            /// </summary>
            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// <para>The signed URL for downloading the recording file.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://tiangong-staging.oss-cn-shanghai.aliyuncs.com/record/281eb174-3865-41c1-9274-7b6813edadab.wav?Expires=1578624046&OSSAccessKeyId=LTAI****cqw&Signature=dL2dxWS6VcdZrvG9xOMOBMSP3Fg%3D">http://tiangong-staging.oss-cn-shanghai.aliyuncs.com/record/281eb174-3865-41c1-9274-7b6813edadab.wav?Expires=1578624046&amp;OSSAccessKeyId=LTAI****cqw&amp;Signature=dL2dxWS6VcdZrvG9xOMOBMSP3Fg%3D</a></para>
            /// </summary>
            [NameInMap("SignatureUrl")]
            [Validation(Required=false)]
            public string SignatureUrl { get; set; }

            /// <summary>
            /// <para>A JSON-formatted string that contains a list of voice slice recordings. Each item in the list includes the file name and URL of a slice.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;fileName&quot;:&quot;10a17c447415424c99491884abe27d8a-1.wav&quot;,&quot;filePath&quot;:&quot;<a href="https://ssml-test.oss-cn-shanghai.aliyuncs.com/7253/voiceSlice/10a17c447415424c99491884abe27d8a/10a17c447415424c99491884abe27d8a-1.wav?Expires=1686645470&OSSAccessKeyId=LTA*********kr8M9&Signature=V23OhiV5yIOoouriu6SiWkO9h8E%3D%22%7D%5D">https://ssml-test.oss-cn-shanghai.aliyuncs.com/7253/voiceSlice/10a17c447415424c99491884abe27d8a/10a17c447415424c99491884abe27d8a-1.wav?Expires=1686645470&amp;OSSAccessKeyId=LTA*********kr8M9&amp;Signature=V23OhiV5yIOoouriu6SiWkO9h8E%3D&quot;}]</a></para>
            /// </summary>
            [NameInMap("VoiceSliceRecordingListJson")]
            [Validation(Required=false)]
            public string VoiceSliceRecordingListJson { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>254EB995-DEDF-48A4-9101-9CA5B72FFBCC</para>
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
