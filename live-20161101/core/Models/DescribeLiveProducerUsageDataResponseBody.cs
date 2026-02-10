// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveProducerUsageDataResponseBody : TeaModel {
        [NameInMap("BillProducerData")]
        [Validation(Required=false)]
        public DescribeLiveProducerUsageDataResponseBodyBillProducerData BillProducerData { get; set; }
        public class DescribeLiveProducerUsageDataResponseBodyBillProducerData : TeaModel {
            [NameInMap("BillProducerDataItem")]
            [Validation(Required=false)]
            public List<DescribeLiveProducerUsageDataResponseBodyBillProducerDataBillProducerDataItem> BillProducerDataItem { get; set; }
            public class DescribeLiveProducerUsageDataResponseBodyBillProducerDataBillProducerDataItem : TeaModel {
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                [NameInMap("Instance")]
                [Validation(Required=false)]
                public string Instance { get; set; }

                [NameInMap("OutputHdDuration")]
                [Validation(Required=false)]
                public long? OutputHdDuration { get; set; }

                [NameInMap("OutputLdDuration")]
                [Validation(Required=false)]
                public long? OutputLdDuration { get; set; }

                [NameInMap("OutputSdDuration")]
                [Validation(Required=false)]
                public long? OutputSdDuration { get; set; }

                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

                [NameInMap("TranHdDuration")]
                [Validation(Required=false)]
                public long? TranHdDuration { get; set; }

                [NameInMap("TranLdDuration")]
                [Validation(Required=false)]
                public long? TranLdDuration { get; set; }

                [NameInMap("TranSdDuration")]
                [Validation(Required=false)]
                public long? TranSdDuration { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// <para>The end of the time range during which data was queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2018-09-30T16:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

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
        /// <para>The start of the time range for which the data was queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2018-10-31T15:59:59Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
