// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class UpdateStackInstancesShrinkRequest : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=true)]
        public string RegionId { get; set; }

        [NameInMap("StackGroupName")]
        [Validation(Required=true)]
        public string StackGroupName { get; set; }

        [NameInMap("ParameterOverrides")]
        [Validation(Required=false)]
        public List<UpdateStackInstancesShrinkRequestParameterOverrides> ParameterOverrides { get; set; }
        public class UpdateStackInstancesShrinkRequestParameterOverrides : TeaModel {
            [NameInMap("ParameterValue")]
            [Validation(Required=true)]
            public string ParameterValue { get; set; }

            [NameInMap("ParameterKey")]
            [Validation(Required=true)]
            public string ParameterKey { get; set; }

        }

        [NameInMap("AccountIds")]
        [Validation(Required=true)]
        public string AccountIdsShrink { get; set; }

        [NameInMap("RegionIds")]
        [Validation(Required=true)]
        public string RegionIdsShrink { get; set; }

        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("OperationDescription")]
        [Validation(Required=false)]
        public string OperationDescription { get; set; }

        [NameInMap("OperationPreferences")]
        [Validation(Required=false)]
        public string OperationPreferencesShrink { get; set; }

        [NameInMap("TimeoutInMinutes")]
        [Validation(Required=false)]
        public long? TimeoutInMinutes { get; set; }

    }

}
