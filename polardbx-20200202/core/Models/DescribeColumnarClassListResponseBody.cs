// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class DescribeColumnarClassListResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeColumnarClassListResponseBodyData Data { get; set; }
        public class DescribeColumnarClassListResponseBodyData : TeaModel {
            /// <summary>
            /// <para>object</para>
            /// </summary>
            [NameInMap("ClassCodeList")]
            [Validation(Required=false)]
            public List<DescribeColumnarClassListResponseBodyDataClassCodeList> ClassCodeList { get; set; }
            public class DescribeColumnarClassListResponseBodyDataClassCodeList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>polarx.n8.large.col</para>
                /// </summary>
                [NameInMap("ClassCode")]
                [Validation(Required=false)]
                public string ClassCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("CpuCore")]
                [Validation(Required=false)]
                public string CpuCore { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2048</para>
                /// </summary>
                [NameInMap("Mem")]
                [Validation(Required=false)]
                public string Mem { get; set; }

            }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>173CA69A-3513-591D-8A09-C1EA37CBE2D9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
