// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetDbExportDownloadURLResponseBody : TeaModel {
        [NameInMap("DownloadURLResult")]
        [Validation(Required=false)]
        public GetDbExportDownloadURLResponseBodyDownloadURLResult DownloadURLResult { get; set; }
        public class GetDbExportDownloadURLResponseBodyDownloadURLResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("HasResult")]
            [Validation(Required=false)]
            public bool? HasResult { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>tip message</para>
            /// </summary>
            [NameInMap("TipMessage")]
            [Validation(Required=false)]
            public string TipMessage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://dms-idb-hangzhou.oss-cn-hangzhou.aliyuncs.com/xxx.zip">https://dms-idb-hangzhou.oss-cn-hangzhou.aliyuncs.com/xxx.zip</a></para>
            /// </summary>
            [NameInMap("URL")]
            [Validation(Required=false)]
            public string URL { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0C1CB646-1DE4-4AD0-B4A4-7D47DD52E931</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
