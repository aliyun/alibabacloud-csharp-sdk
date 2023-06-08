// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnDomainQpsDataByLayerResponseBody : TeaModel {
        /// <summary>
        /// The end of the time range during which data was queried.
        /// </summary>
        [NameInMap("DataInterval")]
        [Validation(Required=false)]
        public string DataInterval { get; set; }

        /// <summary>
        /// The name of the ISP. You can call the DescribeDcdnRegionAndIsp operation to query the ISP name. If you do not specify a value for this parameter, all ISPs are queried.
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// The layers at which you want to query the QPS. The network layer supports IPv4 and IPv6. The application layer supports http, https, and quic. You can also set the value to all.
        /// 
        /// Default value: all.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The operation that you want to perform. Set the value to **DescribeDcdnDomainQpsDataByLayer**.
        /// </summary>
        [NameInMap("Layer")]
        [Validation(Required=false)]
        public string Layer { get; set; }

        /// <summary>
        /// The name of the region. You can call the DescribeDcdnRegionAndIsp operation to query the region name. If you do not specify a value for this parameter, all regions are queried.
        /// </summary>
        [NameInMap("QpsDataInterval")]
        [Validation(Required=false)]
        public DescribeDcdnDomainQpsDataByLayerResponseBodyQpsDataInterval QpsDataInterval { get; set; }
        public class DescribeDcdnDomainQpsDataByLayerResponseBodyQpsDataInterval : TeaModel {
            [NameInMap("DataModule")]
            [Validation(Required=false)]
            public List<DescribeDcdnDomainQpsDataByLayerResponseBodyQpsDataIntervalDataModule> DataModule { get; set; }
            public class DescribeDcdnDomainQpsDataByLayerResponseBodyQpsDataIntervalDataModule : TeaModel {
                /// <summary>
                /// The number of requests outside the Chinese mainland.
                /// </summary>
                [NameInMap("AccDomesticValue")]
                [Validation(Required=false)]
                public string AccDomesticValue { get; set; }

                /// <summary>
                /// The beginning of the time range during which data was queried.
                /// </summary>
                [NameInMap("AccOverseasValue")]
                [Validation(Required=false)]
                public string AccOverseasValue { get; set; }

                /// <summary>
                /// The number of queries per second in the Chinese mainland.
                /// </summary>
                [NameInMap("AccValue")]
                [Validation(Required=false)]
                public string AccValue { get; set; }

                /// <summary>
                /// The time interval between the data entries returned. Unit: seconds.
                /// </summary>
                [NameInMap("DomesticValue")]
                [Validation(Required=false)]
                public string DomesticValue { get; set; }

                /// <summary>
                /// The total number of queries per second.
                /// </summary>
                [NameInMap("OverseasValue")]
                [Validation(Required=false)]
                public string OverseasValue { get; set; }

                /// <summary>
                /// The time interval between the data entries to return. Unit: seconds.
                /// 
                /// The time granularity varies with the maximum time range per query. Valid values: 300 (5 minutes), 3600 (1 hour), and 86400 (1 day). For more information, see **Description**.
                /// </summary>
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

                /// <summary>
                /// The accelerated domain name. You can specify multiple domain names and separate them with commas (,). You can specify up to 500 domain names in each request. The query results of multiple domain names are aggregated.
                /// 
                /// If you do not specify a domain name, data of all domain names is queried.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// The timestamp of the data returned.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of requests.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
