// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class GetRmsRdsResourcesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Response")]
        [Validation(Required=false)]
        public GetRmsRdsResourcesResponseBodyResponse Response { get; set; }
        public class GetRmsRdsResourcesResponseBodyResponse : TeaModel {
            [NameInMap("ErrCode")]
            [Validation(Required=false)]
            public string ErrCode { get; set; }
            [NameInMap("ErrMsg")]
            [Validation(Required=false)]
            public string ErrMsg { get; set; }
            [NameInMap("ErrResolution")]
            [Validation(Required=false)]
            public string ErrResolution { get; set; }
            [NameInMap("Entities")]
            [Validation(Required=false)]
            public List<GetRmsRdsResourcesResponseBodyResponseEntities> Entities { get; set; }
            public class GetRmsRdsResourcesResponseBodyResponseEntities : TeaModel {
                [NameInMap("AlertState")]
                [Validation(Required=false)]
                public string AlertState { get; set; }

                [NameInMap("Created")]
                [Validation(Required=false)]
                public string Created { get; set; }

                [NameInMap("CreatedDateTime")]
                [Validation(Required=false)]
                public long? CreatedDateTime { get; set; }

                [NameInMap("DatabaseType")]
                [Validation(Required=false)]
                public string DatabaseType { get; set; }

                [NameInMap("DbId")]
                [Validation(Required=false)]
                public string DbId { get; set; }

                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                [NameInMap("ResourceName")]
                [Validation(Required=false)]
                public string ResourceName { get; set; }

                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                [NameInMap("ItemTypeConfig")]
                [Validation(Required=false)]
                public List<string> ItemTypeConfig { get; set; }

                [NameInMap("ItemTypeNoneConfig")]
                [Validation(Required=false)]
                public List<string> ItemTypeNoneConfig { get; set; }

            }
            [NameInMap("Meta")]
            [Validation(Required=false)]
            public List<GetRmsRdsResourcesResponseBodyResponseMeta> Meta { get; set; }
            public class GetRmsRdsResourcesResponseBodyResponseMeta : TeaModel {
                public string Key { get; set; }
                public string Value { get; set; }
            }
        };

    }

}
