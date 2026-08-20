// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Market20151101.Models
{
    public class CrossAccountVerifyTokenResponseBody : TeaModel {
        /// <summary>
        /// <para>Status code. A value of 200 indicates success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C19D103F-EA2D-50A5-8441-0267CE9FBA56</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Response result object.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public CrossAccountVerifyTokenResponseBodyResult Result { get; set; }
        public class CrossAccountVerifyTokenResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>Authorized roles.</para>
            /// </summary>
            [NameInMap("AuthRoles")]
            [Validation(Required=false)]
            public List<string> AuthRoles { get; set; }

            /// <summary>
            /// <para>Authorization time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1676974108866</para>
            /// </summary>
            [NameInMap("AuthTime")]
            [Validation(Required=false)]
            public long? AuthTime { get; set; }

            /// <summary>
            /// <para>User display name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>marketplace_wangxiao_test</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>User Alibaba Cloud UID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1744526877246715</para>
            /// </summary>
            [NameInMap("Uid")]
            [Validation(Required=false)]
            public string Uid { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the API call was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
