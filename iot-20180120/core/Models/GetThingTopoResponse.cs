// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class GetThingTopoResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=true)]
        public string ErrorMessage { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public GetThingTopoResponseData Data { get; set; }
        public class GetThingTopoResponseData : TeaModel {
            [NameInMap("Total")]
            [Validation(Required=true)]
            public long? Total { get; set; }
            [NameInMap("CurrentPage")]
            [Validation(Required=true)]
            public int? CurrentPage { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=true)]
            public int? PageSize { get; set; }
            [NameInMap("PageCount")]
            [Validation(Required=true)]
            public long? PageCount { get; set; }
            [NameInMap("List")]
            [Validation(Required=true)]
            public GetThingTopoResponseDataList List { get; set; }
            public class GetThingTopoResponseDataList : TeaModel {
                [NameInMap("deviceInfo")]
                [Validation(Required=true)]
                public List<GetThingTopoResponseDataListDeviceInfo> DeviceInfo { get; set; }
                public class GetThingTopoResponseDataListDeviceInfo : TeaModel {
                    [NameInMap("IotId")]
                    [Validation(Required=true)]
                    public string IotId { get; set; }

                    [NameInMap("ProductKey")]
                    [Validation(Required=true)]
                    public string ProductKey { get; set; }

                    [NameInMap("DeviceName")]
                    [Validation(Required=true)]
                    public string DeviceName { get; set; }

                }

            }
        };

    }

}
