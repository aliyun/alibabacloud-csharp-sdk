// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20171228.Models
{
    public class DescribeDomainStatusCodeListResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>3B63C0DD-8AC5-44B2-95D6-064CA9296B9C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StatusCodeList")]
        [Validation(Required=false)]
        public List<DescribeDomainStatusCodeListResponseBodyStatusCodeList> StatusCodeList { get; set; }
        public class DescribeDomainStatusCodeListResponseBodyStatusCodeList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Index")]
            [Validation(Required=false)]
            public int? Index { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>320</para>
            /// </summary>
            [NameInMap("Status200")]
            [Validation(Required=false)]
            public long? Status200 { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5776</para>
            /// </summary>
            [NameInMap("Status2XX")]
            [Validation(Required=false)]
            public long? Status2XX { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Status3XX")]
            [Validation(Required=false)]
            public long? Status3XX { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Status403")]
            [Validation(Required=false)]
            public long? Status403 { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>34</para>
            /// </summary>
            [NameInMap("Status404")]
            [Validation(Required=false)]
            public long? Status404 { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>11</para>
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
            /// <b>Example:</b>
            /// <para>168</para>
            /// </summary>
            [NameInMap("Status4XX")]
            [Validation(Required=false)]
            public long? Status4XX { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Status501")]
            [Validation(Required=false)]
            public long? Status501 { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Status502")]
            [Validation(Required=false)]
            public long? Status502 { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Status503")]
            [Validation(Required=false)]
            public long? Status503 { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Status504")]
            [Validation(Required=false)]
            public long? Status504 { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>7</para>
            /// </summary>
            [NameInMap("Status5XX")]
            [Validation(Required=false)]
            public long? Status5XX { get; set; }

        }

    }

}
