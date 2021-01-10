// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkvisual20180120.Models
{
    public class QueryFaceAllUserGroupAndDeviceGroupRelationResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryFaceAllUserGroupAndDeviceGroupRelationResponseBodyData Data { get; set; }
        public class QueryFaceAllUserGroupAndDeviceGroupRelationResponseBodyData : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<QueryFaceAllUserGroupAndDeviceGroupRelationResponseBodyDataList> List { get; set; }
            public class QueryFaceAllUserGroupAndDeviceGroupRelationResponseBodyDataList : TeaModel {
                public string DeviceGroupId { get; set; }
                public string ModifiedTime { get; set; }
                public string ControlType { get; set; }
                public string UserGroupId { get; set; }
                public string ControlId { get; set; }
            }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }
            [NameInMap("Page")]
            [Validation(Required=false)]
            public int? Page { get; set; }
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
