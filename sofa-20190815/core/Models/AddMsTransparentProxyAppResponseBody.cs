// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class AddMsTransparentProxyAppResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public AddMsTransparentProxyAppResponseBodyData Data { get; set; }
        public class AddMsTransparentProxyAppResponseBodyData : TeaModel {
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }
            [NameInMap("RunNum")]
            [Validation(Required=false)]
            public long? RunNum { get; set; }
            [NameInMap("AppConfig")]
            [Validation(Required=false)]
            public AddMsTransparentProxyAppResponseBodyDataAppConfig AppConfig { get; set; }
            public class AddMsTransparentProxyAppResponseBodyDataAppConfig : TeaModel {
                [NameInMap("Blacklist")]
                [Validation(Required=false)]
                public AddMsTransparentProxyAppResponseBodyDataAppConfigBlacklist Blacklist { get; set; }
                public class AddMsTransparentProxyAppResponseBodyDataAppConfigBlacklist : TeaModel {
                    [NameInMap("InBound")]
                    [Validation(Required=false)]
                    public List<AddMsTransparentProxyAppResponseBodyDataAppConfigBlacklistInBound> InBound { get; set; }
                    public class AddMsTransparentProxyAppResponseBodyDataAppConfigBlacklistInBound : TeaModel {
                        public List<AddMsTransparentProxyAppResponseBodyDataAppConfigBlacklistInBoundIpRange> IpRange { get; set; }
                        public class AddMsTransparentProxyAppResponseBodyDataAppConfigBlacklistInBoundIpRange : TeaModel {
                            public string EndIp { get; set; }
                            public string StartIp { get; set; }
                            public long? DefaultValue { get; set; }
                        }
                        public List<AddMsTransparentProxyAppResponseBodyDataAppConfigBlacklistInBoundPortRange> PortRange { get; set; }
                        public class AddMsTransparentProxyAppResponseBodyDataAppConfigBlacklistInBoundPortRange : TeaModel {
                            public long? EndPort { get; set; }
                            public long? StartPort { get; set; }
                            public long? DefaultValue { get; set; }
                        }
                    }
                    [NameInMap("OutBound")]
                    [Validation(Required=false)]
                    public List<AddMsTransparentProxyAppResponseBodyDataAppConfigBlacklistOutBound> OutBound { get; set; }
                    public class AddMsTransparentProxyAppResponseBodyDataAppConfigBlacklistOutBound : TeaModel {
                        public List<AddMsTransparentProxyAppResponseBodyDataAppConfigBlacklistOutBoundIpRange> IpRange { get; set; }
                        public class AddMsTransparentProxyAppResponseBodyDataAppConfigBlacklistOutBoundIpRange : TeaModel {
                            public string EndIp { get; set; }
                            public string StartIp { get; set; }
                            public long? DefaultValue { get; set; }
                        }
                        public List<AddMsTransparentProxyAppResponseBodyDataAppConfigBlacklistOutBoundPortRange> PortRange { get; set; }
                        public class AddMsTransparentProxyAppResponseBodyDataAppConfigBlacklistOutBoundPortRange : TeaModel {
                            public long? EndPort { get; set; }
                            public long? StartPort { get; set; }
                            public long? DefaultValue { get; set; }
                        }
                    }
                };

            }
            [NameInMap("SupportProtocols")]
            [Validation(Required=false)]
            public List<AddMsTransparentProxyAppResponseBodyDataSupportProtocols> SupportProtocols { get; set; }
            public class AddMsTransparentProxyAppResponseBodyDataSupportProtocols : TeaModel {
                public long? MaxReq { get; set; }
                public string Protocol { get; set; }
                public long? Port { get; set; }
            }
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }
            [NameInMap("OpenNum")]
            [Validation(Required=false)]
            public long? OpenNum { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }
            [NameInMap("NodeNum")]
            [Validation(Required=false)]
            public long? NodeNum { get; set; }
        };

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

    }

}
