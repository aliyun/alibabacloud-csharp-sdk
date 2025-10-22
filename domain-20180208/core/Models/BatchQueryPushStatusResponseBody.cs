// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180208.Models
{
    public class BatchQueryPushStatusResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("AllowRetry")]
        [Validation(Required=false)]
        public bool? AllowRetry { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public long? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("Module")]
        [Validation(Required=false)]
        public BatchQueryPushStatusResponseBodyModule Module { get; set; }
        public class BatchQueryPushStatusResponseBodyModule : TeaModel {
            [NameInMap("PushResults")]
            [Validation(Required=false)]
            public List<BatchQueryPushStatusResponseBodyModulePushResults> PushResults { get; set; }
            public class BatchQueryPushStatusResponseBodyModulePushResults : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>20250518100817SjskYtIe</para>
                /// </summary>
                [NameInMap("OutBizId")]
                [Validation(Required=false)]
                public string OutBizId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>123213231123</para>
                /// </summary>
                [NameInMap("PushNo")]
                [Validation(Required=false)]
                public string PushNo { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>RECEIVE_SUCCESS</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>接收成功</para>
                /// </summary>
                [NameInMap("StatusDesc")]
                [Validation(Required=false)]
                public string StatusDesc { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>AAAAAdDWBF2w6Olxc+cMPjUtUMpkYDWvKnFIdUFubQkRvn9xkmy/JSvFWO/sGLK3bhha5w==</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2DEDFF32-7827-46B1-BE90-3DB8ABD91A58</para>
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
