// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20201002.Models
{
    public class DescribeOfficeSitesResponseBody : TeaModel {
        [NameInMap("OfficeSites")]
        [Validation(Required=false)]
        public List<DescribeOfficeSitesResponseBodyOfficeSites> OfficeSites { get; set; }
        public class DescribeOfficeSitesResponseBodyOfficeSites : TeaModel {
            [NameInMap("DesktopAccessType")]
            [Validation(Required=false)]
            public string DesktopAccessType { get; set; }

            [NameInMap("DesktopVpcEndpoint")]
            [Validation(Required=false)]
            public string DesktopVpcEndpoint { get; set; }

            [NameInMap("OfficeSiteId")]
            [Validation(Required=false)]
            public string OfficeSiteId { get; set; }

            [NameInMap("OfficeSiteType")]
            [Validation(Required=false)]
            public string OfficeSiteType { get; set; }

            [NameInMap("ProviderId")]
            [Validation(Required=false)]
            public string ProviderId { get; set; }

            [NameInMap("SsoServiceUrl")]
            [Validation(Required=false)]
            public string SsoServiceUrl { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
