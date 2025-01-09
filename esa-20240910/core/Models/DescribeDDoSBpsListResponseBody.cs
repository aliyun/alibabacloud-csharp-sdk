// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class DescribeDDoSBpsListResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("DataInterval")]
        [Validation(Required=false)]
        public int? DataInterval { get; set; }

        [NameInMap("DataModule")]
        [Validation(Required=false)]
        public List<DescribeDDoSBpsListResponseBodyDataModule> DataModule { get; set; }
        public class DescribeDDoSBpsListResponseBodyDataModule : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>9000000000</para>
            /// </summary>
            [NameInMap("AttackBps")]
            [Validation(Required=false)]
            public long? AttackBps { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>9000000</para>
            /// </summary>
            [NameInMap("AttackPps")]
            [Validation(Required=false)]
            public long? AttackPps { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1000000000</para>
            /// </summary>
            [NameInMap("NormalBps")]
            [Validation(Required=false)]
            public long? NormalBps { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1000000</para>
            /// </summary>
            [NameInMap("NormalPps")]
            [Validation(Required=false)]
            public long? NormalPps { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-05-14T17:00:00Z</para>
            /// </summary>
            [NameInMap("TimeStamp")]
            [Validation(Required=false)]
            public string TimeStamp { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10000000000</para>
            /// </summary>
            [NameInMap("TotalBps")]
            [Validation(Required=false)]
            public long? TotalBps { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100000000</para>
            /// </summary>
            [NameInMap("TotalPps")]
            [Validation(Required=false)]
            public long? TotalPps { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2023-05-18T06:19:42Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>156A6B-677B1A-4297B7-9187B7-2B44792</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2023-05-14T17:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
