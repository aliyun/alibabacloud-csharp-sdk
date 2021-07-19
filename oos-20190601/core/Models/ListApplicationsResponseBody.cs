// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class ListApplicationsResponseBody : TeaModel {
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("Applications")]
        [Validation(Required=false)]
        public List<ListApplicationsResponseBodyApplications> Applications { get; set; }
        public class ListApplicationsResponseBodyApplications : TeaModel {
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("IsSystem")]
            [Validation(Required=false)]
            public bool? IsSystem { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("UpdateDate")]
            [Validation(Required=false)]
            public string UpdateDate { get; set; }

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
            public ListApplicationsResponseBodyApplicationsCloudMonitorRule CloudMonitorRule { get; set; }
            public class ListApplicationsResponseBodyApplicationsCloudMonitorRule : TeaModel {
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
                public List<string> TemplateIdList { get; set; }
            };

        }

    }

}
