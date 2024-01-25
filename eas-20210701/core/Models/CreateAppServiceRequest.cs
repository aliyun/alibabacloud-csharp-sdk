// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class CreateAppServiceRequest : TeaModel {
        /// <summary>
        /// The quota ID.
        /// </summary>
        [NameInMap("QuotaId")]
        [Validation(Required=false)]
        public string QuotaId { get; set; }

        /// <summary>
        /// The workspace ID.
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

        /// <summary>
        /// The application service type.
        /// 
        /// Valid values:
        /// 
        /// *   LLM
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// </summary>
        [NameInMap("AppType")]
        [Validation(Required=false)]
        public string AppType { get; set; }

        /// <summary>
        /// The application version.
        /// </summary>
        [NameInMap("AppVersion")]
        [Validation(Required=false)]
        public string AppVersion { get; set; }

        /// <summary>
        /// Additional configurations that are required for the service deployment.
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public Dictionary<string, object> Config { get; set; }

        /// <summary>
        /// The number of instances.
        /// </summary>
        [NameInMap("Replicas")]
        [Validation(Required=false)]
        public int? Replicas { get; set; }

        /// <summary>
        /// The service name.
        /// </summary>
        [NameInMap("ServiceName")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

        /// <summary>
        /// The service specifications.
        /// </summary>
        [NameInMap("ServiceSpec")]
        [Validation(Required=false)]
        public string ServiceSpec { get; set; }

    }

}
