// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeRoleZoneInfoResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ZoneInfos")]
        [Validation(Required=false)]
        public DescribeRoleZoneInfoResponseBodyZoneInfos ZoneInfos { get; set; }
        public class DescribeRoleZoneInfoResponseBodyZoneInfos : TeaModel {
            [NameInMap("ZoneInfo")]
            [Validation(Required=false)]
            public List<DescribeRoleZoneInfoResponseBodyZoneInfosZoneInfo> ZoneInfo { get; set; }
            public class DescribeRoleZoneInfoResponseBodyZoneInfosZoneInfo : TeaModel {
                [NameInMap("InsName")]
                [Validation(Required=false)]
                public string InsName { get; set; }

                [NameInMap("NodeType")]
                [Validation(Required=false)]
                public string NodeType { get; set; }

                [NameInMap("RoleId")]
                [Validation(Required=false)]
                public string RoleId { get; set; }

                [NameInMap("RoleType")]
                [Validation(Required=false)]
                public string RoleType { get; set; }

                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

    }

}
