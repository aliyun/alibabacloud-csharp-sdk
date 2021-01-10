// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class CreateLDCFlowSiteRequest : TeaModel {
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("InterfaceType")]
        [Validation(Required=false)]
        public string InterfaceType { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Operator")]
        [Validation(Required=false)]
        public string Operator { get; set; }

        [NameInMap("SiteType")]
        [Validation(Required=false)]
        public string SiteType { get; set; }

        [NameInMap("UniqueId")]
        [Validation(Required=false)]
        public string UniqueId { get; set; }

        [NameInMap("WorkspaceGroup")]
        [Validation(Required=false)]
        public string WorkspaceGroup { get; set; }

        [NameInMap("InterfaceUrlsRepeatList")]
        [Validation(Required=false)]
        public List<string> InterfaceUrlsRepeatList { get; set; }

    }

}
