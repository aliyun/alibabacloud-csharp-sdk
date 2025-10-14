// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class DescribeCdcClassListResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeCdcClassListResponseBodyData Data { get; set; }
        public class DescribeCdcClassListResponseBodyData : TeaModel {
            /// <summary>
            /// <para>array</para>
            /// </summary>
            [NameInMap("ClassCodeList")]
            [Validation(Required=false)]
            public List<DescribeCdcClassListResponseBodyDataClassCodeList> ClassCodeList { get; set; }
            public class DescribeCdcClassListResponseBodyDataClassCodeList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>polarx.n2.small.2e.cdc</para>
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
        /// <para>6BA32080EEA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
