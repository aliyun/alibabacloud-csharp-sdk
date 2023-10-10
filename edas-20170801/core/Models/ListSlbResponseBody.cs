// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListSlbResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code that is returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The additional information that is returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The list of SLB instances.
        /// </summary>
        [NameInMap("SlbList")]
        [Validation(Required=false)]
        public ListSlbResponseBodySlbList SlbList { get; set; }
        public class ListSlbResponseBodySlbList : TeaModel {
            [NameInMap("SlbEntity")]
            [Validation(Required=false)]
            public List<ListSlbResponseBodySlbListSlbEntity> SlbEntity { get; set; }
            public class ListSlbResponseBodySlbListSlbEntity : TeaModel {
                /// <summary>
                /// The IP address of the SLB instance.
                /// </summary>
                [NameInMap("Address")]
                [Validation(Required=false)]
                public string Address { get; set; }

                /// <summary>
                /// The type of the IP addresses. Valid values:
                /// 
                /// *   internet: Users can connect to the SLB instance over the Internet.
                /// *   intranet: Users can connect to the SLB instance over the internal network.
                /// </summary>
                [NameInMap("AddressType")]
                [Validation(Required=false)]
                public string AddressType { get; set; }

                /// <summary>
                /// Indicates whether the SLB instance has expired. Valid values:
                /// 
                /// *   true: The SLB instance has expired.
                /// *   false: The SLB instance has not expired.
                /// </summary>
                [NameInMap("Expired")]
                [Validation(Required=false)]
                public bool? Expired { get; set; }

                /// <summary>
                /// The ID of the resource group in Enterprise Distributed Application Service (EDAS).
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public int? GroupId { get; set; }

                /// <summary>
                /// The type of the network.
                /// </summary>
                [NameInMap("NetworkType")]
                [Validation(Required=false)]
                public string NetworkType { get; set; }

                /// <summary>
                /// The ID of the region.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// Indicates whether Kubernetes applications can be reused. Valid values:
                /// 
                /// *   true: Kubernetes applications can be reused.
                /// *   false: Kubernetes applications cannot be reused.
                /// </summary>
                [NameInMap("Reusable")]
                [Validation(Required=false)]
                public bool? Reusable { get; set; }

                /// <summary>
                /// The ID of the SLB instance.
                /// </summary>
                [NameInMap("SlbId")]
                [Validation(Required=false)]
                public string SlbId { get; set; }

                /// <summary>
                /// The name of the SLB instance.
                /// </summary>
                [NameInMap("SlbName")]
                [Validation(Required=false)]
                public string SlbName { get; set; }

                /// <summary>
                /// The status of the SLB instance.
                /// </summary>
                [NameInMap("SlbStatus")]
                [Validation(Required=false)]
                public string SlbStatus { get; set; }

                /// <summary>
                /// The tag of the SLB instance.
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public string Tags { get; set; }

                /// <summary>
                /// The ID of the user.
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                /// <summary>
                /// The ID of the VPC.
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// The ID of the vSwitch in the VPC.
                /// </summary>
                [NameInMap("VswitchId")]
                [Validation(Required=false)]
                public string VswitchId { get; set; }

            }

        }

    }

}
