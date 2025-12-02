// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class GetOssCheckStatResponseBody : TeaModel {
        /// <summary>
        /// <para>Bar chart</para>
        /// </summary>
        [NameInMap("BarChart")]
        [Validation(Required=false)]
        public GetOssCheckStatResponseBodyBarChart BarChart { get; set; }
        public class GetOssCheckStatResponseBodyBarChart : TeaModel {
            /// <summary>
            /// <para>X values of the coordinates.</para>
            /// </summary>
            [NameInMap("X")]
            [Validation(Required=false)]
            public List<string> X { get; set; }

            /// <summary>
            /// <para>Y values of the coordinates.</para>
            /// </summary>
            [NameInMap("Y")]
            [Validation(Required=false)]
            public List<GetOssCheckStatResponseBodyBarChartY> Y { get; set; }
            public class GetOssCheckStatResponseBodyBarChartY : TeaModel {
                /// <summary>
                /// <para>Data.</para>
                /// </summary>
                [NameInMap("Data")]
                [Validation(Required=false)]
                public List<long?> Data { get; set; }

                /// <summary>
                /// <para>Name.</para>
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
        /// <para>ID assigned by the backend, used to uniquely identify a request. Can be used for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAA-BBBB-CCCCC-DDDD-EEEEEEEE****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
