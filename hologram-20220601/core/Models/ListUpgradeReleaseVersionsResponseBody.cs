// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hologram20220601.Models
{
    public class ListUpgradeReleaseVersionsResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListUpgradeReleaseVersionsResponseBodyData> Data { get; set; }
        public class ListUpgradeReleaseVersionsResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://help.aliyun.com/zh/hologres/product-overview/release-notes">https://help.aliyun.com/zh/hologres/product-overview/release-notes</a></para>
            /// </summary>
            [NameInMap("ReleaseNotesUrl")]
            [Validation(Required=false)]
            public string ReleaseNotesUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Stable</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("UpgradeStrategy")]
            [Validation(Required=false)]
            public List<string> UpgradeStrategy { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>r2.2.47</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public string HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>F6DFB9EA-0E2A-52AC-BFD5-1ADBBFFB6A2B</para>
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
