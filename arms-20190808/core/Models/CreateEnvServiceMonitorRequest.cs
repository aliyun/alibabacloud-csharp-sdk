// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class CreateEnvServiceMonitorRequest : TeaModel {
        /// <summary>
        /// The language. Valid values:
        /// 
        /// *   zh (default): Chinese
        /// *   en: English
        /// </summary>
        [NameInMap("AliyunLang")]
        [Validation(Required=false)]
        public string AliyunLang { get; set; }

        /// <summary>
        /// The YAML configuration file of the ServiceMonitor.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ConfigYaml")]
        [Validation(Required=false)]
        public string ConfigYaml { get; set; }

        /// <summary>
        /// Specifies whether to perform only a dry run, without performing the actual request. The system checks whether the format is valid and whether targets are matched.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

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
