// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220302.Models
{
    public class UrlAsyncModerationResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public UrlAsyncModerationResponseBodyData Data { get; set; }
        public class UrlAsyncModerationResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the moderated object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>26769ada6e264e7ba9aa048241e12be9</para>
            /// </summary>
            [NameInMap("DataId")]
            [Validation(Required=false)]
            public string DataId { get; set; }

            /// <summary>
            /// <para>The reqId field returned by the Url Async Moderation API.</para>
            /// 
            /// <b>Example:</b>
            /// <para>A07B3DB9-D762-5C56-95B1-8EC55CF176D2</para>
            /// </summary>
            [NameInMap("ReqId")]
            [Validation(Required=false)]
            public string ReqId { get; set; }

        }

        /// <summary>
        /// <para>The message that is returned in response to the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>6CF2815C-<b><b>-</b></b>-B52E-FF6E2****492</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
