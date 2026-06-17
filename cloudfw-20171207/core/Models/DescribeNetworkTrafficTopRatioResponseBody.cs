// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeNetworkTrafficTopRatioResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of results returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DataCount")]
        [Validation(Required=false)]
        public int? DataCount { get; set; }

        /// <summary>
        /// <para>The list of data values.</para>
        /// </summary>
        [NameInMap("DataList")]
        [Validation(Required=false)]
        public List<DescribeNetworkTrafficTopRatioResponseBodyDataList> DataList { get; set; }
        public class DescribeNetworkTrafficTopRatioResponseBodyDataList : TeaModel {
            /// <summary>
            /// <para>The data name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("DataName")]
            [Validation(Required=false)]
            public string DataName { get; set; }

            /// <summary>
            /// <para>The ratio.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("DataValue")]
            [Validation(Required=false)]
            public string DataValue { get; set; }

        }

        /// <summary>
        /// <para>The data type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>in_src_ip</para>
        /// </summary>
        [NameInMap("DataType")]
        [Validation(Required=false)]
        public string DataType { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C05D58A1-28A9-563A-BB59-5F7D1867****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
