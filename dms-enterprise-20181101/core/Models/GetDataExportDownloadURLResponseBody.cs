// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetDataExportDownloadURLResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the download URL of the file that records the export results for the ticket.</para>
        /// </summary>
        [NameInMap("DownloadURLResult")]
        [Validation(Required=false)]
        public GetDataExportDownloadURLResponseBodyDownloadURLResult DownloadURLResult { get; set; }
        public class GetDataExportDownloadURLResponseBodyDownloadURLResult : TeaModel {
            /// <summary>
            /// <para>Indicates whether export results are available for download. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("HasResult")]
            [Validation(Required=false)]
            public bool? HasResult { get; set; }

            /// <summary>
            /// <para>The message that indicates an exception.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tip message</para>
            /// </summary>
            [NameInMap("TipMessage")]
            [Validation(Required=false)]
            public string TipMessage { get; set; }

            /// <summary>
            /// <para>The download URL of the file that records the export results for the ticket.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://dms-idb-hangzhou.oss-cn-hangzhou.aliyuncs.com/xxx.zip">https://dms-idb-hangzhou.oss-cn-hangzhou.aliyuncs.com/xxx.zip</a></para>
            /// </summary>
            [NameInMap("URL")]
            [Validation(Required=false)]
            public string URL { get; set; }

        }

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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4BF24EA5-9013-4C85-AE68-6C23AF5E0097</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
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
