// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops_rdc20200303.Models
{
    public class UpdatePipelineEnvVarsRequest : TeaModel {
        [NameInMap("OrgId")]
        [Validation(Required=false)]
        public string OrgId { get; set; }

        /// <summary>
        /// 流水线id
        /// </summary>
        [NameInMap("PipelineId")]
        [Validation(Required=false)]
        public long? PipelineId { get; set; }

        /// <summary>
        /// 需要修改的环境变量和默认值，json形式
        /// </summary>
        [NameInMap("EnvVars")]
        [Validation(Required=false)]
        public string EnvVars { get; set; }

    }

}
