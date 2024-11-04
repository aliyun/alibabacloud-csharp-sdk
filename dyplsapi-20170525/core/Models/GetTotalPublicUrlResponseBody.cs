// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class GetTotalPublicUrlResponseBody : TeaModel {
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
        /// <para>The download URLs of the recording files.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetTotalPublicUrlResponseBodyData Data { get; set; }
        public class GetTotalPublicUrlResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The download URL of the recorded call.</para>
            /// <remarks>
            /// <para> The download URL of the recorded call is valid for 30 days.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://secret-axb-reco****cn-shanghai.aliyuncs.com/1000000820257625_66647243838006067251551752068865.mp3?Expires=1551****07&OSSAccessKeyId=LTAIP00vvvv****v&Signature=tK6Yq9KusU4n%2BZQWX****4/WmEA%3D">http://secret-axb-reco****cn-shanghai.aliyuncs.com/1000000820257625_66647243838006067251551752068865.mp3?Expires=1551****07&amp;OSSAccessKeyId=LTAIP00vvvv****v&amp;Signature=tK6Yq9KusU4n%2BZQWX****4/WmEA%3D</a></para>
            /// </summary>
            [NameInMap("PhonePublicUrl")]
            [Validation(Required=false)]
            public string PhonePublicUrl { get; set; }

            /// <summary>
            /// <para>The download URL of the recorded ringing tone.</para>
            /// <remarks>
            /// <para> The download URL of the recorded ringing tone is valid for 30 days.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://secret-ab-reco****cn-shanghai.aliyuncs.com/1000000820257625_66647243838006067251551752068865.mp3?Expires=155175****&OSSAccessKeyId=LTAIP00vvv****vv&Signature=tK6Yq9KusU4n%2BZQW****g4/WmEA%3D">http://secret-ab-reco****cn-shanghai.aliyuncs.com/1000000820257625_66647243838006067251551752068865.mp3?Expires=155175****&amp;OSSAccessKeyId=LTAIP00vvv****vv&amp;Signature=tK6Yq9KusU4n%2BZQW****g4/WmEA%3D</a></para>
            /// </summary>
            [NameInMap("RingPublicUrl")]
            [Validation(Required=false)]
            public string RingPublicUrl { get; set; }

        }

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
