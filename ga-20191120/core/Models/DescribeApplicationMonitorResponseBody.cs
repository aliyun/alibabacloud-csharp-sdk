// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class DescribeApplicationMonitorResponseBody : TeaModel {
        [NameInMap("AcceleratorId")]
        [Validation(Required=false)]
        public string AcceleratorId { get; set; }

        [NameInMap("Address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        [NameInMap("DetectEnable")]
        [Validation(Required=false)]
        public bool? DetectEnable { get; set; }

        [NameInMap("DetectThreshold")]
        [Validation(Required=false)]
        public int? DetectThreshold { get; set; }

        [NameInMap("DetectTimes")]
        [Validation(Required=false)]
        public int? DetectTimes { get; set; }

        [NameInMap("IspCityList")]
        [Validation(Required=false)]
        public List<DescribeApplicationMonitorResponseBodyIspCityList> IspCityList { get; set; }
        public class DescribeApplicationMonitorResponseBodyIspCityList : TeaModel {
            [NameInMap("City")]
            [Validation(Required=false)]
            public string City { get; set; }

            [NameInMap("CityName")]
            [Validation(Required=false)]
            public string CityName { get; set; }

            [NameInMap("Isp")]
            [Validation(Required=false)]
            public string Isp { get; set; }

            [NameInMap("IspName")]
            [Validation(Required=false)]
            public string IspName { get; set; }

        }

        [NameInMap("ListenerId")]
        [Validation(Required=false)]
        public string ListenerId { get; set; }

        [NameInMap("OptionsJson")]
        [Validation(Required=false)]
        public string OptionsJson { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SilenceTime")]
        [Validation(Required=false)]
        public int? SilenceTime { get; set; }

        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

    }

}
