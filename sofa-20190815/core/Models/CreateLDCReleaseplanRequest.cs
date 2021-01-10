// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class CreateLDCReleaseplanRequest : TeaModel {
        [NameInMap("IsAutoExecute")]
        [Validation(Required=false)]
        public bool? IsAutoExecute { get; set; }

        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        [NameInMap("OpsType")]
        [Validation(Required=false)]
        public string OpsType { get; set; }

        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        [NameInMap("WorkspaceGroup")]
        [Validation(Required=false)]
        public string WorkspaceGroup { get; set; }

        [NameInMap("AppServices")]
        [Validation(Required=false)]
        public List<CreateLDCReleaseplanRequestAppServices> AppServices { get; set; }
        public class CreateLDCReleaseplanRequestAppServices : TeaModel {
            [NameInMap("Dependencies")]
            [Validation(Required=false)]
            public List<string> Dependencies { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Revision")]
            [Validation(Required=false)]
            public string Revision { get; set; }

        }

    }

}
