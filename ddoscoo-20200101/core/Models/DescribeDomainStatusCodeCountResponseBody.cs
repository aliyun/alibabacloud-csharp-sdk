// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeDomainStatusCodeCountResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C33EB3D5-AF96-43CA-9C7E-37A81BC06A1E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of 200 status codes within the query time range.</para>
        /// 
        /// <b>Example:</b>
        /// <para>951159</para>
        /// </summary>
        [NameInMap("Status200")]
        [Validation(Required=false)]
        public long? Status200 { get; set; }

        /// <summary>
        /// <para>The number of 2XX status codes within the query time range.</para>
        /// 
        /// <b>Example:</b>
        /// <para>951472</para>
        /// </summary>
        [NameInMap("Status2XX")]
        [Validation(Required=false)]
        public long? Status2XX { get; set; }

        /// <summary>
        /// <para>The number of 3XX status codes within the query time range.</para>
        /// 
        /// <b>Example:</b>
        /// <para>133209</para>
        /// </summary>
        [NameInMap("Status3XX")]
        [Validation(Required=false)]
        public long? Status3XX { get; set; }

        /// <summary>
        /// <para>The number of 403 status codes within the query time range.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Status403")]
        [Validation(Required=false)]
        public long? Status403 { get; set; }

        /// <summary>
        /// <para>The number of 404 status codes within the query time range.</para>
        /// 
        /// <b>Example:</b>
        /// <para>897</para>
        /// </summary>
        [NameInMap("Status404")]
        [Validation(Required=false)]
        public long? Status404 { get; set; }

        /// <summary>
        /// <para>The number of 405 status codes within the query time range.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Status405")]
        [Validation(Required=false)]
        public long? Status405 { get; set; }

        /// <summary>
        /// <para>The number of 410 status codes within the query time range.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Status410")]
        [Validation(Required=false)]
        public long? Status410 { get; set; }

        /// <summary>
        /// <para>The number of 499 status codes within the query time range.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Status499")]
        [Validation(Required=false)]
        public long? Status499 { get; set; }

        /// <summary>
        /// <para>The number of 4XX status codes within the query time range.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5653</para>
        /// </summary>
        [NameInMap("Status4XX")]
        [Validation(Required=false)]
        public long? Status4XX { get; set; }

        /// <summary>
        /// <para>The number of 501 status codes within the query time range.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Status501")]
        [Validation(Required=false)]
        public long? Status501 { get; set; }

        /// <summary>
        /// <para>The number of 502 status codes within the query time range.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Status502")]
        [Validation(Required=false)]
        public long? Status502 { get; set; }

        /// <summary>
        /// <para>The number of 503 status codes within the query time range.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Status503")]
        [Validation(Required=false)]
        public long? Status503 { get; set; }

        /// <summary>
        /// <para>The number of 504 status codes within the query time range.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Status504")]
        [Validation(Required=false)]
        public long? Status504 { get; set; }

        /// <summary>
        /// <para>The number of 5XX status codes within the query time range.</para>
        /// 
        /// <b>Example:</b>
        /// <para>14</para>
        /// </summary>
        [NameInMap("Status5XX")]
        [Validation(Required=false)]
        public long? Status5XX { get; set; }

    }

}
