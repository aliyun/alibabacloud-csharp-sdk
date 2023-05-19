// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeAvailableMemResourceResponseBody : TeaModel {
        /// <summary>
        /// ```
        /// http(s)://[Endpoint]/?Action=DescribeAvailableMemResource
        /// &InstanceId=ob317v4uif****
        /// &TenantId=ob2mr3oae0****
        /// &UnitNum=2
        /// &CpuNum=14
        /// &Common request parameters
        /// ```
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeAvailableMemResourceResponseBodyData Data { get; set; }
        public class DescribeAvailableMemResourceResponseBodyData : TeaModel {
            [NameInMap("MaxMem")]
            [Validation(Required=false)]
            public long? MaxMem { get; set; }

            /// <summary>
            /// You can call this operation to query the available memory resource of an OceanBase Database tenant.
            /// </summary>
            [NameInMap("MinMem")]
            [Validation(Required=false)]
            public long? MinMem { get; set; }

            [NameInMap("UsedMem")]
            [Validation(Required=false)]
            public long? UsedMem { get; set; }

        }

        /// <summary>
        /// The number of CPU cores.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
