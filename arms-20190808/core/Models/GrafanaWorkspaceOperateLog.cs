// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class GrafanaWorkspaceOperateLog : TeaModel {
        [NameInMap("date")]
        [Validation(Required=false)]
        public float? Date { get; set; }

        [NameInMap("detail")]
        [Validation(Required=false)]
        public string Detail { get; set; }

        [NameInMap("grafanaWorkspaceId")]
        [Validation(Required=false)]
        public string GrafanaWorkspaceId { get; set; }

        [NameInMap("id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

    }

}
