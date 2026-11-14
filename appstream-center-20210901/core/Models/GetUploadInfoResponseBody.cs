// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class GetUploadInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code of the API. A value of 200 indicates success. If the call fails, the corresponding error code is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The file upload address and temporary credentials.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetUploadInfoResponseBodyData Data { get; set; }
        public class GetUploadInfoResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The AccessKey ID of the STS temporary access credential.</para>
            /// 
            /// <b>Example:</b>
            /// <para>STS.NUexample****</para>
            /// </summary>
            [NameInMap("AccessKeyId")]
            [Validation(Required=false)]
            public string AccessKeyId { get; set; }

            /// <summary>
            /// <para>The AccessKey secret of the STS temporary access credential. This parameter is used together with AccessKeyId and StsToken.</para>
            /// 
            /// <b>Example:</b>
            /// <para>secret-example****</para>
            /// </summary>
            [NameInMap("AccessKeySecret")]
            [Validation(Required=false)]
            public string AccessKeySecret { get; set; }

            /// <summary>
            /// <para>The name of the destination OSS bucket for the upload.</para>
            /// 
            /// <b>Example:</b>
            /// <para>appstream-example</para>
            /// </summary>
            [NameInMap("BucketName")]
            [Validation(Required=false)]
            public string BucketName { get; set; }

            /// <summary>
            /// <para>Not supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("Expiration")]
            [Validation(Required=false)]
            public string Expiration { get; set; }

            /// <summary>
            /// <para>The OSS directory prefix where files are allowed to be uploaded. The path of the uploaded object must be located in this directory.</para>
            /// </summary>
            [NameInMap("FilePath")]
            [Validation(Required=false)]
            public string FilePath { get; set; }

            /// <summary>
            /// <para>The OSS endpoint for public network access.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss-cn-shanghai.aliyuncs.com</para>
            /// </summary>
            [NameInMap("OssPoint")]
            [Validation(Required=false)]
            public string OssPoint { get; set; }

            /// <summary>
            /// <para>The internal OSS endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss-cn-shanghai-internal.aliyuncs.com</para>
            /// </summary>
            [NameInMap("OssPointInternal")]
            [Validation(Required=false)]
            public string OssPointInternal { get; set; }

            /// <summary>
            /// <para>The STS temporary security token. This parameter is used together with AccessKeyId and AccessKeySecret for file upload.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CAISexample****</para>
            /// </summary>
            [NameInMap("StsToken")]
            [Validation(Required=false)]
            public string StsToken { get; set; }

        }

        /// <summary>
        /// <para>The processing message returned by the API.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID, which is used to locate and troubleshoot the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8737D130-BFD0-5D51-96F6-C08EB1139A25</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the API call is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Successful.</description></item>
        /// <item><description>false: Failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
