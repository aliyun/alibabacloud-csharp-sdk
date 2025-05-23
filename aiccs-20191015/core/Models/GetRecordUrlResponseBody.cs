// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class GetRecordUrlResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetRecordUrlResponseBodyData Data { get; set; }
        public class GetRecordUrlResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1001067****</para>
            /// </summary>
            [NameInMap("Acid")]
            [Validation(Required=false)]
            public string Acid { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://aliccrec-shvpc.oss-cn-shanghai.aliyuncs.com/accrec_tmp/10010679716-12-01-56.wav">http://aliccrec-shvpc.oss-cn-shanghai.aliyuncs.com/accrec_tmp/10010679716-12-01-56.wav</a>?***</para>
            /// </summary>
            [NameInMap("OssLink")]
            [Validation(Required=false)]
            public string OssLink { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>EE338D98-9BD3-4413-B165</para>
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
