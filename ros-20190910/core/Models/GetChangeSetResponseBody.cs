// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class GetChangeSetResponseBody : TeaModel {
        [NameInMap("ChangeSetId")]
        [Validation(Required=false)]
        public string ChangeSetId { get; set; }

        [NameInMap("ChangeSetName")]
        [Validation(Required=false)]
        public string ChangeSetName { get; set; }

        [NameInMap("ChangeSetType")]
        [Validation(Required=false)]
        public string ChangeSetType { get; set; }

        [NameInMap("Changes")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> Changes { get; set; }

        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("DisableRollback")]
        [Validation(Required=false)]
        public bool? DisableRollback { get; set; }

        [NameInMap("ExecutionStatus")]
        [Validation(Required=false)]
        public string ExecutionStatus { get; set; }

        [NameInMap("Log")]
        [Validation(Required=false)]
        public GetChangeSetResponseBodyLog Log { get; set; }
        public class GetChangeSetResponseBodyLog : TeaModel {
            [NameInMap("TerraformLogs")]
            [Validation(Required=false)]
            public List<GetChangeSetResponseBodyLogTerraformLogs> TerraformLogs { get; set; }
            public class GetChangeSetResponseBodyLogTerraformLogs : TeaModel {
                [NameInMap("Command")]
                [Validation(Required=false)]
                public string Command { get; set; }

                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                [NameInMap("Stream")]
                [Validation(Required=false)]
                public string Stream { get; set; }

            }

        }

        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public List<GetChangeSetResponseBodyParameters> Parameters { get; set; }
        public class GetChangeSetResponseBodyParameters : TeaModel {
            [NameInMap("ParameterKey")]
            [Validation(Required=false)]
            public string ParameterKey { get; set; }

            [NameInMap("ParameterValue")]
            [Validation(Required=false)]
            public string ParameterValue { get; set; }

        }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StackId")]
        [Validation(Required=false)]
        public string StackId { get; set; }

        [NameInMap("StackName")]
        [Validation(Required=false)]
        public string StackName { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("StatusReason")]
        [Validation(Required=false)]
        public string StatusReason { get; set; }

        [NameInMap("TemplateBody")]
        [Validation(Required=false)]
        public string TemplateBody { get; set; }

        [NameInMap("TimeoutInMinutes")]
        [Validation(Required=false)]
        public int? TimeoutInMinutes { get; set; }

    }

}
