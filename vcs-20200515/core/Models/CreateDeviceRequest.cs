// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20200515.Models
{
    public class CreateDeviceRequest : TeaModel {
        [NameInMap("CorpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        [NameInMap("CityCode")]
        [Validation(Required=false)]
        public string CityCode { get; set; }

        [NameInMap("Longitude")]
        [Validation(Required=false)]
        public string Longitude { get; set; }

        [NameInMap("DataSourceType")]
        [Validation(Required=false)]
        public string DataSourceType { get; set; }

        [NameInMap("DeviceName")]
        [Validation(Required=false)]
        public string DeviceName { get; set; }

        [NameInMap("DeviceVendor")]
        [Validation(Required=false)]
        public string DeviceVendor { get; set; }

        [NameInMap("DeviceGroupName")]
        [Validation(Required=false)]
        public string DeviceGroupName { get; set; }

        [NameInMap("Latitude")]
        [Validation(Required=false)]
        public string Latitude { get; set; }

        [NameInMap("DeviceAddress")]
        [Validation(Required=false)]
        public string DeviceAddress { get; set; }

        [NameInMap("DeviceType")]
        [Validation(Required=false)]
        public string DeviceType { get; set; }

        [NameInMap("SubDeviceCount")]
        [Validation(Required=false)]
        public long? SubDeviceCount { get; set; }

    }

}
