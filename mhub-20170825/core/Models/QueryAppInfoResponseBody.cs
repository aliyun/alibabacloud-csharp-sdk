// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mhub20170825.Models
{
    public class QueryAppInfoResponseBody : TeaModel {
        [NameInMap("AppInfo")]
        [Validation(Required=false)]
        public QueryAppInfoResponseBodyAppInfo AppInfo { get; set; }
        public class QueryAppInfoResponseBodyAppInfo : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("AppKey")]
            [Validation(Required=false)]
            public string AppKey { get; set; }

            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>com.test.ios</para>
            /// </summary>
            [NameInMap("BundleId")]
            [Validation(Required=false)]
            public string BundleId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("CertDevelopAvail")]
            [Validation(Required=false)]
            public bool? CertDevelopAvail { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2020-12-16T06:25:52Z</para>
            /// </summary>
            [NameInMap("CertDevelopExpiration")]
            [Validation(Required=false)]
            public string CertDevelopExpiration { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("CertProductAvail")]
            [Validation(Required=false)]
            public bool? CertProductAvail { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2020-12-16T06:25:52Z</para>
            /// </summary>
            [NameInMap("CertProductExpiration")]
            [Validation(Required=false)]
            public string CertProductExpiration { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2020-12-16T06:25:52Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("EncodedIcon")]
            [Validation(Required=false)]
            public string EncodedIcon { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("IndustryId")]
            [Validation(Required=false)]
            public int? IndustryId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>com.test.android</para>
            /// </summary>
            [NameInMap("PackageName")]
            [Validation(Required=false)]
            public string PackageName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("ProductId")]
            [Validation(Required=false)]
            public long? ProductId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Readonly")]
            [Validation(Required=false)]
            public bool? Readonly { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>126D4DDD-05A5-49B1-B18C-39C4A929BFB2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
