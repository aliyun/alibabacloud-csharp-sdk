// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PAILangStudio20240710.Models
{
    public class Toolset : TeaModel {
        [NameInMap("Accessibility")]
        [Validation(Required=false)]
        public string Accessibility { get; set; }

        [NameInMap("Creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        [NameInMap("GmtModifiedTime")]
        [Validation(Required=false)]
        public string GmtModifiedTime { get; set; }

        [NameInMap("Tools")]
        [Validation(Required=false)]
        public string Tools { get; set; }

        [NameInMap("ToolsetConfig")]
        [Validation(Required=false)]
        public string ToolsetConfig { get; set; }

        [NameInMap("ToolsetId")]
        [Validation(Required=false)]
        public string ToolsetId { get; set; }

        [NameInMap("ToolsetName")]
        [Validation(Required=false)]
        public string ToolsetName { get; set; }

        [NameInMap("ToolsetType")]
        [Validation(Required=false)]
        public string ToolsetType { get; set; }

        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
