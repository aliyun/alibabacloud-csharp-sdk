// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddi20200617.Models
{
    public class ModifyFlowJobRequest : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("FailAct")]
        [Validation(Required=false)]
        public string FailAct { get; set; }

        [NameInMap("RetryPolicy")]
        [Validation(Required=false)]
        public string RetryPolicy { get; set; }

        [NameInMap("Params")]
        [Validation(Required=false)]
        public string Params { get; set; }

        [NameInMap("ParamConf")]
        [Validation(Required=false)]
        public string ParamConf { get; set; }

        [NameInMap("CustomVariables")]
        [Validation(Required=false)]
        public string CustomVariables { get; set; }

        [NameInMap("EnvConf")]
        [Validation(Required=false)]
        public string EnvConf { get; set; }

        [NameInMap("RunConf")]
        [Validation(Required=false)]
        public string RunConf { get; set; }

        [NameInMap("MonitorConf")]
        [Validation(Required=false)]
        public string MonitorConf { get; set; }

        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("AlertConf")]
        [Validation(Required=false)]
        public string AlertConf { get; set; }

        [NameInMap("ResourceList")]
        [Validation(Required=false)]
        public List<ModifyFlowJobRequestResourceList> ResourceList { get; set; }
        public class ModifyFlowJobRequestResourceList : TeaModel {
            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            [NameInMap("Alias")]
            [Validation(Required=false)]
            public string Alias { get; set; }

        }

    }

}
