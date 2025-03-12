// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeAvailableCpuResourceResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeAvailableCpuResourceResponseBodyData> Data { get; set; }
        public class DescribeAvailableCpuResourceResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>UnitNum.RejectComment.Storage</para>
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("MaxCpu")]
            [Validation(Required=false)]
            public long? MaxCpu { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("MinCpu")]
            [Validation(Required=false)]
            public long? MinCpu { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>UnitNum.Change.Accept</para>
            /// </summary>
            [NameInMap("ReviewCode")]
            [Validation(Required=false)]
            public string ReviewCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("UnitNum")]
            [Validation(Required=false)]
            public long? UnitNum { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>EE205C00-30E4-XXXX-XXXX-87E3A8A2AA0C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
