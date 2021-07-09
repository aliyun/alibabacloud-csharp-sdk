// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops_rdc20200303.Models
{
    public class AddCodeupSourceToPipelineRequest : TeaModel {
        [NameInMap("OrgId")]
        [Validation(Required=false)]
        public string OrgId { get; set; }

        /// <summary>
        /// 流水线ID
        /// </summary>
        [NameInMap("PipelineId")]
        [Validation(Required=false)]
        public long? PipelineId { get; set; }

        /// <summary>
        /// Codeup的代码库路径，比如 group1/repo1
        /// </summary>
        [NameInMap("CodePath")]
        [Validation(Required=false)]
        public string CodePath { get; set; }

        /// <summary>
        /// 代码库分支
        /// </summary>
        [NameInMap("CodeBranch")]
        [Validation(Required=false)]
        public string CodeBranch { get; set; }

    }

}
