// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeDomainStatusCodeListResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3B63C0DD-8AC5-44B2-95D6-064CA9296B9C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The statistics on response status codes.</para>
        /// </summary>
        [NameInMap("StatusCodeList")]
        [Validation(Required=false)]
        public List<DescribeDomainStatusCodeListResponseBodyStatusCodeList> StatusCodeList { get; set; }
        public class DescribeDomainStatusCodeListResponseBodyStatusCodeList : TeaModel {
            /// <summary>
            /// <para>The index number of the returned data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Index")]
            [Validation(Required=false)]
            public int? Index { get; set; }

            /// <summary>
            /// <para>The number of 200 status codes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>15520</para>
            /// </summary>
            [NameInMap("Status200")]
            [Validation(Required=false)]
            public long? Status200 { get; set; }

            /// <summary>
            /// <para>The number of 2xx status codes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>15520</para>
            /// </summary>
            [NameInMap("Status2XX")]
            [Validation(Required=false)]
            public long? Status2XX { get; set; }

            /// <summary>
            /// <para>The number of 3xx status codes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Status3XX")]
            [Validation(Required=false)]
            public long? Status3XX { get; set; }

            /// <summary>
            /// <para>The number of 403 status codes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Status403")]
            [Validation(Required=false)]
            public long? Status403 { get; set; }

            /// <summary>
            /// <para>The number of 404 status codes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Status404")]
            [Validation(Required=false)]
            public long? Status404 { get; set; }

            /// <summary>
            /// <para>The number of 405 status codes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Status405")]
            [Validation(Required=false)]
            public long? Status405 { get; set; }

            [NameInMap("Status410")]
            [Validation(Required=false)]
            public long? Status410 { get; set; }

            [NameInMap("Status499")]
            [Validation(Required=false)]
            public long? Status499 { get; set; }

            /// <summary>
            /// <para>The number of 4xx status codes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4486</para>
            /// </summary>
            [NameInMap("Status4XX")]
            [Validation(Required=false)]
            public long? Status4XX { get; set; }

            /// <summary>
            /// <para>The number of 501 status codes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Status501")]
            [Validation(Required=false)]
            public long? Status501 { get; set; }

            /// <summary>
            /// <para>The number of 502 status codes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Status502")]
            [Validation(Required=false)]
            public long? Status502 { get; set; }

            /// <summary>
            /// <para>The number of 503 status codes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Status503")]
            [Validation(Required=false)]
            public long? Status503 { get; set; }

            /// <summary>
            /// <para>The number of 504 status codes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Status504")]
            [Validation(Required=false)]
            public long? Status504 { get; set; }

            /// <summary>
            /// <para>The number of 5xx status codes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Status5XX")]
            [Validation(Required=false)]
            public long? Status5XX { get; set; }

            /// <summary>
            /// <para>The time when the data was collected. The value is a UNIX timestamp. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1582992000</para>
            /// </summary>
            [NameInMap("Time")]
            [Validation(Required=false)]
            public long? Time { get; set; }

        }

    }

}
