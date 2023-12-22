// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class CreateInstanceVpcEndpointLinkedVpcRequest : TeaModel {
        /// <summary>
        /// Specifies whether to automatically create Alibaba Cloud DNS PrivateZone records. Valid values:
        /// 
        /// >  If you enable automatic creation of PrivateZone records, a PrivateZone record is automatically created when you associate a VPC with the instance.
        /// 
        /// *   `true`
        /// *   `false`
        /// </summary>
        [NameInMap("EnableCreateDNSRecordInPvzt")]
        [Validation(Required=false)]
        public bool? EnableCreateDNSRecordInPvzt { get; set; }

        /// <summary>
        /// The instance ID.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The name of the module that you want to access. Valid values:
        /// 
        /// *   `Registry`: image repositories.
        /// *   `Chart`: Helm charts.
        /// </summary>
        [NameInMap("ModuleName")]
        [Validation(Required=false)]
        public string ModuleName { get; set; }

        /// <summary>
        /// The VPC ID.
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// The ID of the vSwitch that is associated with the specified VPC.
        /// </summary>
        [NameInMap("VswitchId")]
        [Validation(Required=false)]
        public string VswitchId { get; set; }

    }

}
