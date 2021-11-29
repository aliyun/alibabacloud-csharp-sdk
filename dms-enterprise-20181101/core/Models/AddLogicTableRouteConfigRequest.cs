/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class AddLogicTableRouteConfigRequest : TeaModel {
        [NameInMap("RouteExpr")]
        [Validation(Required=false)]
        public string RouteExpr { get; set; }

        [NameInMap("RouteKey")]
        [Validation(Required=false)]
        public string RouteKey { get; set; }

        [NameInMap("TableId")]
        [Validation(Required=false)]
        public long? TableId { get; set; }

        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
