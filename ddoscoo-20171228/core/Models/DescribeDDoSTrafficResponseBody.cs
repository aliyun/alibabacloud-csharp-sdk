// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20171228.Models
{
    public class DescribeDDoSTrafficResponseBody : TeaModel {
        [NameInMap("DDoSTrafficPoints")]
        [Validation(Required=false)]
        public List<DescribeDDoSTrafficResponseBodyDDoSTrafficPoints> DDoSTrafficPoints { get; set; }
        public class DescribeDDoSTrafficResponseBodyDDoSTrafficPoints : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>129867</para>
            /// </summary>
            [NameInMap("DefenseMaxInBps")]
            [Validation(Required=false)]
            public long? DefenseMaxInBps { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>129867</para>
            /// </summary>
            [NameInMap("SourceMaxInBps")]
            [Validation(Required=false)]
            public long? SourceMaxInBps { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>234082304</para>
            /// </summary>
            [NameInMap("Time")]
            [Validation(Required=false)]
            public long? Time { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>23482234</para>
        /// </summary>
        [NameInMap("DefenseInBytes")]
        [Validation(Required=false)]
        public long? DefenseInBytes { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CF33B4C3-196E-4015-AADD-5CAD00057B80</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>19284762</para>
        /// </summary>
        [NameInMap("SourceInBytes")]
        [Validation(Required=false)]
        public long? SourceInBytes { get; set; }

    }

}
