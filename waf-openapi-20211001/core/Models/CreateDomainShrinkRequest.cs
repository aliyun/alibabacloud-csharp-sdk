// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class CreateDomainShrinkRequest : TeaModel {
        /// <summary>
        /// $.parameters[3].schema.properties.ExclusiveIp.description
        /// </summary>
        [NameInMap("AccessType")]
        [Validation(Required=false)]
        public string AccessType { get; set; }

        /// <summary>
        /// $.parameters[3].schema.properties.Http2Enabled.description
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// $.parameters[3].schema.properties.HttpPorts.enumValueTitles
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// $.parameters[3].schema.properties.Http2Enabled.example
        /// </summary>
        [NameInMap("Listen")]
        [Validation(Required=false)]
        public string ListenShrink { get; set; }

        /// <summary>
        /// $.parameters[3].schema.properties.CustomCiphers.enumValueTitles
        /// </summary>
        [NameInMap("Redirect")]
        [Validation(Required=false)]
        public string RedirectShrink { get; set; }

        /// <summary>
        /// $.parameters[3].schema.properties.ProtectionResource.enumValueTitles
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceManagerResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceManagerResourceGroupId { get; set; }

        /// <summary>
        /// $.parameters[3].schema.properties.ExclusiveIp.example
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

    }

}
