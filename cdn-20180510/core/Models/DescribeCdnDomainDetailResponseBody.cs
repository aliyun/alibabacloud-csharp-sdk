// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeCdnDomainDetailResponseBody : TeaModel {
        [NameInMap("GetDomainDetailModel")]
        [Validation(Required=false)]
        public DescribeCdnDomainDetailResponseBodyGetDomainDetailModel GetDomainDetailModel { get; set; }
        public class DescribeCdnDomainDetailResponseBodyGetDomainDetailModel : TeaModel {
            [NameInMap("CdnType")]
            [Validation(Required=false)]
            public string CdnType { get; set; }

            [NameInMap("Cname")]
            [Validation(Required=false)]
            public string Cname { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

            [NameInMap("DomainStatus")]
            [Validation(Required=false)]
            public string DomainStatus { get; set; }

            [NameInMap("GmtCreated")]
            [Validation(Required=false)]
            public string GmtCreated { get; set; }

            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            [NameInMap("HttpsCname")]
            [Validation(Required=false)]
            public string HttpsCname { get; set; }

            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            [NameInMap("Scope")]
            [Validation(Required=false)]
            public string Scope { get; set; }

            [NameInMap("ServerCertificateStatus")]
            [Validation(Required=false)]
            public string ServerCertificateStatus { get; set; }

            [NameInMap("SourceModels")]
            [Validation(Required=false)]
            public DescribeCdnDomainDetailResponseBodyGetDomainDetailModelSourceModels SourceModels { get; set; }
            public class DescribeCdnDomainDetailResponseBodyGetDomainDetailModelSourceModels : TeaModel {
                [NameInMap("SourceModel")]
                [Validation(Required=false)]
                public List<DescribeCdnDomainDetailResponseBodyGetDomainDetailModelSourceModelsSourceModel> SourceModel { get; set; }
                public class DescribeCdnDomainDetailResponseBodyGetDomainDetailModelSourceModelsSourceModel : TeaModel {
                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    [NameInMap("Enabled")]
                    [Validation(Required=false)]
                    public string Enabled { get; set; }

                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public int? Port { get; set; }

                    [NameInMap("Priority")]
                    [Validation(Required=false)]
                    public string Priority { get; set; }

                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    [NameInMap("Weight")]
                    [Validation(Required=false)]
                    public string Weight { get; set; }

                }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
