// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180208.Models
{
    public class CheckSelectedDomainStatusResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OssFileNotFound</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Module")]
        [Validation(Required=false)]
        public CheckSelectedDomainStatusResponseBodyModule Module { get; set; }
        public class CheckSelectedDomainStatusResponseBodyModule : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1567353497</para>
            /// </summary>
            [NameInMap("DeadDate")]
            [Validation(Required=false)]
            public long? DeadDate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>example.com</para>
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1567353497</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            [NameInMap("Premium")]
            [Validation(Required=false)]
            public bool? Premium { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20.00</para>
            /// </summary>
            [NameInMap("Price")]
            [Validation(Required=false)]
            public double? Price { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1566353497</para>
            /// </summary>
            [NameInMap("RegDate")]
            [Validation(Required=false)]
            public long? RegDate { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>E2598CAF-DBFE-494E-95EF-B42A33C178AA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
