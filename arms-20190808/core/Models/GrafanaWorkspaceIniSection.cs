// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class GrafanaWorkspaceIniSection : TeaModel {
        [NameInMap("propertys")]
        [Validation(Required=false)]
        public List<GrafanaWorkspaceIniProperty> Propertys { get; set; }

        [NameInMap("section")]
        [Validation(Required=false)]
        public string Section { get; set; }

    }

}
