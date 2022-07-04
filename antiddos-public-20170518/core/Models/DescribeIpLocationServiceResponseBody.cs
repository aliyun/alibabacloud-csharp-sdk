// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Antiddos_public20170518.Models
{
    public class DescribeIpLocationServiceResponseBody : TeaModel {
        /// <summary>
        /// instance model
        /// </summary>
        [NameInMap("Instance")]
        [Validation(Required=false)]
        public DescribeIpLocationServiceResponseBodyInstance Instance { get; set; }
        public class DescribeIpLocationServiceResponseBodyInstance : TeaModel {
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }
            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }
        };

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
