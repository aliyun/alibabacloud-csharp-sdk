// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class UpdateStackInstancesRequest : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("StackGroupName")]
        [Validation(Required=false)]
        public string StackGroupName { get; set; }

        [NameInMap("AccountIds")]
        [Validation(Required=false)]
        public Dictionary<string, object> AccountIds { get; set; }

        [NameInMap("RegionIds")]
        [Validation(Required=false)]
        public Dictionary<string, object> RegionIds { get; set; }

        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("OperationDescription")]
        [Validation(Required=false)]
        public string OperationDescription { get; set; }

        [NameInMap("OperationPreferences")]
        [Validation(Required=false)]
        public Dictionary<string, object> OperationPreferences { get; set; }

        [NameInMap("TimeoutInMinutes")]
        [Validation(Required=false)]
        public long? TimeoutInMinutes { get; set; }

        [NameInMap("ParameterOverrides")]
        [Validation(Required=false)]
        public List<UpdateStackInstancesRequestParameterOverrides> ParameterOverrides { get; set; }
        public class UpdateStackInstancesRequestParameterOverrides : TeaModel {
            [NameInMap("ParameterKey")]
            [Validation(Required=false)]
            public string ParameterKey { get; set; }

            [NameInMap("ParameterValue")]
            [Validation(Required=false)]
            public string ParameterValue { get; set; }

        }

    }

}
