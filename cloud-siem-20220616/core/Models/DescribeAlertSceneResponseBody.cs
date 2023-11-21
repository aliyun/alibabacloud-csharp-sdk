// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class DescribeAlertSceneResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeAlertSceneResponseBodyData> Data { get; set; }
        public class DescribeAlertSceneResponseBodyData : TeaModel {
            [NameInMap("AlertName")]
            [Validation(Required=false)]
            public string AlertName { get; set; }

            [NameInMap("AlertNameId")]
            [Validation(Required=false)]
            public string AlertNameId { get; set; }

            [NameInMap("AlertTile")]
            [Validation(Required=false)]
            public string AlertTile { get; set; }

            [NameInMap("AlertTileId")]
            [Validation(Required=false)]
            public string AlertTileId { get; set; }

            [NameInMap("AlertType")]
            [Validation(Required=false)]
            public string AlertType { get; set; }

            [NameInMap("AlertTypeId")]
            [Validation(Required=false)]
            public string AlertTypeId { get; set; }

            [NameInMap("Targets")]
            [Validation(Required=false)]
            public List<DescribeAlertSceneResponseBodyDataTargets> Targets { get; set; }
            public class DescribeAlertSceneResponseBodyDataTargets : TeaModel {
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

                [NameInMap("Values")]
                [Validation(Required=false)]
                public List<string> Values { get; set; }

            }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
