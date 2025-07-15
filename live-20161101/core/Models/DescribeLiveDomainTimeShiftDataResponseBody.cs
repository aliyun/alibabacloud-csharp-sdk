// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveDomainTimeShiftDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8AE1CB3A-6510-442E-A6B9-EF03D05B3E09</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The time shifting usage data that was collected for each time interval.</para>
        /// </summary>
        [NameInMap("TimeShiftData")]
        [Validation(Required=false)]
        public DescribeLiveDomainTimeShiftDataResponseBodyTimeShiftData TimeShiftData { get; set; }
        public class DescribeLiveDomainTimeShiftDataResponseBodyTimeShiftData : TeaModel {
            [NameInMap("DataModule")]
            [Validation(Required=false)]
            public List<DescribeLiveDomainTimeShiftDataResponseBodyTimeShiftDataDataModule> DataModule { get; set; }
            public class DescribeLiveDomainTimeShiftDataResponseBodyTimeShiftDataDataModule : TeaModel {
                /// <summary>
                /// <para>The storage used for time shifting. Unit: bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1664165660</para>
                /// </summary>
                [NameInMap("Size")]
                [Validation(Required=false)]
                public string Size { get; set; }

                /// <summary>
                /// <para>The timestamp of the data returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-03-03T00:00:00Z</para>
                /// </summary>
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

                /// <summary>
                /// <para>The type of time shifting. Examples: HLS_D1 and HLS_D7.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HLS_D7</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

    }

}
