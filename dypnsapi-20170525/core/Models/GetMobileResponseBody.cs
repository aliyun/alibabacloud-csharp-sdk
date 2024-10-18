// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dypnsapi20170525.Models
{
    public class GetMobileResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// <list type="bullet">
        /// <item><description>If OK is returned, the request is successful.</description></item>
        /// <item><description>For more information about other error codes, see <a href="https://help.aliyun.com/document_detail/85198.html">API response codes</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response parameters.</para>
        /// </summary>
        [NameInMap("GetMobileResultDTO")]
        [Validation(Required=false)]
        public GetMobileResponseBodyGetMobileResultDTO GetMobileResultDTO { get; set; }
        public class GetMobileResponseBodyGetMobileResultDTO : TeaModel {
            /// <summary>
            /// <para>The phone number,</para>
            /// 
            /// <b>Example:</b>
            /// <para>13900001234</para>
            /// </summary>
            [NameInMap("Mobile")]
            [Validation(Required=false)]
            public string Mobile { get; set; }

        }

        /// <summary>
        /// <para>The returned message.</para>
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
        /// <para>8906582E-6722</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
