// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNest20210601.Models
{
    public class GetServiceTemplateParameterConstraintsRequest : TeaModel {
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("DeployRegionId")]
        [Validation(Required=false)]
        public string DeployRegionId { get; set; }

        [NameInMap("EnablePrivateVpcConnection")]
        [Validation(Required=false)]
        public bool? EnablePrivateVpcConnection { get; set; }

        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public List<GetServiceTemplateParameterConstraintsRequestParameters> Parameters { get; set; }
        public class GetServiceTemplateParameterConstraintsRequestParameters : TeaModel {
            [NameInMap("ParameterKey")]
            [Validation(Required=false)]
            public string ParameterKey { get; set; }

            [NameInMap("ParameterValue")]
            [Validation(Required=false)]
            public string ParameterValue { get; set; }

        }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ServiceId")]
        [Validation(Required=false)]
        public string ServiceId { get; set; }

        [NameInMap("ServiceInstanceId")]
        [Validation(Required=false)]
        public string ServiceInstanceId { get; set; }

        [NameInMap("ServiceVersion")]
        [Validation(Required=false)]
        public string ServiceVersion { get; set; }

        [NameInMap("SpecificationName")]
        [Validation(Required=false)]
        public string SpecificationName { get; set; }

        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        [NameInMap("TrialType")]
        [Validation(Required=false)]
        public string TrialType { get; set; }

    }

}
