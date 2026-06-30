// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class GetRayLogResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code. A value of 1000000 indicates a successful request. Other values indicate a failed request. You can view the specific error description in the message parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000000</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetRayLogResponseBodyData Data { get; set; }
        public class GetRayLogResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The file download URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://mybucket.cn-hangzhou.com/xxxxxx">https://mybucket.cn-hangzhou.com/xxxxxx</a></para>
            /// </summary>
            [NameInMap("accessUrl")]
            [Validation(Required=false)]
            public string AccessUrl { get; set; }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ok</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>B06AADC1-1627-5B1C-B62F-A2226C122897</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
