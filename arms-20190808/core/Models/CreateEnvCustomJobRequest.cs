// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class CreateEnvCustomJobRequest : TeaModel {
        /// <summary>
        /// Locale: zh | en. 
        /// The default value is zh.
        /// </summary>
        [NameInMap("AliyunLang")]
        [Validation(Required=false)]
        public string AliyunLang { get; set; }

        /// <summary>
        /// Customize the Job\"s yaml configuration string.
        /// </summary>
        [NameInMap("ConfigYaml")]
        [Validation(Required=false)]
        public string ConfigYaml { get; set; }

        /// <summary>
        /// Customize job name.
        /// </summary>
        [NameInMap("CustomJobName")]
        [Validation(Required=false)]
        public string CustomJobName { get; set; }

        /// <summary>
        /// Environment instance ID.
        /// </summary>
        [NameInMap("EnvironmentId")]
        [Validation(Required=false)]
        public string EnvironmentId { get; set; }

        /// <summary>
        /// The region ID.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
