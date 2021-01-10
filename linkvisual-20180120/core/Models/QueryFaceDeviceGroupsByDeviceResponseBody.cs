// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkvisual20180120.Models
{
    public class QueryFaceDeviceGroupsByDeviceResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryFaceDeviceGroupsByDeviceResponseBodyData Data { get; set; }
        public class QueryFaceDeviceGroupsByDeviceResponseBodyData : TeaModel {
            [NameInMap("DeviceGroupList")]
            [Validation(Required=false)]
            public List<QueryFaceDeviceGroupsByDeviceResponseBodyDataDeviceGroupList> DeviceGroupList { get; set; }
            public class QueryFaceDeviceGroupsByDeviceResponseBodyDataDeviceGroupList : TeaModel {
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
