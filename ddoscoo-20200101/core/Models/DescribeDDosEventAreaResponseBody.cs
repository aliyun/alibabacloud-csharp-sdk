// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeDDosEventAreaResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the source region from which the volumetric attack was initiated.</para>
        /// </summary>
        [NameInMap("Areas")]
        [Validation(Required=false)]
        public List<DescribeDDosEventAreaResponseBodyAreas> Areas { get; set; }
        public class DescribeDDosEventAreaResponseBodyAreas : TeaModel {
            /// <summary>
            /// <para>The code or ID of the source region. For more information, see <a href="https://help.aliyun.com/document_detail/167926.html">Codes of administrative regions in China and codes of countries and areas</a>. For example, <b>110000</b> indicates Beijing, China, and <b>us</b> indicates the United States.</para>
            /// 
            /// <b>Example:</b>
            /// <para>110000</para>
            /// </summary>
            [NameInMap("Area")]
            [Validation(Required=false)]
            public string Area { get; set; }

            /// <summary>
            /// <para>The number of request packets that were sent from the source region.</para>
            /// 
            /// <b>Example:</b>
            /// <para>228</para>
            /// </summary>
            [NameInMap("InPkts")]
            [Validation(Required=false)]
            public long? InPkts { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11710C9F-BC5E-481A-BEC5-C6D8FBFCA827</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
