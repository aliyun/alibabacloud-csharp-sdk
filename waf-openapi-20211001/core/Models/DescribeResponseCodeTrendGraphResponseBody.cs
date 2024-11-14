// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeResponseCodeTrendGraphResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7D46493E-84DD-58CE-80A7-8643****9ECC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The array of the statistics of the error codes.</para>
        /// </summary>
        [NameInMap("ResponseCodes")]
        [Validation(Required=false)]
        public List<DescribeResponseCodeTrendGraphResponseBodyResponseCodes> ResponseCodes { get; set; }
        public class DescribeResponseCodeTrendGraphResponseBodyResponseCodes : TeaModel {
            /// <summary>
            /// <para>The number of 302 error codes that are returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("302Pv")]
            [Validation(Required=false)]
            public long? Code302Pv { get; set; }

            /// <summary>
            /// <para>The number of 405 error codes that are returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>121645464</para>
            /// </summary>
            [NameInMap("405Pv")]
            [Validation(Required=false)]
            public long? Code405Pv { get; set; }

            /// <summary>
            /// <para>The number of 444 error codes that are returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("444Pv")]
            [Validation(Required=false)]
            public long? Code444Pv { get; set; }

            /// <summary>
            /// <para>The number of 499 error codes that are returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("499Pv")]
            [Validation(Required=false)]
            public long? Code499Pv { get; set; }

            /// <summary>
            /// <para>The number of 5xx error codes that are returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2932</para>
            /// </summary>
            [NameInMap("5xxPv")]
            [Validation(Required=false)]
            public long? Code5xxPv { get; set; }

            /// <summary>
            /// <para>The serial number of the time interval. The serial numbers are arranged in chronological order.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Index")]
            [Validation(Required=false)]
            public long? Index { get; set; }

        }

    }

}
