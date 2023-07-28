// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class ModifyMonitorGroupInstancesRequest : TeaModel {
        /// <summary>
        /// The ID of the region where the instance resides. Valid values of N: 1 to 2000.
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public long? GroupId { get; set; }

        [NameInMap("Instances")]
        [Validation(Required=false)]
        public List<ModifyMonitorGroupInstancesRequestInstances> Instances { get; set; }
        public class ModifyMonitorGroupInstancesRequestInstances : TeaModel {
            /// <summary>
            /// The ID of the instance. Valid values of N: 1 to 2000.
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// The name of the instance. Valid values of N: 1 to 2000.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The ID of the application group.
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// The HTTP status code.
            /// 
            /// >  The status code 200 indicates that the call was successful.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
