// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeDomainViewSourceProvincesResponseBody : TeaModel {
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
        /// <para>An array consisting of the details of the administrative region in China from which the requests are sent.</para>
        /// </summary>
        [NameInMap("SourceProvinces")]
        [Validation(Required=false)]
        public List<DescribeDomainViewSourceProvincesResponseBodySourceProvinces> SourceProvinces { get; set; }
        public class DescribeDomainViewSourceProvincesResponseBodySourceProvinces : TeaModel {
            /// <summary>
            /// <para>The total number of requests.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3390671</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            /// <summary>
            /// <para>The ID of the region inside China. For more information, see the <b>Codes of administrative regions in China</b> section of the <a href="https://help.aliyun.com/document_detail/167926.html">Codes of administrative regions in China and codes of countries and areas</a> topic. For example, <b>110000</b> indicates Beijing, and <b>120000</b> indicates Tianjin.</para>
            /// 
            /// <b>Example:</b>
            /// <para>440000</para>
            /// </summary>
            [NameInMap("ProvinceId")]
            [Validation(Required=false)]
            public string ProvinceId { get; set; }

        }

    }

}
