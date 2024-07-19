// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNest20210601.Models
{
    public class GenerateServicePolicyRequest : TeaModel {
        /// <summary>
        /// The type of operation N for which you want to generate the policy information.
        /// 
        /// Valid values:
        /// 
        /// *   CreateServiceInstance: creates a serviceInstance by calling the CreateServiceInstance operation.
        /// *   UpdateServiceInstance: updates a serviceInstance by calling the UpdateServiceInstance operation.
        /// *   DeleteServiceInstance: deletes a serviceInstance by calling the DeleteServiceInstance operation.
        /// 
        /// >  The default value is the combination of all valid values.
        /// </summary>
        [NameInMap("OperationTypes")]
        [Validation(Required=false)]
        public List<string> OperationTypes { get; set; }

        /// <summary>
        /// The region ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The service ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ServiceId")]
        [Validation(Required=false)]
        public string ServiceId { get; set; }

        /// <summary>
        /// The service version.
        /// </summary>
        [NameInMap("ServiceVersion")]
        [Validation(Required=false)]
        public string ServiceVersion { get; set; }

        /// <summary>
        /// The name of the template.
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// The trial policy. Valid values:
        /// 
        /// *   Trial: Trials are supported.
        /// *   NotTrial: Trials are not supported.
        /// </summary>
        [NameInMap("TrialType")]
        [Validation(Required=false)]
        public string TrialType { get; set; }

    }

}
