// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class AddVodDomainRequest : TeaModel {
        /// <summary>
        /// The URL that is used for health checks.
        /// </summary>
        [NameInMap("CheckUrl")]
        [Validation(Required=false)]
        public string CheckUrl { get; set; }

        /// <summary>
        /// The domain name for CDN that you want to add to ApsaraVideo VOD. Wildcard domain names are supported. Start the domain name with a period (.). Example: .example.com.
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// This parameter is applicable to users of level 3 or higher in mainland China and users outside mainland China. Valid values:
        /// 
        /// - **domestic**: mainland China. This is the default value.
        /// - **overseas**: outside mainland China.
        /// - **global**: regions in and outside mainland China.
        /// </summary>
        [NameInMap("Scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// The information about the address of the origin server. For more information about the Sources parameter, see the **Sources** section.
        /// </summary>
        [NameInMap("Sources")]
        [Validation(Required=false)]
        public string Sources { get; set; }

        /// <summary>
        /// The top-level domain name.
        /// </summary>
        [NameInMap("TopLevelDomain")]
        [Validation(Required=false)]
        public string TopLevelDomain { get; set; }

    }

}
