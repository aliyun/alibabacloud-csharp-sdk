// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class ListInstancesResponseBody : TeaModel {
        /// <summary>
        /// The information about instances.
        /// </summary>
        [NameInMap("instances")]
        [Validation(Required=false)]
        public List<ListInstancesResponseBodyInstances> Instances { get; set; }
        public class ListInstancesResponseBodyInstances : TeaModel {
            /// <summary>
            /// The ID of the instance.
            /// </summary>
            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The version of the service to which the instance belongs. If the instance belongs to the LATEST alias, 0 is returned as the version.
            /// </summary>
            [NameInMap("versionId")]
            [Validation(Required=false)]
            public string VersionId { get; set; }

        }

    }

}
