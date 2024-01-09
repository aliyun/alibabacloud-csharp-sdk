// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hdr20170925.Models
{
    public class DescribeSummaryResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// -
        /// </summary>
        [NameInMap("DbServerCount")]
        [Validation(Required=false)]
        public long? DbServerCount { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("ReplicationDetails")]
        [Validation(Required=false)]
        public DescribeSummaryResponseBodyReplicationDetails ReplicationDetails { get; set; }
        public class DescribeSummaryResponseBodyReplicationDetails : TeaModel {
            [NameInMap("CriticalServers")]
            [Validation(Required=false)]
            public DescribeSummaryResponseBodyReplicationDetailsCriticalServers CriticalServers { get; set; }
            public class DescribeSummaryResponseBodyReplicationDetailsCriticalServers : TeaModel {
                [NameInMap("criticalServer")]
                [Validation(Required=false)]
                public List<DescribeSummaryResponseBodyReplicationDetailsCriticalServersCriticalServer> CriticalServer { get; set; }
                public class DescribeSummaryResponseBodyReplicationDetailsCriticalServersCriticalServer : TeaModel {
                    [NameInMap("ConnectionStatus")]
                    [Validation(Required=false)]
                    public string ConnectionStatus { get; set; }

                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    /// <summary>
                    /// RPO
                    /// </summary>
                    [NameInMap("Rpo")]
                    [Validation(Required=false)]
                    public long? Rpo { get; set; }

                    [NameInMap("ServerId")]
                    [Validation(Required=false)]
                    public string ServerId { get; set; }

                    [NameInMap("SitePairId")]
                    [Validation(Required=false)]
                    public string SitePairId { get; set; }

                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                }

            }

            [NameInMap("NotApplicableServers")]
            [Validation(Required=false)]
            public DescribeSummaryResponseBodyReplicationDetailsNotApplicableServers NotApplicableServers { get; set; }
            public class DescribeSummaryResponseBodyReplicationDetailsNotApplicableServers : TeaModel {
                [NameInMap("notApplicableServer")]
                [Validation(Required=false)]
                public List<DescribeSummaryResponseBodyReplicationDetailsNotApplicableServersNotApplicableServer> NotApplicableServer { get; set; }
                public class DescribeSummaryResponseBodyReplicationDetailsNotApplicableServersNotApplicableServer : TeaModel {
                    [NameInMap("ConnectionStatus")]
                    [Validation(Required=false)]
                    public string ConnectionStatus { get; set; }

                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    /// <summary>
                    /// RPO
                    /// </summary>
                    [NameInMap("Rpo")]
                    [Validation(Required=false)]
                    public long? Rpo { get; set; }

                    [NameInMap("ServerId")]
                    [Validation(Required=false)]
                    public string ServerId { get; set; }

                    [NameInMap("SitePairId")]
                    [Validation(Required=false)]
                    public string SitePairId { get; set; }

                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                }

            }

            [NameInMap("WarningServers")]
            [Validation(Required=false)]
            public DescribeSummaryResponseBodyReplicationDetailsWarningServers WarningServers { get; set; }
            public class DescribeSummaryResponseBodyReplicationDetailsWarningServers : TeaModel {
                [NameInMap("warningServer")]
                [Validation(Required=false)]
                public List<DescribeSummaryResponseBodyReplicationDetailsWarningServersWarningServer> WarningServer { get; set; }
                public class DescribeSummaryResponseBodyReplicationDetailsWarningServersWarningServer : TeaModel {
                    [NameInMap("ConnectionStatus")]
                    [Validation(Required=false)]
                    public string ConnectionStatus { get; set; }

                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    /// <summary>
                    /// RPO
                    /// </summary>
                    [NameInMap("Rpo")]
                    [Validation(Required=false)]
                    public long? Rpo { get; set; }

                    [NameInMap("ServerId")]
                    [Validation(Required=false)]
                    public string ServerId { get; set; }

                    [NameInMap("SitePairId")]
                    [Validation(Required=false)]
                    public string SitePairId { get; set; }

                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ServerCount")]
        [Validation(Required=false)]
        public long? ServerCount { get; set; }

        [NameInMap("SiteCount")]
        [Validation(Required=false)]
        public long? SiteCount { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TotalSize")]
        [Validation(Required=false)]
        public long? TotalSize { get; set; }

    }

}
