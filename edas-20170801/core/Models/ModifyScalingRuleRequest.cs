// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ModifyScalingRuleRequest : TeaModel {
        [NameInMap("AcceptEULA")]
        [Validation(Required=false)]
        public bool? AcceptEULA { get; set; }

        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        [NameInMap("InCondition")]
        [Validation(Required=false)]
        public string InCondition { get; set; }

        [NameInMap("InCpu")]
        [Validation(Required=false)]
        public int? InCpu { get; set; }

        [NameInMap("InDuration")]
        [Validation(Required=false)]
        public int? InDuration { get; set; }

        [NameInMap("InEnable")]
        [Validation(Required=false)]
        public bool? InEnable { get; set; }

        [NameInMap("InInstanceNum")]
        [Validation(Required=false)]
        public int? InInstanceNum { get; set; }

        [NameInMap("InLoad")]
        [Validation(Required=false)]
        public int? InLoad { get; set; }

        [NameInMap("InRT")]
        [Validation(Required=false)]
        public int? InRT { get; set; }

        [NameInMap("InStep")]
        [Validation(Required=false)]
        public int? InStep { get; set; }

        [NameInMap("KeyPairName")]
        [Validation(Required=false)]
        public string KeyPairName { get; set; }

        [NameInMap("MultiAzPolicy")]
        [Validation(Required=false)]
        public string MultiAzPolicy { get; set; }

        [NameInMap("OutCPU")]
        [Validation(Required=false)]
        public int? OutCPU { get; set; }

        [NameInMap("OutCondition")]
        [Validation(Required=false)]
        public string OutCondition { get; set; }

        [NameInMap("OutDuration")]
        [Validation(Required=false)]
        public int? OutDuration { get; set; }

        [NameInMap("OutEnable")]
        [Validation(Required=false)]
        public bool? OutEnable { get; set; }

        [NameInMap("OutInstanceNum")]
        [Validation(Required=false)]
        public int? OutInstanceNum { get; set; }

        [NameInMap("OutLoad")]
        [Validation(Required=false)]
        public int? OutLoad { get; set; }

        [NameInMap("OutRT")]
        [Validation(Required=false)]
        public int? OutRT { get; set; }

        [NameInMap("OutStep")]
        [Validation(Required=false)]
        public int? OutStep { get; set; }

        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        [NameInMap("ResourceFrom")]
        [Validation(Required=false)]
        public string ResourceFrom { get; set; }

        [NameInMap("ScalingPolicy")]
        [Validation(Required=false)]
        public string ScalingPolicy { get; set; }

        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        [NameInMap("TemplateInstanceId")]
        [Validation(Required=false)]
        public string TemplateInstanceId { get; set; }

        [NameInMap("TemplateInstanceName")]
        [Validation(Required=false)]
        public string TemplateInstanceName { get; set; }

        [NameInMap("TemplateVersion")]
        [Validation(Required=false)]
        public int? TemplateVersion { get; set; }

        [NameInMap("VSwitchIds")]
        [Validation(Required=false)]
        public string VSwitchIds { get; set; }

        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
