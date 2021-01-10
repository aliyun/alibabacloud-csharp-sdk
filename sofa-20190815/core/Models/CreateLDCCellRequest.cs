// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class CreateLDCCellRequest : TeaModel {
        [NameInMap("CellGroup")]
        [Validation(Required=false)]
        public string CellGroup { get; set; }

        [NameInMap("Color")]
        [Validation(Required=false)]
        public string Color { get; set; }

        [NameInMap("Identity")]
        [Validation(Required=false)]
        public string Identity { get; set; }

        [NameInMap("IsGray")]
        [Validation(Required=false)]
        public bool? IsGray { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("Weight")]
        [Validation(Required=false)]
        public long? Weight { get; set; }

        [NameInMap("Workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

        [NameInMap("WorkspaceGroup")]
        [Validation(Required=false)]
        public string WorkspaceGroup { get; set; }

        [NameInMap("Zone")]
        [Validation(Required=false)]
        public string Zone { get; set; }

    }

}
