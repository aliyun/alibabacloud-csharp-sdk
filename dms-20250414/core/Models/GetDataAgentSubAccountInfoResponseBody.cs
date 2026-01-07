// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class GetDataAgentSubAccountInfoResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetDataAgentSubAccountInfoResponseBodyData Data { get; set; }
        public class GetDataAgentSubAccountInfoResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1765960516</para>
            /// </summary>
            [NameInMap("CreateDate")]
            [Validation(Required=false)]
            public long? CreateDate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>167*****166</para>
            /// </summary>
            [NameInMap("MainAccountId")]
            [Validation(Required=false)]
            public string MainAccountId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1765962516</para>
            /// </summary>
            [NameInMap("UpdateDate")]
            [Validation(Required=false)]
            public long? UpdateDate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20282*****7591</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>yunqitest</para>
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>DMS-DA-40114</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Specified parameter is not valid.</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>67E910F2-***-695C</para>
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
