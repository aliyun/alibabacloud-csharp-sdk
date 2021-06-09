// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class GetListenerAttributeResponseBody : TeaModel {
        /// <summary>
        /// ACL相关配置信息
        /// </summary>
        [NameInMap("AclConfig")]
        [Validation(Required=false)]
        public GetListenerAttributeResponseBodyAclConfig AclConfig { get; set; }
        public class GetListenerAttributeResponseBodyAclConfig : TeaModel {
            [NameInMap("AclRelations")]
            [Validation(Required=false)]
            public List<GetListenerAttributeResponseBodyAclConfigAclRelations> AclRelations { get; set; }
            public class GetListenerAttributeResponseBodyAclConfigAclRelations : TeaModel {
                public string AclId { get; set; }
                public string Status { get; set; }
            }
            [NameInMap("AclType")]
            [Validation(Required=false)]
            public string AclType { get; set; }
        };

        /// <summary>
        /// 监听默认服务器证书列表，N当前取值范围为1
        /// </summary>
        [NameInMap("Certificates")]
        [Validation(Required=false)]
        public List<GetListenerAttributeResponseBodyCertificates> Certificates { get; set; }
        public class GetListenerAttributeResponseBodyCertificates : TeaModel {
            /// <summary>
            /// 正式标识
            /// </summary>
            [NameInMap("CertificateId")]
            [Validation(Required=false)]
            public string CertificateId { get; set; }

        }

        /// <summary>
        /// 是否开启双向认证
        /// </summary>
        [NameInMap("CaEnabled")]
        [Validation(Required=false)]
        public bool? CaEnabled { get; set; }

        /// <summary>
        /// 默认动作
        /// </summary>
        [NameInMap("DefaultActions")]
        [Validation(Required=false)]
        public List<GetListenerAttributeResponseBodyDefaultActions> DefaultActions { get; set; }
        public class GetListenerAttributeResponseBodyDefaultActions : TeaModel {
            /// <summary>
            /// 转发到服务器组
            /// </summary>
            [NameInMap("ForwardGroupConfig")]
            [Validation(Required=false)]
            public GetListenerAttributeResponseBodyDefaultActionsForwardGroupConfig ForwardGroupConfig { get; set; }
            public class GetListenerAttributeResponseBodyDefaultActionsForwardGroupConfig : TeaModel {
                [NameInMap("ServerGroupTuples")]
                [Validation(Required=false)]
                public List<GetListenerAttributeResponseBodyDefaultActionsForwardGroupConfigServerGroupTuples> ServerGroupTuples { get; set; }
                public class GetListenerAttributeResponseBodyDefaultActionsForwardGroupConfigServerGroupTuples : TeaModel {
                    public string ServerGroupId { get; set; }
                }
            };

            /// <summary>
            /// 类型
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

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
        /// 连接空闲超时时间
        /// </summary>
        [NameInMap("IdleTimeout")]
        [Validation(Required=false)]
        public int? IdleTimeout { get; set; }

        /// <summary>
        /// 监听描述
        /// </summary>
        [NameInMap("ListenerDescription")]
        [Validation(Required=false)]
        public string ListenerDescription { get; set; }

        /// <summary>
        /// 监听标识
        /// </summary>
        [NameInMap("ListenerId")]
        [Validation(Required=false)]
        public string ListenerId { get; set; }

        /// <summary>
        /// 监听端口
        /// </summary>
        [NameInMap("ListenerPort")]
        [Validation(Required=false)]
        public int? ListenerPort { get; set; }

        /// <summary>
        /// 监听协议
        /// </summary>
        [NameInMap("ListenerProtocol")]
        [Validation(Required=false)]
        public string ListenerProtocol { get; set; }

        /// <summary>
        /// 监听状态
        /// </summary>
        [NameInMap("ListenerStatus")]
        [Validation(Required=false)]
        public string ListenerStatus { get; set; }

        /// <summary>
        /// 负载均衡标识
        /// </summary>
        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

        /// <summary>
        /// 监听访问日志相关配置
        /// </summary>
        [NameInMap("LogConfig")]
        [Validation(Required=false)]
        public GetListenerAttributeResponseBodyLogConfig LogConfig { get; set; }
        public class GetListenerAttributeResponseBodyLogConfig : TeaModel {
            [NameInMap("AccessLogRecordCustomizedHeadersEnabled")]
            [Validation(Required=false)]
            public bool? AccessLogRecordCustomizedHeadersEnabled { get; set; }
            [NameInMap("AccessLogTracingConfig")]
            [Validation(Required=false)]
            public GetListenerAttributeResponseBodyLogConfigAccessLogTracingConfig AccessLogTracingConfig { get; set; }
            public class GetListenerAttributeResponseBodyLogConfigAccessLogTracingConfig : TeaModel {
                /// <summary>
                /// Xtrace功能状态
                /// </summary>
                [NameInMap("TracingEnabled")]
                [Validation(Required=false)]
                public bool? TracingEnabled { get; set; }

                /// <summary>
                /// Xtrace功能状态
                /// </summary>
                [NameInMap("TracingSample")]
                [Validation(Required=false)]
                public int? TracingSample { get; set; }

                /// <summary>
                /// xtrace的类型
                /// </summary>
                [NameInMap("TracingType")]
                [Validation(Required=false)]
                public string TracingType { get; set; }

            }
        };

        /// <summary>
        /// HTTPS启用QUIC时相关属性
        /// </summary>
        [NameInMap("QuicConfig")]
        [Validation(Required=false)]
        public GetListenerAttributeResponseBodyQuicConfig QuicConfig { get; set; }
        public class GetListenerAttributeResponseBodyQuicConfig : TeaModel {
            [NameInMap("QuicListenerId")]
            [Validation(Required=false)]
            public string QuicListenerId { get; set; }
            [NameInMap("QuicUpgradeEnabled")]
            [Validation(Required=false)]
            public bool? QuicUpgradeEnabled { get; set; }
        };

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 请求超时时间
        /// </summary>
        [NameInMap("RequestTimeout")]
        [Validation(Required=false)]
        public int? RequestTimeout { get; set; }

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
        public GetListenerAttributeResponseBodyXForwardedForConfig XForwardedForConfig { get; set; }
        public class GetListenerAttributeResponseBodyXForwardedForConfig : TeaModel {
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

    }

}
