// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Videorecog20200320.Models
{
    public class SplitVideoPartsResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public SplitVideoPartsResponseBodyData Data { get; set; }
        public class SplitVideoPartsResponseBodyData : TeaModel {
            [NameInMap("Elements")]
            [Validation(Required=false)]
            public List<SplitVideoPartsResponseBodyDataElements> Elements { get; set; }
            public class SplitVideoPartsResponseBodyDataElements : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>10.06</para>
                /// </summary>
                [NameInMap("BeginTime")]
                [Validation(Required=false)]
                public float? BeginTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>17.3</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public float? EndTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Index")]
                [Validation(Required=false)]
                public long? Index { get; set; }

            }

            [NameInMap("SplitVideoPartResults")]
            [Validation(Required=false)]
            public List<SplitVideoPartsResponseBodyDataSplitVideoPartResults> SplitVideoPartResults { get; set; }
            public class SplitVideoPartsResponseBodyDataSplitVideoPartResults : TeaModel {
                [NameInMap("BeginTime")]
                [Validation(Required=false)]
                public float? BeginTime { get; set; }

                [NameInMap("By")]
                [Validation(Required=false)]
                public string By { get; set; }

                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public float? EndTime { get; set; }

                [NameInMap("Theme")]
                [Validation(Required=false)]
                public string Theme { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>A00A3C17-61D5-1489-860D-B709F83A7C40</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
