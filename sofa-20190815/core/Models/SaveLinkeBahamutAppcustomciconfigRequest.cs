// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class SaveLinkeBahamutAppcustomciconfigRequest : TeaModel {
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("Branch")]
        [Validation(Required=false)]
        public string Branch { get; set; }

        [NameInMap("Created")]
        [Validation(Required=false)]
        public long? Created { get; set; }

        [NameInMap("Crontab")]
        [Validation(Required=false)]
        public string Crontab { get; set; }

        [NameInMap("Deleted")]
        [Validation(Required=false)]
        public bool? Deleted { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("LastModified")]
        [Validation(Required=false)]
        public long? LastModified { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("PipelineInstanceId")]
        [Validation(Required=false)]
        public long? PipelineInstanceId { get; set; }

        [NameInMap("PipelineTemplateId")]
        [Validation(Required=false)]
        public long? PipelineTemplateId { get; set; }

        [NameInMap("PipelineTemplateName")]
        [Validation(Required=false)]
        public string PipelineTemplateName { get; set; }

        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
