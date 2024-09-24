// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetFileUploadLimitResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned if the request is successful.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetFileUploadLimitResponseBodyData Data { get; set; }
        public class GetFileUploadLimitResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The QPS limit on the files uploaded from the client.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Limit")]
            [Validation(Required=false)]
            public string Limit { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1A975D03-5F49-5354-B2CB-3918D5DA431A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
