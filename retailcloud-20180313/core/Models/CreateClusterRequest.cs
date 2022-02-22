// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Retailcloud20180313.Models
{
    public class CreateClusterRequest : TeaModel {
        [NameInMap("BusinessCode")]
        [Validation(Required=false)]
        public string BusinessCode { get; set; }

        [NameInMap("CloudMonitorFlags")]
        [Validation(Required=false)]
        public int? CloudMonitorFlags { get; set; }

        [NameInMap("ClusterEnvType")]
        [Validation(Required=false)]
        public string ClusterEnvType { get; set; }

        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public long? ClusterId { get; set; }

        [NameInMap("ClusterTitle")]
        [Validation(Required=false)]
        public string ClusterTitle { get; set; }

        [NameInMap("ClusterType")]
        [Validation(Required=false)]
        public string ClusterType { get; set; }

        [NameInMap("CreateWithArmsIntegration")]
        [Validation(Required=false)]
        public bool? CreateWithArmsIntegration { get; set; }

        [NameInMap("CreateWithLogIntegration")]
        [Validation(Required=false)]
        public bool? CreateWithLogIntegration { get; set; }

        [NameInMap("KeyPair")]
        [Validation(Required=false)]
        public string KeyPair { get; set; }

        [NameInMap("NetPlug")]
        [Validation(Required=false)]
        public string NetPlug { get; set; }

        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        [NameInMap("PodCIDR")]
        [Validation(Required=false)]
        public string PodCIDR { get; set; }

        [NameInMap("PrivateZone")]
        [Validation(Required=false)]
        public bool? PrivateZone { get; set; }

        [NameInMap("PublicSlb")]
        [Validation(Required=false)]
        public int? PublicSlb { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("RegionName")]
        [Validation(Required=false)]
        public string RegionName { get; set; }

        [NameInMap("ServiceCIDR")]
        [Validation(Required=false)]
        public string ServiceCIDR { get; set; }

        [NameInMap("SnatEntry")]
        [Validation(Required=false)]
        public int? SnatEntry { get; set; }

        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        [NameInMap("Vswitchids")]
        [Validation(Required=false)]
        public List<string> Vswitchids { get; set; }

    }

}
