// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeSslVpnClientCertsResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of the page to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5BE01CD7-5A50-472D-AC14-CA181C5C03BE</para>
        /// </summary>
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

                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

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

        /// <summary>
        /// <para>The number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
