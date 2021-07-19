// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class GetApplicationResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Application")]
        [Validation(Required=false)]
        public GetApplicationResponseBodyApplication Application { get; set; }
        public class GetApplicationResponseBodyApplication : TeaModel {
            [NameInMap("IsSystem")]
            [Validation(Required=false)]
            public string IsSystem { get; set; }
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("UpdatedDate")]
            [Validation(Required=false)]
            public string UpdatedDate { get; set; }
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }
            [NameInMap("CreatedDate")]
            [Validation(Required=false)]
            public string CreatedDate { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("CloudMonitorRule")]
            [Validation(Required=false)]
            public GetApplicationResponseBodyApplicationCloudMonitorRule CloudMonitorRule { get; set; }
            public class GetApplicationResponseBodyApplicationCloudMonitorRule : TeaModel {
                [NameInMap("EnableSubscribeEvent")]
                [Validation(Required=false)]
                public bool? EnableSubscribeEvent { get; set; }

                [NameInMap("EnableInstallAgent")]
                [Validation(Required=false)]
                public bool? EnableInstallAgent { get; set; }

                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                [NameInMap("ContactGroupList")]
                [Validation(Required=false)]
                public List<string> ContactGroupList { get; set; }

                [NameInMap("TemplateIdList")]
                [Validation(Required=false)]
                public List<int?> TemplateIdList { get; set; }

            }
        };

    }

}
