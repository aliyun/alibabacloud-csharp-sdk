// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops_rdc20200303.Models
{
    public class ListPipelinesRequest : TeaModel {
        [NameInMap("OrgId")]
        [Validation(Required=false)]
        public string OrgId { get; set; }

        [NameInMap("PipelineName")]
        [Validation(Required=false)]
        public string PipelineName { get; set; }

        [NameInMap("Creators")]
        [Validation(Required=false)]
        public string Creators { get; set; }

        [NameInMap("Operators")]
        [Validation(Required=false)]
        public string Operators { get; set; }

        [NameInMap("ResultStatusList")]
        [Validation(Required=false)]
        public string ResultStatusList { get; set; }

        [NameInMap("CreateStartTime")]
        [Validation(Required=false)]
        public string CreateStartTime { get; set; }

        [NameInMap("CreateEndTime")]
        [Validation(Required=false)]
        public string CreateEndTime { get; set; }

        [NameInMap("ExecuteStartTime")]
        [Validation(Required=false)]
        public string ExecuteStartTime { get; set; }

        [NameInMap("ExecuteEndTime")]
        [Validation(Required=false)]
        public string ExecuteEndTime { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PageStart")]
        [Validation(Required=false)]
        public int? PageStart { get; set; }

        [NameInMap("UserPk")]
        [Validation(Required=false)]
        public string UserPk { get; set; }

    }

}
