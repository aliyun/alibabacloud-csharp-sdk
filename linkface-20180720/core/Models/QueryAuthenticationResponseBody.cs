// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.LinkFace20180720.Models
{
    public class QueryAuthenticationResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<QueryAuthenticationResponseBodyData> Data { get; set; }
        public class QueryAuthenticationResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2b407f02dee5c2ddb94804f95e2ba51fed42926d54650678e3b5992d8fb93612</para>
            /// </summary>
            [NameInMap("ApkPubkey")]
            [Validation(Required=false)]
            public string ApkPubkey { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2018-07-18T20:18Z</para>
            /// </summary>
            [NameInMap("BeginTime")]
            [Validation(Required=false)]
            public string BeginTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>597b86ec9d90f6122e982fde74994226465e90046ece0f958ea4614800577b99</para>
            /// </summary>
            [NameInMap("ClientId")]
            [Validation(Required=false)]
            public string ClientId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>testproduct</para>
            /// </summary>
            [NameInMap("DeviceName")]
            [Validation(Required=false)]
            public string DeviceName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2018-08-18T20:18Z</para>
            /// </summary>
            [NameInMap("ExpiredTime")]
            [Validation(Required=false)]
            public string ExpiredTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ZNCZegXwLSfplCSL4SoA00105e1400</para>
            /// </summary>
            [NameInMap("IotId")]
            [Validation(Required=false)]
            public string IotId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("LicenseType")]
            [Validation(Required=false)]
            public int? LicenseType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>com.alibaba.security.rp.verifyclient.debug</para>
            /// </summary>
            [NameInMap("PackageName")]
            [Validation(Required=false)]
            public string PackageName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>testproduct</para>
            /// </summary>
            [NameInMap("ProductKey")]
            [Validation(Required=false)]
            public string ProductKey { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageCount")]
        [Validation(Required=false)]
        public int? PageCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>FBE0F2A8-F115-4FE8-BF80-2D068E2372CB</para>
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

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
