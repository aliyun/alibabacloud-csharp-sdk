// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkvisual20230630.Models
{
    public class QueryGenerateDevicesInfoListResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryGenerateDevicesInfoListResponseBodyData Data { get; set; }
        public class QueryGenerateDevicesInfoListResponseBodyData : TeaModel {
            [NameInMap("ListData")]
            [Validation(Required=false)]
            public List<QueryGenerateDevicesInfoListResponseBodyDataListData> ListData { get; set; }
            public class QueryGenerateDevicesInfoListResponseBodyDataListData : TeaModel {
                [NameInMap("DeviceName")]
                [Validation(Required=false)]
                public string DeviceName { get; set; }

                [NameInMap("DeviceSecret")]
                [Validation(Required=false)]
                public string DeviceSecret { get; set; }

                [NameInMap("IotId")]
                [Validation(Required=false)]
                public string IotId { get; set; }

            }

            [NameInMap("PageNo")]
            [Validation(Required=false)]
            public int? PageNo { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
