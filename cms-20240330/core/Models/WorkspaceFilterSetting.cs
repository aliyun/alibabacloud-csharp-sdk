// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class WorkspaceFilterSetting : TeaModel {
        [NameInMap("tagSelector")]
        [Validation(Required=false)]
        public FilterSetting TagSelector { get; set; }

        [NameInMap("workspaceUuids")]
        [Validation(Required=false)]
        public List<string> WorkspaceUuids { get; set; }

    }

}
