// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class CreateListenerRequest : TeaModel {
        /// <summary>
        /// 负载均衡标识
        /// </summary>
        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

        /// <summary>
        /// 幂等标识
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        ///  是否只预检此次请求
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// 监听协议
        /// </summary>
        [NameInMap("ListenerProtocol")]
        [Validation(Required=false)]
        public string ListenerProtocol { get; set; }

        /// <summary>
        /// 监听端口
        /// </summary>
        [NameInMap("ListenerPort")]
        [Validation(Required=false)]
        public int? ListenerPort { get; set; }

        /// <summary>
        /// 监听描述
        /// </summary>
        [NameInMap("ListenerDescription")]
        [Validation(Required=false)]
        public string ListenerDescription { get; set; }

        /// <summary>
        /// 请求超时时间
        /// </summary>
        [NameInMap("RequestTimeout")]
        [Validation(Required=false)]
        public int? RequestTimeout { get; set; }

        /// <summary>
        /// 连接空闲超时时间
        /// </summary>
        [NameInMap("IdleTimeout")]
        [Validation(Required=false)]
        public int? IdleTimeout { get; set; }

        /// <summary>
        /// 是否开启Gzip压缩
        /// </summary>
        [NameInMap("GzipEnabled")]
        [Validation(Required=false)]
        public bool? GzipEnabled { get; set; }

        /// <summary>
        /// 是否开启HTTP/2特性
        /// </summary>
        [NameInMap("Http2Enabled")]
        [Validation(Required=false)]
        public bool? Http2Enabled { get; set; }

        /// <summary>
        /// 安全策略
        /// </summary>
        [NameInMap("SecurityPolicyId")]
        [Validation(Required=false)]
        public string SecurityPolicyId { get; set; }

        /// <summary>
        /// XForward字段相关的配置
        /// </summary>
        [NameInMap("XForwardedForConfig")]
        [Validation(Required=false)]
        public CreateListenerRequestXForwardedForConfig XForwardedForConfig { get; set; }
        public class CreateListenerRequestXForwardedForConfig : TeaModel {
            [NameInMap("XForwardedForClientCertClientVerifyAlias")]
            [Validation(Required=false)]
            public string XForwardedForClientCertClientVerifyAlias { get; set; }
            [NameInMap("XForwardedForClientCertClientVerifyEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForClientCertClientVerifyEnabled { get; set; }
            [NameInMap("XForwardedForClientCertFingerprintAlias")]
            [Validation(Required=false)]
            public string XForwardedForClientCertFingerprintAlias { get; set; }
            [NameInMap("XForwardedForClientCertFingerprintEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForClientCertFingerprintEnabled { get; set; }
            [NameInMap("XForwardedForClientCertIssuerDNAlias")]
            [Validation(Required=false)]
            public string XForwardedForClientCertIssuerDNAlias { get; set; }
            [NameInMap("XForwardedForClientCertIssuerDNEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForClientCertIssuerDNEnabled { get; set; }
            [NameInMap("XForwardedForClientCertSubjectDNAlias")]
            [Validation(Required=false)]
            public string XForwardedForClientCertSubjectDNAlias { get; set; }
            [NameInMap("XForwardedForClientCertSubjectDNEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForClientCertSubjectDNEnabled { get; set; }
            [NameInMap("XForwardedForClientSrcPortEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForClientSrcPortEnabled { get; set; }
            [NameInMap("XForwardedForEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForEnabled { get; set; }
            [NameInMap("XForwardedForProtoEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForProtoEnabled { get; set; }
            [NameInMap("XForwardedForSLBIdEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForSLBIdEnabled { get; set; }
            [NameInMap("XForwardedForSLBPortEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForSLBPortEnabled { get; set; }
        };

        /// <summary>
        /// HTTPS启用QUIC时相关属性
        /// </summary>
        [NameInMap("QuicConfig")]
        [Validation(Required=false)]
        public CreateListenerRequestQuicConfig QuicConfig { get; set; }
        public class CreateListenerRequestQuicConfig : TeaModel {
            [NameInMap("QuicListenerId")]
            [Validation(Required=false)]
            public string QuicListenerId { get; set; }
            [NameInMap("QuicUpgradeEnabled")]
            [Validation(Required=false)]
            public bool? QuicUpgradeEnabled { get; set; }
        };

        /// <summary>
        /// 监听默认服务器证书列表，N当前取值范围为1
        /// </summary>
        [NameInMap("Certificates")]
        [Validation(Required=false)]
        public List<CreateListenerRequestCertificates> Certificates { get; set; }
        public class CreateListenerRequestCertificates : TeaModel {
            /// <summary>
            /// 正式标识
            /// </summary>
            [NameInMap("CertificateId")]
            [Validation(Required=false)]
            public string CertificateId { get; set; }

        }

        /// <summary>
        /// 监听默认动作
        /// </summary>
        [NameInMap("DefaultActions")]
        [Validation(Required=false)]
        public List<CreateListenerRequestDefaultActions> DefaultActions { get; set; }
        public class CreateListenerRequestDefaultActions : TeaModel {
            /// <summary>
            /// 转发组
            /// </summary>
            [NameInMap("ForwardGroupConfig")]
            [Validation(Required=false)]
            public CreateListenerRequestDefaultActionsForwardGroupConfig ForwardGroupConfig { get; set; }
            public class CreateListenerRequestDefaultActionsForwardGroupConfig : TeaModel {
                [NameInMap("ServerGroupTuples")]
                [Validation(Required=false)]
                public List<CreateListenerRequestDefaultActionsForwardGroupConfigServerGroupTuples> ServerGroupTuples { get; set; }
                public class CreateListenerRequestDefaultActionsForwardGroupConfigServerGroupTuples : TeaModel {
                    public string ServerGroupId { get; set; }
                }
            };

            /// <summary>
            /// 动作类型
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
