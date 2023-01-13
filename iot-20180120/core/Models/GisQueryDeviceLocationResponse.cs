// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class GisQueryDeviceLocationResponse : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=true)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public List<GisQueryDeviceLocationResponseData> Data { get; set; }
        public class GisQueryDeviceLocationResponseData : TeaModel {
            [NameInMap("Adcode")]
            [Validation(Required=true)]
            public long? Adcode { get; set; }

            [NameInMap("City")]
            [Validation(Required=true)]
            public string City { get; set; }

            [NameInMap("CoordinateSystem")]
            [Validation(Required=true)]
            public int? CoordinateSystem { get; set; }

            [NameInMap("Country")]
            [Validation(Required=true)]
            public string Country { get; set; }

            [NameInMap("DeviceName")]
            [Validation(Required=true)]
            public string DeviceName { get; set; }

            [NameInMap("Ip")]
            [Validation(Required=true)]
            public string Ip { get; set; }

            [NameInMap("Latitude")]
            [Validation(Required=true)]
            public float? Latitude { get; set; }

            [NameInMap("Longitude")]
            [Validation(Required=true)]
            public float? Longitude { get; set; }

            [NameInMap("ProductKey")]
            [Validation(Required=true)]
            public string ProductKey { get; set; }

            [NameInMap("Province")]
            [Validation(Required=true)]
            public string Province { get; set; }

        }

    }

}
