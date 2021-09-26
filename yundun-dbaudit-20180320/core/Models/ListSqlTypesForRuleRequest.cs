// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_dbaudit20180320.Models
{
    public class ListSqlTypesForRuleRequest : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("TypeId")]
        [Validation(Required=false)]
        public string TypeId { get; set; }

        [NameInMap("Sqltype1")]
        [Validation(Required=false)]
        public string Sqltype1 { get; set; }

        [NameInMap("KeyWorld")]
        [Validation(Required=false)]
        public string KeyWorld { get; set; }

    }

}
