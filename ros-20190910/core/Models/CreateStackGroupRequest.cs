// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class CreateStackGroupRequest : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("StackGroupName")]
        [Validation(Required=false)]
        public string StackGroupName { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("TemplateBody")]
        [Validation(Required=false)]
        public string TemplateBody { get; set; }

        [NameInMap("TemplateURL")]
        [Validation(Required=false)]
        public string TemplateURL { get; set; }

        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("AdministrationRoleName")]
        [Validation(Required=false)]
        public string AdministrationRoleName { get; set; }

        [NameInMap("ExecutionRoleName")]
        [Validation(Required=false)]
        public string ExecutionRoleName { get; set; }

        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        [NameInMap("TemplateVersion")]
        [Validation(Required=false)]
        public string TemplateVersion { get; set; }

        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public List<CreateStackGroupRequestParameters> Parameters { get; set; }
        public class CreateStackGroupRequestParameters : TeaModel {
            [NameInMap("ParameterKey")]
            [Validation(Required=false)]
            public string ParameterKey { get; set; }

            [NameInMap("ParameterValue")]
            [Validation(Required=false)]
            public string ParameterValue { get; set; }

        }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("PermissionModel")]
        [Validation(Required=false)]
        public string PermissionModel { get; set; }

        [NameInMap("AutoDeployment")]
        [Validation(Required=false)]
        public Dictionary<string, object> AutoDeployment { get; set; }

    }

}
