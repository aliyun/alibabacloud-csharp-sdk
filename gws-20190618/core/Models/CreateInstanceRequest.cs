// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gws20190618.Models
{
    public class CreateInstanceRequest : TeaModel {
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        [NameInMap("SystemDiskSize")]
        [Validation(Required=false)]
        public int? SystemDiskSize { get; set; }

        [NameInMap("SystemDiskCategory")]
        [Validation(Required=false)]
        public string SystemDiskCategory { get; set; }

        [NameInMap("AllocatePublicAddress")]
        [Validation(Required=false)]
        public string AllocatePublicAddress { get; set; }

        [NameInMap("InternetChargeType")]
        [Validation(Required=false)]
        public string InternetChargeType { get; set; }

        [NameInMap("InternetMaxBandwidthIn")]
        [Validation(Required=false)]
        public int? InternetMaxBandwidthIn { get; set; }

        [NameInMap("InternetMaxBandwidthOut")]
        [Validation(Required=false)]
        public int? InternetMaxBandwidthOut { get; set; }

        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public string AutoRenew { get; set; }

        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        [NameInMap("WorkMode")]
        [Validation(Required=false)]
        public string WorkMode { get; set; }

        [NameInMap("AppList")]
        [Validation(Required=false)]
        public List<CreateInstanceRequestAppList> AppList { get; set; }
        public class CreateInstanceRequestAppList : TeaModel {
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            [NameInMap("AppPath")]
            [Validation(Required=false)]
            public string AppPath { get; set; }

            [NameInMap("AppArgs")]
            [Validation(Required=false)]
            public string AppArgs { get; set; }

        }

    }

}
