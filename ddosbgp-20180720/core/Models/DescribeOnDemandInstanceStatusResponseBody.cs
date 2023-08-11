// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class DescribeOnDemandInstanceStatusResponseBody : TeaModel {
        /// <summary>
        /// The ID of the Alibaba Cloud account.
        /// </summary>
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public List<DescribeOnDemandInstanceStatusResponseBodyInstances> Instances { get; set; }
        public class DescribeOnDemandInstanceStatusResponseBodyInstances : TeaModel {
            /// <summary>
            /// WB269094
            /// </summary>
            [NameInMap("Declared")]
            [Validation(Required=false)]
            public string Declared { get; set; }

            [NameInMap("Desc")]
            [Validation(Required=false)]
            public string Desc { get; set; }

            /// <summary>
            /// DescribeOnDemandInstanceStatus
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// All Alibaba Cloud API operations must include common request parameters. For more information about common request parameters, see [Common parameters](~~118841~~).
            /// 
            /// For more information about sample requests, see the **"Examples"** section of this topic.
            /// </summary>
            [NameInMap("Mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            [NameInMap("Net")]
            [Validation(Required=false)]
            public string Net { get; set; }

            /// <summary>
            /// DescribeOnDemandInstanceStatus
            /// </summary>
            [NameInMap("RegistedAs")]
            [Validation(Required=false)]
            public string RegistedAs { get; set; }

            /// <summary>
            /// The ID of the request.
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// The CIDR block of the on-demand instance.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
