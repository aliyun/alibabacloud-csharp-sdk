// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class GetOssCheckStatResponseBody : TeaModel {
        [NameInMap("BarChart")]
        [Validation(Required=false)]
        public GetOssCheckStatResponseBodyBarChart BarChart { get; set; }
        public class GetOssCheckStatResponseBodyBarChart : TeaModel {
            [NameInMap("X")]
            [Validation(Required=false)]
            public List<string> X { get; set; }

            [NameInMap("Y")]
            [Validation(Required=false)]
            public List<GetOssCheckStatResponseBodyBarChartY> Y { get; set; }
            public class GetOssCheckStatResponseBodyBarChartY : TeaModel {
                [NameInMap("Data")]
                [Validation(Required=false)]
                public List<long?> Data { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>document_detection</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>AAAAAA-BBBB-CCCCC-DDDD-EEEEEEEE****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
