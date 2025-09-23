// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Videoseg20200320.Models
{
    public class GetAsyncJobResultResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetAsyncJobResultResponseBodyData Data { get; set; }
        public class GetAsyncJobResultResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>InvalidParameter</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>paramsIllegal</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>49E2CC28-ED1D-4CC5-854D-7D0AE2B20976</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{\&quot;VideoUrl\&quot;:\&quot;<a href="http://algo-app-aic-vd-cn-shanghai-prod.oss-cn-shanghai.aliyuncs.com/film-summary/49E2CC28-ED1D-4CC5-854D-7D0AE2B20976_rf8mv0.mp4?Expires=1585111875&OSSAccessKeyId=LTAI4FoLmvQ9urWXgSRp****&Signature=7uE0ppt6uwkdwAFz73PPZN4KG7****%5C%5C%22%7D">http://algo-app-aic-vd-cn-shanghai-prod.oss-cn-shanghai.aliyuncs.com/film-summary/49E2CC28-ED1D-4CC5-854D-7D0AE2B20976_rf8mv0.mp4?Expires=1585111875&amp;OSSAccessKeyId=LTAI4FoLmvQ9urWXgSRp****&amp;Signature=7uE0ppt6uwkdwAFz73PPZN4KG7****\\&quot;}</a></para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public string Result { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>PROCESS_SUCCESS</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6BD843FB-E7B9-45B6-ADE1-9AB1FF450148</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
