// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class PublishRoutineCodeRevisionRequest : TeaModel {
        /// <summary>
        /// The environment to which you want to publish the code.
        /// 
        /// > 
        /// 
        /// *   production: the name of the environment, including the environment name (SpecName) and the domain name whitelist (AllowedHosts).
        /// 
        /// *   presetCanary: You can add canary release environments based on your business requirements. This parameter is optional.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Envs")]
        [Validation(Required=false)]
        public Dictionary<string, object> Envs { get; set; }

        /// <summary>
        /// The name of the routine. The name must be unique among the routines that belong to the same Alibaba Cloud account.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The version of the routine code that you want to publish.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SelectCodeRevision")]
        [Validation(Required=false)]
        public string SelectCodeRevision { get; set; }

    }

}
