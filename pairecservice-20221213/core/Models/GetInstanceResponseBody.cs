// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class GetInstanceResponseBody : TeaModel {
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        [NameInMap("CommodityCode")]
        [Validation(Required=false)]
        public string CommodityCode { get; set; }

        [NameInMap("Config")]
        [Validation(Required=false)]
        public GetInstanceResponseBodyConfig Config { get; set; }
        public class GetInstanceResponseBodyConfig : TeaModel {
            [NameInMap("DataManagements")]
            [Validation(Required=false)]
            public List<GetInstanceResponseBodyConfigDataManagements> DataManagements { get; set; }
            public class GetInstanceResponseBodyConfigDataManagements : TeaModel {
                [NameInMap("ComponentCode")]
                [Validation(Required=false)]
                public string ComponentCode { get; set; }

                [NameInMap("Meta")]
                [Validation(Required=false)]
                public Dictionary<string, object> Meta { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("Engines")]
            [Validation(Required=false)]
            public List<GetInstanceResponseBodyConfigEngines> Engines { get; set; }
            public class GetInstanceResponseBodyConfigEngines : TeaModel {
                [NameInMap("ComponentCode")]
                [Validation(Required=false)]
                public string ComponentCode { get; set; }

                [NameInMap("Meta")]
                [Validation(Required=false)]
                public Dictionary<string, object> Meta { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("Monitors")]
            [Validation(Required=false)]
            public List<GetInstanceResponseBodyConfigMonitors> Monitors { get; set; }
            public class GetInstanceResponseBodyConfigMonitors : TeaModel {
                [NameInMap("ComponentCode")]
                [Validation(Required=false)]
                public string ComponentCode { get; set; }

                [NameInMap("Meta")]
                [Validation(Required=false)]
                public Dictionary<string, object> Meta { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        [NameInMap("ExpiredTime")]
        [Validation(Required=false)]
        public string ExpiredTime { get; set; }

        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        [NameInMap("GmtModifiedTime")]
        [Validation(Required=false)]
        public string GmtModifiedTime { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
