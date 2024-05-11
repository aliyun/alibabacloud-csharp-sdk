// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class CreateEnvCustomJobRequest : TeaModel {
        /// <summary>
        /// The language. Valid values: zh and en. Default value: zh.
        /// </summary>
        [NameInMap("AliyunLang")]
        [Validation(Required=false)]
        public string AliyunLang { get; set; }

        /// <summary>
        /// The YAML configuration string of the custom job.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ConfigYaml")]
        [Validation(Required=false)]
        public string ConfigYaml { get; set; }

        /// <summary>
        /// The name of the custom job.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("CustomJobName")]
        [Validation(Required=false)]
        public string CustomJobName { get; set; }

        /// <summary>
        /// The ID of the environment instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EnvironmentId")]
        [Validation(Required=false)]
        public string EnvironmentId { get; set; }

        /// <summary>
        /// The region ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
