// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryLDCFlowSiteResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Sites")]
        [Validation(Required=false)]
        public List<QueryLDCFlowSiteResponseBodySites> Sites { get; set; }
        public class QueryLDCFlowSiteResponseBodySites : TeaModel {
            [NameInMap("Current")]
            [Validation(Required=false)]
            public bool? Current { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("InterfaceType")]
            [Validation(Required=false)]
            public string InterfaceType { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("SiteType")]
            [Validation(Required=false)]
            public string SiteType { get; set; }

            [NameInMap("InterfaceUrls")]
            [Validation(Required=false)]
            public List<string> InterfaceUrls { get; set; }

            [NameInMap("SiteCells")]
            [Validation(Required=false)]
            public List<QueryLDCFlowSiteResponseBodySitesSiteCells> SiteCells { get; set; }
            public class QueryLDCFlowSiteResponseBodySitesSiteCells : TeaModel {
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                [NameInMap("SiteName")]
                [Validation(Required=false)]
                public string SiteName { get; set; }

            }

        }

    }

}
