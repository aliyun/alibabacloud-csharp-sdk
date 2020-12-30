// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeSslVpnClientCertsResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("SslVpnClientCertKeys")]
        [Validation(Required=false)]
        public DescribeSslVpnClientCertsResponseBodySslVpnClientCertKeys SslVpnClientCertKeys { get; set; }
        public class DescribeSslVpnClientCertsResponseBodySslVpnClientCertKeys : TeaModel {
            [NameInMap("SslVpnClientCertKey")]
            [Validation(Required=false)]
            public List<DescribeSslVpnClientCertsResponseBodySslVpnClientCertKeysSslVpnClientCertKey> SslVpnClientCertKey { get; set; }
            public class DescribeSslVpnClientCertsResponseBodySslVpnClientCertKeysSslVpnClientCertKey : TeaModel {
                public string Status { get; set; }
                public long? EndTime { get; set; }
                public long? CreateTime { get; set; }
                public string SslVpnClientCertId { get; set; }
                public string SslVpnServerId { get; set; }
                public string Name { get; set; }
                public string RegionId { get; set; }
            }
        };

    }

}
