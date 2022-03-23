// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class GatewayOption : TeaModel {
        /// <summary>
        /// 是否禁用http
        /// </summary>
        [NameInMap("DisableHttp2Alpn")]
        [Validation(Required=false)]
        public bool? DisableHttp2Alpn { get; set; }

        /// <summary>
        /// 是否开启硬件加速
        /// </summary>
        [NameInMap("EnableHardwareAcceleration")]
        [Validation(Required=false)]
        public bool? EnableHardwareAcceleration { get; set; }

        /// <summary>
        /// 是否开启waf
        /// </summary>
        [NameInMap("EnableWaf")]
        [Validation(Required=false)]
        public bool? EnableWaf { get; set; }

        /// <summary>
        /// 日志配置详情
        /// </summary>
        [NameInMap("LogConfigDetails")]
        [Validation(Required=false)]
        public GatewayOptionLogConfigDetails LogConfigDetails { get; set; }
        public class GatewayOptionLogConfigDetails : TeaModel {
            [NameInMap("LogEnabled")]
            [Validation(Required=false)]
            public bool? LogEnabled { get; set; }
            [NameInMap("LogStoreName")]
            [Validation(Required=false)]
            public string LogStoreName { get; set; }
            [NameInMap("ProjectName")]
            [Validation(Required=false)]
            public string ProjectName { get; set; }
        };

        /// <summary>
        /// xtrace config option
        /// </summary>
        [NameInMap("TraceDetails")]
        [Validation(Required=false)]
        public GatewayOptionTraceDetails TraceDetails { get; set; }
        public class GatewayOptionTraceDetails : TeaModel {
            [NameInMap("Sample")]
            [Validation(Required=false)]
            public long? Sample { get; set; }
            [NameInMap("TraceEnabled")]
            [Validation(Required=false)]
            public bool? TraceEnabled { get; set; }
        };

    }

}
