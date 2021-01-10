// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryRmsAllAppResourceGroupResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Response")]
        [Validation(Required=false)]
        public QueryRmsAllAppResourceGroupResponseBodyResponse Response { get; set; }
        public class QueryRmsAllAppResourceGroupResponseBodyResponse : TeaModel {
            [NameInMap("Layer")]
            [Validation(Required=false)]
            public string Layer { get; set; }
            [NameInMap("Entity")]
            [Validation(Required=false)]
            public QueryRmsAllAppResourceGroupResponseBodyResponseEntity Entity { get; set; }
            public class QueryRmsAllAppResourceGroupResponseBodyResponseEntity : TeaModel {
                [NameInMap("Apps")]
                [Validation(Required=false)]
                public List<QueryRmsAllAppResourceGroupResponseBodyResponseEntityApps> Apps { get; set; }
                public class QueryRmsAllAppResourceGroupResponseBodyResponseEntityApps : TeaModel {
                    [NameInMap("AppId")]
                    [Validation(Required=false)]
                    public string AppId { get; set; }

                    [NameInMap("ChineseName")]
                    [Validation(Required=false)]
                    public string ChineseName { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                [NameInMap("Domains")]
                [Validation(Required=false)]
                public List<QueryRmsAllAppResourceGroupResponseBodyResponseEntityDomains> Domains { get; set; }
                public class QueryRmsAllAppResourceGroupResponseBodyResponseEntityDomains : TeaModel {
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("AppDatas")]
                    [Validation(Required=false)]
                    public List<QueryRmsAllAppResourceGroupResponseBodyResponseEntityDomainsAppDatas> AppDatas { get; set; }
                    public class QueryRmsAllAppResourceGroupResponseBodyResponseEntityDomainsAppDatas : TeaModel {
                        [NameInMap("AppId")]
                        [Validation(Required=false)]
                        public string AppId { get; set; }

                        [NameInMap("ChineseName")]
                        [Validation(Required=false)]
                        public string ChineseName { get; set; }

                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                    }

                }

            }
        };

    }

}
