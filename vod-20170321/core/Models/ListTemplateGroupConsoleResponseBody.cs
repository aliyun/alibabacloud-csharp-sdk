// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class ListTemplateGroupConsoleResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TemplateGroups")]
        [Validation(Required=false)]
        public ListTemplateGroupConsoleResponseBodyTemplateGroups TemplateGroups { get; set; }
        public class ListTemplateGroupConsoleResponseBodyTemplateGroups : TeaModel {
            [NameInMap("TemplateGroup")]
            [Validation(Required=false)]
            public List<ListTemplateGroupConsoleResponseBodyTemplateGroupsTemplateGroup> TemplateGroup { get; set; }
            public class ListTemplateGroupConsoleResponseBodyTemplateGroupsTemplateGroup : TeaModel {
                [NameInMap("DefaultGroup")]
                [Validation(Required=false)]
                public string DefaultGroup { get; set; }

                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                [NameInMap("GroupSymbol")]
                [Validation(Required=false)]
                public string GroupSymbol { get; set; }

                [NameInMap("GroupType")]
                [Validation(Required=false)]
                public string GroupType { get; set; }

                [NameInMap("IsLocked")]
                [Validation(Required=false)]
                public string IsLocked { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("TranscodeMode")]
                [Validation(Required=false)]
                public string TranscodeMode { get; set; }

            }

        }

    }

}
