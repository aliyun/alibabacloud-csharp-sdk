// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListVpcResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The information about VPCs.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The name of the VPC.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the VPC is available. Valid values:
        /// - true: The VPC is available.
        /// - false: The VPC is unavailable.
        /// </summary>
        [NameInMap("VpcList")]
        [Validation(Required=false)]
        public ListVpcResponseBodyVpcList VpcList { get; set; }
        public class ListVpcResponseBodyVpcList : TeaModel {
            [NameInMap("VpcEntity")]
            [Validation(Required=false)]
            public List<ListVpcResponseBodyVpcListVpcEntity> VpcEntity { get; set; }
            public class ListVpcResponseBodyVpcListVpcEntity : TeaModel {
                /// <summary>
                /// This operation uses only common request headers. For more information, see [Common parameters for API calls](~~123488~~).
                /// </summary>
                [NameInMap("EcsNum")]
                [Validation(Required=false)]
                public int? EcsNum { get; set; }

                /// <summary>
                /// The region ID of the VPC.
                /// </summary>
                [NameInMap("Expired")]
                [Validation(Required=false)]
                public bool? Expired { get; set; }

                /// <summary>
                /// No request parameters.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// GET /pop/v5/vpc_list HTTP/1.1
                /// Common request headers
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                /// <summary>
                /// The ID of the Alibaba Cloud account to which the VPC belongs.
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// The number of ECS instances associated with the VPC.
                /// </summary>
                [NameInMap("VpcName")]
                [Validation(Required=false)]
                public string VpcName { get; set; }

            }

        }

    }

}
