// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnDomainUsageDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The billable region where the usage data was collected.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CN</para>
        /// </summary>
        [NameInMap("Area")]
        [Validation(Required=false)]
        public string Area { get; set; }

        /// <summary>
        /// <para>The time interval between the data entries returned. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/</para>
        /// </summary>
        [NameInMap("DataInterval")]
        [Validation(Required=false)]
        public string DataInterval { get; set; }

        /// <summary>
        /// <para>The accelerated domain name that was queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The end of the time range during which data was queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2015-12-10T22:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B955107D-E658-4E77-B913-E0AC3D31693E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The beginning of the time range during which data was queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2015-12-10T20:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The type of the returned data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bps</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The traffic that was collected at each interval.</para>
        /// </summary>
        [NameInMap("UsageDataPerInterval")]
        [Validation(Required=false)]
        public DescribeDcdnDomainUsageDataResponseBodyUsageDataPerInterval UsageDataPerInterval { get; set; }
        public class DescribeDcdnDomainUsageDataResponseBodyUsageDataPerInterval : TeaModel {
            [NameInMap("DataModule")]
            [Validation(Required=false)]
            public List<DescribeDcdnDomainUsageDataResponseBodyUsageDataPerIntervalDataModule> DataModule { get; set; }
            public class DescribeDcdnDomainUsageDataResponseBodyUsageDataPerIntervalDataModule : TeaModel {
                /// <summary>
                /// <para>The time of the peak bandwidth value if the <b>Field</b> parameter in the request is set to <b>bps</b>. Otherwise, this parameter returns the same value as the <b>TimeStamp</b> parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2015-12-10T21:30:00Z</para>
                /// </summary>
                [NameInMap("PeakTime")]
                [Validation(Required=false)]
                public string PeakTime { get; set; }

                /// <summary>
                /// <para>The data usage in a specific scenario.</para>
                /// <remarks>
                /// <para> This parameter indicates the data usage in a specific scenario. If no special billable item is specified, ignore this parameter.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>4233041**</para>
                /// </summary>
                [NameInMap("SpecialValue")]
                [Validation(Required=false)]
                public string SpecialValue { get; set; }

                /// <summary>
                /// <para>The timestamp of the returned data.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2015-12-10T21:30:00Z</para>
                /// </summary>
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

                /// <summary>
                /// <para>The usage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4233041**</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

    }

}
