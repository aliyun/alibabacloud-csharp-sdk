// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class GetDataAgentSubAccountInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data structure.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetDataAgentSubAccountInfoResponseBodyData Data { get; set; }
        public class GetDataAgentSubAccountInfoResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The time when the user was created in RAM. This is a UNIX timestamp in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1765960516</para>
            /// </summary>
            [NameInMap("CreateDate")]
            [Validation(Required=false)]
            public long? CreateDate { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account to which the user belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>167*****166</para>
            /// </summary>
            [NameInMap("MainAccountId")]
            [Validation(Required=false)]
            public string MainAccountId { get; set; }

            /// <summary>
            /// <para>The time when the user information was last updated. This is a UNIX timestamp in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1765962516</para>
            /// </summary>
            [NameInMap("UpdateDate")]
            [Validation(Required=false)]
            public long? UpdateDate { get; set; }

            /// <summary>
            /// <para>The UID of the queried RAM user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20282*****7591</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <para>The name of the queried RAM user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>yunqitest</para>
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DMS-DA-40114</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message returned if the call fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Specified parameter is not valid.</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>67E910F2-***-695C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
