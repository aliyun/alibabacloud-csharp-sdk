// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hitsdb20200615.Models
{
    public class GetLindormV2InstanceEngineListResponseBody : TeaModel {
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        [NameInMap("EngineList")]
        [Validation(Required=false)]
        public List<GetLindormV2InstanceEngineListResponseBodyEngineList> EngineList { get; set; }
        public class GetLindormV2InstanceEngineListResponseBodyEngineList : TeaModel {
            [NameInMap("EngineType")]
            [Validation(Required=false)]
            public string EngineType { get; set; }

            [NameInMap("NetInfoList")]
            [Validation(Required=false)]
            public List<GetLindormV2InstanceEngineListResponseBodyEngineListNetInfoList> NetInfoList { get; set; }
            public class GetLindormV2InstanceEngineListResponseBodyEngineListNetInfoList : TeaModel {
                [NameInMap("AccessType")]
                [Validation(Required=false)]
                public int? AccessType { get; set; }

                [NameInMap("ConnectionString")]
                [Validation(Required=false)]
                public string ConnectionString { get; set; }

                [NameInMap("NetType")]
                [Validation(Required=false)]
                public string NetType { get; set; }

                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

            }

        }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
