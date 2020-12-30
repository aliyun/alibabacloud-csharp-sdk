// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dbs20190306.Models
{
    public class DescribeBackupGatewayListResponseBody : TeaModel {
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("TotalElements")]
        [Validation(Required=false)]
        public int? TotalElements { get; set; }

        [NameInMap("TotalPages")]
        [Validation(Required=false)]
        public int? TotalPages { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeBackupGatewayListResponseBodyItems Items { get; set; }
        public class DescribeBackupGatewayListResponseBodyItems : TeaModel {
            [NameInMap("BackupGateway")]
            [Validation(Required=false)]
            public List<DescribeBackupGatewayListResponseBodyItemsBackupGateway> BackupGateway { get; set; }
            public class DescribeBackupGatewayListResponseBodyItemsBackupGateway : TeaModel {
                public string DisplayName { get; set; }
                public long? BackupGatewayCreateTime { get; set; }
                public string BackupGatewayId { get; set; }
                public string Region { get; set; }
                public string Identifier { get; set; }
                public string SourceEndpointInternetIP { get; set; }
                public string BackupGatewayStatus { get; set; }
                public string SourceEndpointIntranetIP { get; set; }
                public long? LastHeartbeatTime { get; set; }
                public string SourceEndpointHostname { get; set; }
            }
        };

        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

    }

}
