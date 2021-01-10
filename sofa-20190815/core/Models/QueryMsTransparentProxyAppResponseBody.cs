// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryMsTransparentProxyAppResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("StartIndex")]
        [Validation(Required=false)]
        public long? StartIndex { get; set; }

        [NameInMap("TotalSize")]
        [Validation(Required=false)]
        public long? TotalSize { get; set; }

        [NameInMap("List")]
        [Validation(Required=false)]
        public List<QueryMsTransparentProxyAppResponseBodyList> List { get; set; }
        public class QueryMsTransparentProxyAppResponseBodyList : TeaModel {
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("NodeNum")]
            [Validation(Required=false)]
            public long? NodeNum { get; set; }

            [NameInMap("OpenNum")]
            [Validation(Required=false)]
            public long? OpenNum { get; set; }

            [NameInMap("RunNum")]
            [Validation(Required=false)]
            public long? RunNum { get; set; }

            [NameInMap("SupportProtocols")]
            [Validation(Required=false)]
            public List<QueryMsTransparentProxyAppResponseBodyListSupportProtocols> SupportProtocols { get; set; }
            public class QueryMsTransparentProxyAppResponseBodyListSupportProtocols : TeaModel {
                [NameInMap("MaxReq")]
                [Validation(Required=false)]
                public long? MaxReq { get; set; }

                [NameInMap("Port")]
                [Validation(Required=false)]
                public long? Port { get; set; }

                [NameInMap("Protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

            }

            [NameInMap("AppConfig")]
            [Validation(Required=false)]
            public QueryMsTransparentProxyAppResponseBodyListAppConfig AppConfig { get; set; }
            public class QueryMsTransparentProxyAppResponseBodyListAppConfig : TeaModel {
                [NameInMap("Blacklist")]
                [Validation(Required=false)]
                public QueryMsTransparentProxyAppResponseBodyListAppConfigBlacklist Blacklist { get; set; }
                public class QueryMsTransparentProxyAppResponseBodyListAppConfigBlacklist : TeaModel {
                    [NameInMap("InBound")]
                    [Validation(Required=false)]
                    public List<QueryMsTransparentProxyAppResponseBodyListAppConfigBlacklistInBound> InBound { get; set; }
                    public class QueryMsTransparentProxyAppResponseBodyListAppConfigBlacklistInBound : TeaModel {
                        [NameInMap("IpRange")]
                        [Validation(Required=false)]
                        public List<QueryMsTransparentProxyAppResponseBodyListAppConfigBlacklistInBoundIpRange> IpRange { get; set; }
                        public class QueryMsTransparentProxyAppResponseBodyListAppConfigBlacklistInBoundIpRange : TeaModel {
                            [NameInMap("DefaultValue")]
                            [Validation(Required=false)]
                            public long? DefaultValue { get; set; }

                            [NameInMap("EndIp")]
                            [Validation(Required=false)]
                            public string EndIp { get; set; }

                            [NameInMap("StartIp")]
                            [Validation(Required=false)]
                            public string StartIp { get; set; }

                        }

                        [NameInMap("PortRange")]
                        [Validation(Required=false)]
                        public List<QueryMsTransparentProxyAppResponseBodyListAppConfigBlacklistInBoundPortRange> PortRange { get; set; }
                        public class QueryMsTransparentProxyAppResponseBodyListAppConfigBlacklistInBoundPortRange : TeaModel {
                            [NameInMap("DefaultValue")]
                            [Validation(Required=false)]
                            public long? DefaultValue { get; set; }

                            [NameInMap("EndPort")]
                            [Validation(Required=false)]
                            public long? EndPort { get; set; }

                            [NameInMap("StartPort")]
                            [Validation(Required=false)]
                            public long? StartPort { get; set; }

                        }

                    }

                    [NameInMap("OutBound")]
                    [Validation(Required=false)]
                    public List<QueryMsTransparentProxyAppResponseBodyListAppConfigBlacklistOutBound> OutBound { get; set; }
                    public class QueryMsTransparentProxyAppResponseBodyListAppConfigBlacklistOutBound : TeaModel {
                        [NameInMap("IpRange")]
                        [Validation(Required=false)]
                        public List<QueryMsTransparentProxyAppResponseBodyListAppConfigBlacklistOutBoundIpRange> IpRange { get; set; }
                        public class QueryMsTransparentProxyAppResponseBodyListAppConfigBlacklistOutBoundIpRange : TeaModel {
                            [NameInMap("DefaultValue")]
                            [Validation(Required=false)]
                            public long? DefaultValue { get; set; }

                            [NameInMap("EndIp")]
                            [Validation(Required=false)]
                            public string EndIp { get; set; }

                            [NameInMap("StartIp")]
                            [Validation(Required=false)]
                            public string StartIp { get; set; }

                        }

                        [NameInMap("PortRange")]
                        [Validation(Required=false)]
                        public List<QueryMsTransparentProxyAppResponseBodyListAppConfigBlacklistOutBoundPortRange> PortRange { get; set; }
                        public class QueryMsTransparentProxyAppResponseBodyListAppConfigBlacklistOutBoundPortRange : TeaModel {
                            [NameInMap("DefaultValue")]
                            [Validation(Required=false)]
                            public long? DefaultValue { get; set; }

                            [NameInMap("EndPort")]
                            [Validation(Required=false)]
                            public long? EndPort { get; set; }

                            [NameInMap("StartPort")]
                            [Validation(Required=false)]
                            public long? StartPort { get; set; }

                        }

                    }

                }
            };

        }

    }

}
