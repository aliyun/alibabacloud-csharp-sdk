// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeDDosEventAreaResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the attack source regions.</para>
        /// </summary>
        [NameInMap("Areas")]
        [Validation(Required=false)]
        public List<DescribeDDosEventAreaResponseBodyAreas> Areas { get; set; }
        public class DescribeDDosEventAreaResponseBodyAreas : TeaModel {
            /// <summary>
            /// <para>The code of the attack source region, including Chinese regions (at the province or city level) and international regions (at the country level). For example, <b>110000</b> indicates Beijing, China, and <b>us</b> indicates the United States.</para>
            /// <remarks>
            /// <para>For more information about the valid values of this parameter, see <a href="https://help.aliyun.com/document_detail/167926.html">China and international regions</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>110000</para>
            /// </summary>
            [NameInMap("Area")]
            [Validation(Required=false)]
            public string Area { get; set; }

            /// <summary>
            /// <para>The number of request packets from the attack source region.</para>
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
