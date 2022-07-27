// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class UpdateStateConfigurationShrinkRequest : TeaModel {
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("ConfigureMode")]
        [Validation(Required=false)]
        public string ConfigureMode { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public string ParametersShrink { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ScheduleExpression")]
        [Validation(Required=false)]
        public string ScheduleExpression { get; set; }

        [NameInMap("ScheduleType")]
        [Validation(Required=false)]
        public string ScheduleType { get; set; }

        [NameInMap("StateConfigurationId")]
        [Validation(Required=false)]
        public string StateConfigurationId { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string TagsShrink { get; set; }

        [NameInMap("Targets")]
        [Validation(Required=false)]
        public string Targets { get; set; }

    }

}
