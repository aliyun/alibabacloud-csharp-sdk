// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkvisual20180120.Models
{
    public class QueryFaceAllDeviceGroupResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryFaceAllDeviceGroupResponseBodyData Data { get; set; }
        public class QueryFaceAllDeviceGroupResponseBodyData : TeaModel {
            [NameInMap("DeviceGroupList")]
            [Validation(Required=false)]
            public List<QueryFaceAllDeviceGroupResponseBodyDataDeviceGroupList> DeviceGroupList { get; set; }
            public class QueryFaceAllDeviceGroupResponseBodyDataDeviceGroupList : TeaModel {
                public string DeviceGroupId { get; set; }
                public string ModifiedTime { get; set; }
                public string DeviceGroupName { get; set; }
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
        };

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
