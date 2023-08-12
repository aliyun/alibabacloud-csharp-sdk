// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class UpdateTimingSyntheticTaskRequest : TeaModel {
        [NameInMap("AvailableAssertions")]
        [Validation(Required=false)]
        public List<UpdateTimingSyntheticTaskRequestAvailableAssertions> AvailableAssertions { get; set; }
        public class UpdateTimingSyntheticTaskRequestAvailableAssertions : TeaModel {
            [NameInMap("Expect")]
            [Validation(Required=false)]
            public string Expect { get; set; }

            [NameInMap("Operator")]
            [Validation(Required=false)]
            public string Operator { get; set; }

            [NameInMap("Target")]
            [Validation(Required=false)]
            public string Target { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("CommonSetting")]
        [Validation(Required=false)]
        public UpdateTimingSyntheticTaskRequestCommonSetting CommonSetting { get; set; }
        public class UpdateTimingSyntheticTaskRequestCommonSetting : TeaModel {
            [NameInMap("CustomHost")]
            [Validation(Required=false)]
            public UpdateTimingSyntheticTaskRequestCommonSettingCustomHost CustomHost { get; set; }
            public class UpdateTimingSyntheticTaskRequestCommonSettingCustomHost : TeaModel {
                [NameInMap("Hosts")]
                [Validation(Required=false)]
                public List<UpdateTimingSyntheticTaskRequestCommonSettingCustomHostHosts> Hosts { get; set; }
                public class UpdateTimingSyntheticTaskRequestCommonSettingCustomHostHosts : TeaModel {
                    [NameInMap("Domain")]
                    [Validation(Required=false)]
                    public string Domain { get; set; }

                    [NameInMap("IpType")]
                    [Validation(Required=false)]
                    public int? IpType { get; set; }

                    [NameInMap("Ips")]
                    [Validation(Required=false)]
                    public List<string> Ips { get; set; }

                }

                [NameInMap("SelectType")]
                [Validation(Required=false)]
                public int? SelectType { get; set; }

            }

            [NameInMap("IpType")]
            [Validation(Required=false)]
            public int? IpType { get; set; }

            [NameInMap("MonitorSamples")]
            [Validation(Required=false)]
            public int? MonitorSamples { get; set; }

        }

        [NameInMap("CustomPeriod")]
        [Validation(Required=false)]
        public UpdateTimingSyntheticTaskRequestCustomPeriod CustomPeriod { get; set; }
        public class UpdateTimingSyntheticTaskRequestCustomPeriod : TeaModel {
            [NameInMap("EndHour")]
            [Validation(Required=false)]
            public int? EndHour { get; set; }

            [NameInMap("StartHour")]
            [Validation(Required=false)]
            public int? StartHour { get; set; }

        }

        [NameInMap("Frequency")]
        [Validation(Required=false)]
        public string Frequency { get; set; }

        [NameInMap("MonitorCategory")]
        [Validation(Required=false)]
        public int? MonitorCategory { get; set; }

        [NameInMap("MonitorConf")]
        [Validation(Required=false)]
        public UpdateTimingSyntheticTaskRequestMonitorConf MonitorConf { get; set; }
        public class UpdateTimingSyntheticTaskRequestMonitorConf : TeaModel {
            [NameInMap("ApiHTTP")]
            [Validation(Required=false)]
            public UpdateTimingSyntheticTaskRequestMonitorConfApiHTTP ApiHTTP { get; set; }
            public class UpdateTimingSyntheticTaskRequestMonitorConfApiHTTP : TeaModel {
                [NameInMap("ConnectTimeout")]
                [Validation(Required=false)]
                public long? ConnectTimeout { get; set; }

                [NameInMap("Method")]
                [Validation(Required=false)]
                public string Method { get; set; }

                [NameInMap("RequestBody")]
                [Validation(Required=false)]
                public UpdateTimingSyntheticTaskRequestMonitorConfApiHTTPRequestBody RequestBody { get; set; }
                public class UpdateTimingSyntheticTaskRequestMonitorConfApiHTTPRequestBody : TeaModel {
                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                [NameInMap("RequestHeaders")]
                [Validation(Required=false)]
                public Dictionary<string, string> RequestHeaders { get; set; }

                [NameInMap("TargetUrl")]
                [Validation(Required=false)]
                public string TargetUrl { get; set; }

                [NameInMap("Timeout")]
                [Validation(Required=false)]
                public long? Timeout { get; set; }

            }

            [NameInMap("FileDownload")]
            [Validation(Required=false)]
            public UpdateTimingSyntheticTaskRequestMonitorConfFileDownload FileDownload { get; set; }
            public class UpdateTimingSyntheticTaskRequestMonitorConfFileDownload : TeaModel {
                [NameInMap("ConnectionTimeout")]
                [Validation(Required=false)]
                public long? ConnectionTimeout { get; set; }

                [NameInMap("CustomHeaderContent")]
                [Validation(Required=false)]
                public Dictionary<string, string> CustomHeaderContent { get; set; }

                [NameInMap("DownloadKernel")]
                [Validation(Required=false)]
                public int? DownloadKernel { get; set; }

                [NameInMap("IgnoreCertificateAuthError")]
                [Validation(Required=false)]
                public int? IgnoreCertificateAuthError { get; set; }

                [NameInMap("IgnoreCertificateCanceledError")]
                [Validation(Required=false)]
                public int? IgnoreCertificateCanceledError { get; set; }

                [NameInMap("IgnoreCertificateOutOfDateError")]
                [Validation(Required=false)]
                public int? IgnoreCertificateOutOfDateError { get; set; }

                [NameInMap("IgnoreCertificateStatusError")]
                [Validation(Required=false)]
                public int? IgnoreCertificateStatusError { get; set; }

                [NameInMap("IgnoreCertificateUntrustworthyError")]
                [Validation(Required=false)]
                public int? IgnoreCertificateUntrustworthyError { get; set; }

                [NameInMap("IgnoreCertificateUsingError")]
                [Validation(Required=false)]
                public int? IgnoreCertificateUsingError { get; set; }

                [NameInMap("IgnoreInvalidHostError")]
                [Validation(Required=false)]
                public int? IgnoreInvalidHostError { get; set; }

                [NameInMap("MonitorTimeout")]
                [Validation(Required=false)]
                public long? MonitorTimeout { get; set; }

                [NameInMap("QuickProtocol")]
                [Validation(Required=false)]
                public int? QuickProtocol { get; set; }

                [NameInMap("Redirection")]
                [Validation(Required=false)]
                public int? Redirection { get; set; }

                [NameInMap("TargetUrl")]
                [Validation(Required=false)]
                public string TargetUrl { get; set; }

                [NameInMap("TransmissionSize")]
                [Validation(Required=false)]
                public long? TransmissionSize { get; set; }

            }

            [NameInMap("NetDNS")]
            [Validation(Required=false)]
            public UpdateTimingSyntheticTaskRequestMonitorConfNetDNS NetDNS { get; set; }
            public class UpdateTimingSyntheticTaskRequestMonitorConfNetDNS : TeaModel {
                [NameInMap("Dig")]
                [Validation(Required=false)]
                public int? Dig { get; set; }

                [NameInMap("DnsServerIpType")]
                [Validation(Required=false)]
                public int? DnsServerIpType { get; set; }

                [NameInMap("NsServer")]
                [Validation(Required=false)]
                public string NsServer { get; set; }

                [NameInMap("QueryMethod")]
                [Validation(Required=false)]
                public int? QueryMethod { get; set; }

                [NameInMap("TargetUrl")]
                [Validation(Required=false)]
                public string TargetUrl { get; set; }

                [NameInMap("Timeout")]
                [Validation(Required=false)]
                public long? Timeout { get; set; }

            }

            [NameInMap("NetICMP")]
            [Validation(Required=false)]
            public UpdateTimingSyntheticTaskRequestMonitorConfNetICMP NetICMP { get; set; }
            public class UpdateTimingSyntheticTaskRequestMonitorConfNetICMP : TeaModel {
                [NameInMap("Interval")]
                [Validation(Required=false)]
                public long? Interval { get; set; }

                [NameInMap("PackageNum")]
                [Validation(Required=false)]
                public int? PackageNum { get; set; }

                [NameInMap("PackageSize")]
                [Validation(Required=false)]
                public int? PackageSize { get; set; }

                [NameInMap("SplitPackage")]
                [Validation(Required=false)]
                public bool? SplitPackage { get; set; }

                [NameInMap("TargetUrl")]
                [Validation(Required=false)]
                public string TargetUrl { get; set; }

                [NameInMap("Timeout")]
                [Validation(Required=false)]
                public long? Timeout { get; set; }

                [NameInMap("TracertEnable")]
                [Validation(Required=false)]
                public bool? TracertEnable { get; set; }

                [NameInMap("TracertNumMax")]
                [Validation(Required=false)]
                public int? TracertNumMax { get; set; }

                [NameInMap("TracertTimeout")]
                [Validation(Required=false)]
                public long? TracertTimeout { get; set; }

            }

            [NameInMap("NetTCP")]
            [Validation(Required=false)]
            public UpdateTimingSyntheticTaskRequestMonitorConfNetTCP NetTCP { get; set; }
            public class UpdateTimingSyntheticTaskRequestMonitorConfNetTCP : TeaModel {
                [NameInMap("ConnectTimes")]
                [Validation(Required=false)]
                public int? ConnectTimes { get; set; }

                [NameInMap("Interval")]
                [Validation(Required=false)]
                public long? Interval { get; set; }

                [NameInMap("TargetUrl")]
                [Validation(Required=false)]
                public string TargetUrl { get; set; }

                [NameInMap("Timeout")]
                [Validation(Required=false)]
                public long? Timeout { get; set; }

                [NameInMap("TracertEnable")]
                [Validation(Required=false)]
                public bool? TracertEnable { get; set; }

                [NameInMap("TracertNumMax")]
                [Validation(Required=false)]
                public int? TracertNumMax { get; set; }

                [NameInMap("TracertTimeout")]
                [Validation(Required=false)]
                public long? TracertTimeout { get; set; }

            }

            [NameInMap("Website")]
            [Validation(Required=false)]
            public UpdateTimingSyntheticTaskRequestMonitorConfWebsite Website { get; set; }
            public class UpdateTimingSyntheticTaskRequestMonitorConfWebsite : TeaModel {
                [NameInMap("AutomaticScrolling")]
                [Validation(Required=false)]
                public int? AutomaticScrolling { get; set; }

                [NameInMap("CustomHeader")]
                [Validation(Required=false)]
                public int? CustomHeader { get; set; }

                [NameInMap("CustomHeaderContent")]
                [Validation(Required=false)]
                public Dictionary<string, string> CustomHeaderContent { get; set; }

                [NameInMap("DisableCache")]
                [Validation(Required=false)]
                public int? DisableCache { get; set; }

                [NameInMap("DisableCompression")]
                [Validation(Required=false)]
                public int? DisableCompression { get; set; }

                [NameInMap("FilterInvalidIP")]
                [Validation(Required=false)]
                public int? FilterInvalidIP { get; set; }

                [NameInMap("IgnoreCertificateError")]
                [Validation(Required=false)]
                public int? IgnoreCertificateError { get; set; }

                [NameInMap("MonitorTimeout")]
                [Validation(Required=false)]
                public long? MonitorTimeout { get; set; }

                [NameInMap("Redirection")]
                [Validation(Required=false)]
                public int? Redirection { get; set; }

                [NameInMap("SlowElementThreshold")]
                [Validation(Required=false)]
                public long? SlowElementThreshold { get; set; }

                [NameInMap("TargetUrl")]
                [Validation(Required=false)]
                public string TargetUrl { get; set; }

                [NameInMap("WaitCompletionTime")]
                [Validation(Required=false)]
                public long? WaitCompletionTime { get; set; }

            }

        }

        [NameInMap("Monitors")]
        [Validation(Required=false)]
        public List<UpdateTimingSyntheticTaskRequestMonitors> Monitors { get; set; }
        public class UpdateTimingSyntheticTaskRequestMonitors : TeaModel {
            [NameInMap("CityCode")]
            [Validation(Required=false)]
            public string CityCode { get; set; }

            [NameInMap("ClientType")]
            [Validation(Required=false)]
            public int? ClientType { get; set; }

            [NameInMap("OperatorCode")]
            [Validation(Required=false)]
            public string OperatorCode { get; set; }

        }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<UpdateTimingSyntheticTaskRequestTags> Tags { get; set; }
        public class UpdateTimingSyntheticTaskRequestTags : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public int? TaskType { get; set; }

    }

}
