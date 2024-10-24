// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribePortViewSourceProvincesResponseBody : TeaModel {
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
        /// <para>Details about the administrative region in China from which the requests are sent.</para>
        /// </summary>
        [NameInMap("SourceProvinces")]
        [Validation(Required=false)]
        public List<DescribePortViewSourceProvincesResponseBodySourceProvinces> SourceProvinces { get; set; }
        public class DescribePortViewSourceProvincesResponseBodySourceProvinces : TeaModel {
            /// <summary>
            /// <para>The total number of requests that are sent from the ISP.</para>
            /// <remarks>
            /// <para>This parameter does not indicate the accurate number of requests. You can use this parameter to calculate the proportion of requests from different administrative regions in China.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>3390671</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            /// <summary>
            /// <para>The ID of the administrative region in China from which the requests are sent. For example, <b>110000</b> indicates Beijing, and <b>120000</b> indicates Tianjin.</para>
            /// <remarks>
            /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/167926.html">Location parameters</a>.</para>
            /// </remarks>
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
