// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeVpnSslServerLogsRequest : TeaModel {
        /// <summary>
        /// The beginning of the time range to query. The value must be a unix timestamp. For example, 1600738962 specifies 09:42:42 (UTC+8) on September 22, 2020.
        /// 
        /// >  If you specify **From**, you must also specify **To** or **MinutePeriod**.
        /// </summary>
        [NameInMap("From")]
        [Validation(Required=false)]
        public int? From { get; set; }

        /// <summary>
        /// The interval at which log data is queried. Unit: minutes.
        /// 
        /// >  If both **From** and **To** are not specified, you must specify **MinutePeriod**.
        /// </summary>
        [NameInMap("MinutePeriod")]
        [Validation(Required=false)]
        public int? MinutePeriod { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The number of the page to return. Default value: **1**.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Maximum value: **50**. Default value: **10**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the region where the SSL server is created. You can call the [DescribeRegions](~~36063~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The ID of the SSL client certificate.
        /// </summary>
        [NameInMap("SslVpnClientCertId")]
        [Validation(Required=false)]
        public string SslVpnClientCertId { get; set; }

        /// <summary>
        /// The end of the time range to query. The value must be a unix timestamp. For example, 1600738962 specifies 09:42:42 (UTC+8) on September 22, 2020.
        /// 
        /// >  If you specify **To**, you must also specify **From** or **MinutePeriod**.
        /// </summary>
        [NameInMap("To")]
        [Validation(Required=false)]
        public int? To { get; set; }

        /// <summary>
        /// The ID of the SSL server.
        /// </summary>
        [NameInMap("VpnSslServerId")]
        [Validation(Required=false)]
        public string VpnSslServerId { get; set; }

    }

}
