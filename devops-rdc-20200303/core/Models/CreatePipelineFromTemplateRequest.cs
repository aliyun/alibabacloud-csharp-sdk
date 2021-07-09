// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops_rdc20200303.Models
{
    public class CreatePipelineFromTemplateRequest : TeaModel {
        [NameInMap("OrgId")]
        [Validation(Required=false)]
        public string OrgId { get; set; }

        /// <summary>
        /// 流水线模板的ID，可通过GetPipelineTemplates获取到该信息
        /// </summary>
        [NameInMap("PipelineTemplateId")]
        [Validation(Required=false)]
        public long? PipelineTemplateId { get; set; }

        /// <summary>
        /// 流水线名称
        /// </summary>
        [NameInMap("PipelineName")]
        [Validation(Required=false)]
        public string PipelineName { get; set; }

    }

}
