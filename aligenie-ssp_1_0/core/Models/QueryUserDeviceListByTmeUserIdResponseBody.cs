// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class QueryUserDeviceListByTmeUserIdResponseBody : TeaModel {
        /// <summary>
        /// <para>Response code</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>Response message</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>860194F7-9593-50EA-8E53-BCEC0D325A00</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Response Result</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public QueryUserDeviceListByTmeUserIdResponseBodyResult Result { get; set; }
        public class QueryUserDeviceListByTmeUserIdResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>Tmall Genie User List</para>
            /// </summary>
            [NameInMap("AligenieUserInfoList")]
            [Validation(Required=false)]
            public List<QueryUserDeviceListByTmeUserIdResponseBodyResultAligenieUserInfoList> AligenieUserInfoList { get; set; }
            public class QueryUserDeviceListByTmeUserIdResponseBodyResultAligenieUserInfoList : TeaModel {
                /// <summary>
                /// <para>User Authorization device List</para>
                /// </summary>
                [NameInMap("AuthorizedDeviceList")]
                [Validation(Required=false)]
                public List<QueryUserDeviceListByTmeUserIdResponseBodyResultAligenieUserInfoListAuthorizedDeviceList> AuthorizedDeviceList { get; set; }
                public class QueryUserDeviceListByTmeUserIdResponseBodyResultAligenieUserInfoListAuthorizedDeviceList : TeaModel {
                    /// <summary>
                    /// <para>device name</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CC</para>
                    /// </summary>
                    [NameInMap("DeviceName")]
                    [Validation(Required=false)]
                    public string DeviceName { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the device is online</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("Online")]
                    [Validation(Required=false)]
                    public bool? Online { get; set; }

                    /// <summary>
                    /// <para>Device ID</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>fjwZiYQdtkaI95fHaLNjYcaOA/mxUPzxxw2J5iBiTBnjUCWKwER4TSHCqkBnNOYvGJ4bRZA9KzBB2naS4r/Am0lSe8ECDAAOcJ9QKLFF6DM=</para>
                    /// </summary>
                    [NameInMap("OpenDeviceId")]
                    [Validation(Required=false)]
                    public string OpenDeviceId { get; set; }

                    /// <summary>
                    /// <para>Device ID exposed to TME</para>
                    /// </summary>
                    [NameInMap("TmeDeviceId")]
                    [Validation(Required=false)]
                    public string TmeDeviceId { get; set; }

                    /// <summary>
                    /// <para>TME product ID</para>
                    /// </summary>
                    [NameInMap("TmeProductId")]
                    [Validation(Required=false)]
                    public string TmeProductId { get; set; }

                }

                /// <summary>
                /// <para>User ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>R457Av3qg/OXTwVnFt12z6MwNe0HAS699V6n63OaLdu+VmwvhcNfMzBd+la553wWJhj3kBMjgHq2Y2dyCFoDBg==</para>
                /// </summary>
                [NameInMap("OpenUserId")]
                [Validation(Required=false)]
                public string OpenUserId { get; set; }

                /// <summary>
                /// <para>User nickname</para>
                /// 
                /// <b>Example:</b>
                /// <para>a***e</para>
                /// </summary>
                [NameInMap("UserNickname")]
                [Validation(Required=false)]
                public string UserNickname { get; set; }

            }

            /// <summary>
            /// <para>entity key (pass-through by third party)</para>
            /// 
            /// <b>Example:</b>
            /// <para>12****7</para>
            /// </summary>
            [NameInMap("EncodeKey")]
            [Validation(Required=false)]
            public string EncodeKey { get; set; }

            /// <summary>
            /// <para>entity Type (pass-through by third party)</para>
            /// 
            /// <b>Example:</b>
            /// <para>PROJECT_ID</para>
            /// </summary>
            [NameInMap("EncodeType")]
            [Validation(Required=false)]
            public string EncodeType { get; set; }

            /// <summary>
            /// <para>&quot;KG&quot;: KuGou<br>&quot;KW&quot;: Kuwo<br>&quot;QM&quot;: QQ Music</para>
            /// 
            /// <b>Example:</b>
            /// <para>KG</para>
            /// </summary>
            [NameInMap("Sp")]
            [Validation(Required=false)]
            public string Sp { get; set; }

        }

        /// <summary>
        /// <para>Flag indicating whether the invocation succeeded</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
