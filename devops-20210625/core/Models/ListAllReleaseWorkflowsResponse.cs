// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class ListAllReleaseWorkflowsResponse : TeaModel {
        [NameInMap("headers")]
        [Validation(Required=false)]
        public Dictionary<string, string> Headers { get; set; }

        [NameInMap("statusCode")]
        [Validation(Required=false)]
        public int? StatusCode { get; set; }

        [NameInMap("body")]
        [Validation(Required=false)]
        public List<ListAllReleaseWorkflowsResponseBody> Body { get; set; }
        public class ListAllReleaseWorkflowsResponseBody : TeaModel {
            [NameInMap("appName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            [NameInMap("sn")]
            [Validation(Required=false)]
            public string Sn { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("order")]
            [Validation(Required=false)]
            public string Order { get; set; }

            [NameInMap("releaseStages")]
            [Validation(Required=false)]
            public List<ListAllReleaseWorkflowsResponseBodyReleaseStages> ReleaseStages { get; set; }
            public class ListAllReleaseWorkflowsResponseBodyReleaseStages : TeaModel {
                [NameInMap("appName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("sn")]
                [Validation(Required=false)]
                public string Sn { get; set; }

                [NameInMap("releaseWorkflowSn")]
                [Validation(Required=false)]
                public string ReleaseWorkflowSn { get; set; }

                [NameInMap("order")]
                [Validation(Required=false)]
                public string Order { get; set; }

                [NameInMap("variableGroups")]
                [Validation(Required=false)]
                public List<ListAllReleaseWorkflowsResponseBodyReleaseStagesVariableGroups> VariableGroups { get; set; }
                public class ListAllReleaseWorkflowsResponseBodyReleaseStagesVariableGroups : TeaModel {
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("displayName")]
                    [Validation(Required=false)]
                    public string DisplayName { get; set; }

                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

            }

            [NameInMap("note")]
            [Validation(Required=false)]
            public string Note { get; set; }

        }

    }

}
