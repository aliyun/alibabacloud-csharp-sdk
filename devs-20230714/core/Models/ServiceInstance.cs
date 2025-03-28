// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devs20230714.Models
{
    public class ServiceInstance : TeaModel {
        [NameInMap("config")]
        [Validation(Required=false)]
        public ServiceConfig Config { get; set; }

        [NameInMap("latestDeployment")]
        [Validation(Required=false)]
        public ServiceInstanceLatestDeployment LatestDeployment { get; set; }
        public class ServiceInstanceLatestDeployment : TeaModel {
            [NameInMap("finishedTime")]
            [Validation(Required=false)]
            public string FinishedTime { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("phase")]
            [Validation(Required=false)]
            public string Phase { get; set; }

            [NameInMap("startTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("outputs")]
        [Validation(Required=false)]
        public Dictionary<string, object> Outputs { get; set; }

        [NameInMap("variables")]
        [Validation(Required=false)]
        public Dictionary<string, Variable> Variables { get; set; }

    }

}
