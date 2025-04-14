// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribePortViewSourceCountriesResponseBody : TeaModel {
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
        /// <para>The details about the country or area from which the requests are sent.</para>
        /// </summary>
        [NameInMap("SourceCountrys")]
        [Validation(Required=false)]
        public List<DescribePortViewSourceCountriesResponseBodySourceCountrys> SourceCountrys { get; set; }
        public class DescribePortViewSourceCountriesResponseBodySourceCountrys : TeaModel {
            /// <summary>
            /// <para>The number of requests.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3390671</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            /// <summary>
            /// <para>The abbreviation of the country or area. For example, <b>cn</b> indicates China and <b>us</b> indicates the United States.</para>
            /// <remarks>
            /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/167926.html">Location parameters</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>cn</para>
            /// </summary>
            [NameInMap("CountryId")]
            [Validation(Required=false)]
            public string CountryId { get; set; }

        }

    }

}
