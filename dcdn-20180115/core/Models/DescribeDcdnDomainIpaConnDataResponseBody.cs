// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnDomainIpaConnDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of user connections at each time interval.</para>
        /// </summary>
        [NameInMap("ConnectionDataPerInterval")]
        [Validation(Required=false)]
        public DescribeDcdnDomainIpaConnDataResponseBodyConnectionDataPerInterval ConnectionDataPerInterval { get; set; }
        public class DescribeDcdnDomainIpaConnDataResponseBodyConnectionDataPerInterval : TeaModel {
            [NameInMap("DataModule")]
            [Validation(Required=false)]
            public List<DescribeDcdnDomainIpaConnDataResponseBodyConnectionDataPerIntervalDataModule> DataModule { get; set; }
            public class DescribeDcdnDomainIpaConnDataResponseBodyConnectionDataPerIntervalDataModule : TeaModel {
                /// <summary>
                /// <para>The number of IPA user connections.</para>
                /// 
                /// <b>Example:</b>
                /// <para>189095</para>
                /// </summary>
                [NameInMap("Connections")]
                [Validation(Required=false)]
                public long? Connections { get; set; }

                /// <summary>
                /// <para>The accelerated domain name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example1.com</para>
                /// </summary>
                [NameInMap("Domain")]
                [Validation(Required=false)]
                public string Domain { get; set; }

                /// <summary>
                /// <para>The timestamp of the data returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-02-21T15:00:00+08:00</para>
                /// </summary>
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

            }

        }

        /// <summary>
        /// <para>The end of the time range during which data was queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2015-02-22T15:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A2A1EEF8-043E-43A1-807C-BEAC18EA1807</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The beginning of the time range during which data was queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2015-02-21T15:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
