// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devs20230714.Models
{
    public class EnvironmentStatus : TeaModel {
        [NameInMap("latestEnvironmentDeploymentName")]
        [Validation(Required=false)]
        public string LatestEnvironmentDeploymentName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("observedGeneration")]
        [Validation(Required=false)]
        public long? ObservedGeneration { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2021-11-19T09:34:38Z</para>
        /// </summary>
        [NameInMap("observedTime")]
        [Validation(Required=false)]
        public string ObservedTime { get; set; }

        [NameInMap("servicesInstances")]
        [Validation(Required=false)]
        public Dictionary<string, ServiceInstance> ServicesInstances { get; set; }

        [NameInMap("servicesWithPendingChanges")]
        [Validation(Required=false)]
        public List<string> ServicesWithPendingChanges { get; set; }

    }

}
