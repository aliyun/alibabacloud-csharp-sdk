// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class QueryDataTrackResultDownloadStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0C1CB646-1DE4-4AD0-B4A4-7D47DD52E931</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the download progress.</para>
        /// </summary>
        [NameInMap("StatusResult")]
        [Validation(Required=false)]
        public QueryDataTrackResultDownloadStatusResponseBodyStatusResult StatusResult { get; set; }
        public class QueryDataTrackResultDownloadStatusResponseBodyStatusResult : TeaModel {
            /// <summary>
            /// <para>The status of the download task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>INIT</b>: The download task is being initialized.</description></item>
            /// <item><description><b>LISTING</b>: The download task is in a transient intermediate state during the initialization.</description></item>
            /// <item><description><b>DOWNLOADING</b>: The download task is being processed.</description></item>
            /// <item><description><b>DOWNLOAD_SUCCESS</b>: The download task was successfully processed.</description></item>
            /// <item><description><b>DOWNLOAD_FAIL</b>: The download task failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>DOWNLOAD_SUCCESS</para>
            /// </summary>
            [NameInMap("DownloadStatus")]
            [Validation(Required=false)]
            public string DownloadStatus { get; set; }

            /// <summary>
            /// <para>The URL that is used to download data tracking logs. This parameter is returned only when the value of DownloadStatus is DOWNLOAD_SUCCESS.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://idbsaasstore.oss-cn-zhangjiakou.aliyuncs.com/****_REDO_31201_207.zip?Expires=1682239593&OSSAccessKeyId=****&Signature=">https://idbsaasstore.oss-cn-zhangjiakou.aliyuncs.com/****_REDO_31201_207.zip?Expires=1682239593&amp;OSSAccessKeyId=****&amp;Signature=</a>****</para>
            /// </summary>
            [NameInMap("DownloadUrl")]
            [Validation(Required=false)]
            public string DownloadUrl { get; set; }

            /// <summary>
            /// <para>The description of the state.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SUCCESS</para>
            /// </summary>
            [NameInMap("StatusDesc")]
            [Validation(Required=false)]
            public string StatusDesc { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>69</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The request was successful.</description></item>
        /// <item><description><b>false</b>: The request failed.</description></item>
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
