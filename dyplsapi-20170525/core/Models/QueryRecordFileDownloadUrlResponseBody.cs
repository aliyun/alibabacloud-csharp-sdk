// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class QueryRecordFileDownloadUrlResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// <list type="bullet">
        /// <item><description>The value OK indicates that the request was successful.</description></item>
        /// <item><description>Other status codes indicate that the request failed. For more information, see <a href="https://help.aliyun.com/document_detail/109196.html">Error codes</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The download URL of the recording file. The download URL is valid for 2 hours.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://secret-axb-reco****cn-shanghai.aliyuncs.com/1000000820257625_66647243838006067251551752068865.mp3?Expires=155175****&OSSAccessKeyId=LTAIP00vvvv****v&Signature=tK6Yq9KusU4n%2BZ****7lg4/WmEA%3D">http://secret-axb-reco****cn-shanghai.aliyuncs.com/1000000820257625_66647243838006067251551752068865.mp3?Expires=155175****&amp;OSSAccessKeyId=LTAIP00vvvv****v&amp;Signature=tK6Yq9KusU4n%2BZ****7lg4/WmEA%3D</a></para>
        /// </summary>
        [NameInMap("DownloadUrl")]
        [Validation(Required=false)]
        public string DownloadUrl { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1AB3CEF7-DCBE-488C-9C33-D180982CE031</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
