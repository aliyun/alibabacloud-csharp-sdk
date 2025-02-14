// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetCheckTimeDimensionStatisticResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>028CF634-5268-5660-9575-48C9ED6B****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TimeDimensionStatisticDTO")]
        [Validation(Required=false)]
        public GetCheckTimeDimensionStatisticResponseBodyTimeDimensionStatisticDTO TimeDimensionStatisticDTO { get; set; }
        public class GetCheckTimeDimensionStatisticResponseBodyTimeDimensionStatisticDTO : TeaModel {
            [NameInMap("Dates")]
            [Validation(Required=false)]
            public List<long?> Dates { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>CheckPassRate</para>
            /// </summary>
            [NameInMap("StatisticType")]
            [Validation(Required=false)]
            public string StatisticType { get; set; }

            [NameInMap("TimeDimensionStatisticItems")]
            [Validation(Required=false)]
            public List<GetCheckTimeDimensionStatisticResponseBodyTimeDimensionStatisticDTOTimeDimensionStatisticItems> TimeDimensionStatisticItems { get; set; }
            public class GetCheckTimeDimensionStatisticResponseBodyTimeDimensionStatisticDTOTimeDimensionStatisticItems : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1712592000000</para>
                /// </summary>
                [NameInMap("DataTime")]
                [Validation(Required=false)]
                public long? DataTime { get; set; }

                [NameInMap("StatisticDatas")]
                [Validation(Required=false)]
                public List<GetCheckTimeDimensionStatisticResponseBodyTimeDimensionStatisticDTOTimeDimensionStatisticItemsStatisticDatas> StatisticDatas { get; set; }
                public class GetCheckTimeDimensionStatisticResponseBodyTimeDimensionStatisticDTOTimeDimensionStatisticItemsStatisticDatas : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>COMPLIANCE_Pass</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>194</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public int? Value { get; set; }

                }

            }

        }

    }

}
