// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeInternetTrafficTopResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("DataCount")]
        [Validation(Required=false)]
        public int? DataCount { get; set; }

        [NameInMap("DataList")]
        [Validation(Required=false)]
        public List<DescribeInternetTrafficTopResponseBodyDataList> DataList { get; set; }
        public class DescribeInternetTrafficTopResponseBodyDataList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>US</para>
            /// </summary>
            [NameInMap("DataName")]
            [Validation(Required=false)]
            public string DataName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>47.12</para>
            /// </summary>
            [NameInMap("DataValue")]
            [Validation(Required=false)]
            public string DataValue { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("IsSubscribed")]
            [Validation(Required=false)]
            public bool? IsSubscribed { get; set; }

            [NameInMap("LabelList")]
            [Validation(Required=false)]
            public List<string> LabelList { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>27</para>
            /// </summary>
            [NameInMap("SessionCount")]
            [Validation(Required=false)]
            public long? SessionCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("TotalBytes")]
            [Validation(Required=false)]
            public long? TotalBytes { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>in_src_ip</para>
        /// </summary>
        [NameInMap("DataType")]
        [Validation(Required=false)]
        public string DataType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>15FCCC52-1E23-57AE-B5EF-3E00A3******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
