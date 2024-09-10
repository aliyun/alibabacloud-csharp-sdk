// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class CreateMonitoringAgentProcessRequest : TeaModel {
        /// <summary>
        /// The ID of the instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The name of the process.
        /// </summary>
        [NameInMap("ProcessName")]
        [Validation(Required=false)]
        public string ProcessName { get; set; }

        /// <summary>
        /// The user who launches the process.
        /// </summary>
        [NameInMap("ProcessUser")]
        [Validation(Required=false)]
        public string ProcessUser { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
