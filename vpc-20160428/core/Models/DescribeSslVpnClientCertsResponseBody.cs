// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeSslVpnClientCertsResponseBody : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SslVpnClientCertKeys")]
        [Validation(Required=false)]
        public DescribeSslVpnClientCertsResponseBodySslVpnClientCertKeys SslVpnClientCertKeys { get; set; }
        public class DescribeSslVpnClientCertsResponseBodySslVpnClientCertKeys : TeaModel {
            [NameInMap("SslVpnClientCertKey")]
            [Validation(Required=false)]
            public List<DescribeSslVpnClientCertsResponseBodySslVpnClientCertKeysSslVpnClientCertKey> SslVpnClientCertKey { get; set; }
            public class DescribeSslVpnClientCertsResponseBodySslVpnClientCertKeysSslVpnClientCertKey : TeaModel {
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("SslVpnClientCertId")]
                [Validation(Required=false)]
                public string SslVpnClientCertId { get; set; }

                [NameInMap("SslVpnServerId")]
                [Validation(Required=false)]
                public string SslVpnServerId { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
