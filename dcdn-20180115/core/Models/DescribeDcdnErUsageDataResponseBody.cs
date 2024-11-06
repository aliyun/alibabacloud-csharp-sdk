// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnErUsageDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The end of the time range during which data was queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2018-10-31T16:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The list of the data returned.</para>
        /// </summary>
        [NameInMap("ErAccData")]
        [Validation(Required=false)]
        public DescribeDcdnErUsageDataResponseBodyErAccData ErAccData { get; set; }
        public class DescribeDcdnErUsageDataResponseBodyErAccData : TeaModel {
            [NameInMap("ErAccItem")]
            [Validation(Required=false)]
            public List<DescribeDcdnErUsageDataResponseBodyErAccDataErAccItem> ErAccItem { get; set; }
            public class DescribeDcdnErUsageDataResponseBodyErAccDataErAccItem : TeaModel {
                /// <summary>
                /// <para>The number of requests.</para>
                /// 
                /// <b>Example:</b>
                /// <para>125</para>
                /// </summary>
                [NameInMap("ErAcc")]
                [Validation(Required=false)]
                public long? ErAcc { get; set; }

                /// <summary>
                /// <para>The ID of the routine. This parameter is returned only when SplitBy is set to routine.</para>
                /// 
                /// <b>Example:</b>
                /// <para>routine1.test</para>
                /// </summary>
                [NameInMap("Routine")]
                [Validation(Required=false)]
                public string Routine { get; set; }

                /// <summary>
                /// <para>The specification of the routine. This parameter is returned only when SplitBy is set to spec.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50ms</para>
                /// </summary>
                [NameInMap("Spec")]
                [Validation(Required=false)]
                public string Spec { get; set; }

                /// <summary>
                /// <para>The timestamp of the returned data.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2018-10-30T13:00:00Z</para>
                /// </summary>
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C370DAF1-C838-4288-A1A0-9A87633D248E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The start of the time range during which data was queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2018-10-30T16:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
