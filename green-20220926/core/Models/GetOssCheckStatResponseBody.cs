// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class GetOssCheckStatResponseBody : TeaModel {
        /// <summary>
        /// <para>The bar chart data.</para>
        /// </summary>
        [NameInMap("BarChart")]
        [Validation(Required=false)]
        public GetOssCheckStatResponseBodyBarChart BarChart { get; set; }
        public class GetOssCheckStatResponseBodyBarChart : TeaModel {
            /// <summary>
            /// <para>The X value of the coordinate point.</para>
            /// </summary>
            [NameInMap("X")]
            [Validation(Required=false)]
            public List<string> X { get; set; }

            /// <summary>
            /// <para>The Y value of the coordinate point.</para>
            /// </summary>
            [NameInMap("Y")]
            [Validation(Required=false)]
            public List<GetOssCheckStatResponseBodyBarChartY> Y { get; set; }
            public class GetOssCheckStatResponseBodyBarChartY : TeaModel {
                /// <summary>
                /// <para>The data.</para>
                /// </summary>
                [NameInMap("Data")]
                [Validation(Required=false)]
                public List<long?> Data { get; set; }

                /// <summary>
                /// <para>The name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>document_detection</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID assigned by the backend to uniquely identify a request. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAA-BBBB-CCCCC-DDDD-EEEEEEEE****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
