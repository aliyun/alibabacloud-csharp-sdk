// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class UpdateEnvServiceMonitorRequest : TeaModel {
        /// <summary>
        /// The language. Valid values: zh and en. Default value: zh.
        /// </summary>
        [NameInMap("AliyunLang")]
        [Validation(Required=false)]
        public string AliyunLang { get; set; }

        /// <summary>
        /// The YAML configuration string.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ConfigYaml")]
        [Validation(Required=false)]
        public string ConfigYaml { get; set; }

        /// <summary>
        /// Specifies whether to perform only a dry run, without performing the actual request.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// The environment ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EnvironmentId")]
        [Validation(Required=false)]
        public string EnvironmentId { get; set; }

        /// <summary>
        /// The namespace where the ServiceMonitor is located.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// The region ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The name of the ServiceMonitor.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ServiceMonitorName")]
        [Validation(Required=false)]
        public string ServiceMonitorName { get; set; }

    }

}
