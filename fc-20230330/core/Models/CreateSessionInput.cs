// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class CreateSessionInput : TeaModel {
        [NameInMap("allowInternetAccess")]
        [Validation(Required=false)]
        public bool? AllowInternetAccess { get; set; }

        /// <summary>
        /// <para>Default value: False. This indicates that after a session with a specific SessionID expires, you can send requests with the same SessionID. The system treats it as a new session and binds it to a new instance. If set to True, the SessionID cannot be reused after the session expires.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("disableSessionIdReuse")]
        [Validation(Required=false)]
        public bool? DisableSessionIdReuse { get; set; }

        [NameInMap("enableAutoPause")]
        [Validation(Required=false)]
        public bool? EnableAutoPause { get; set; }

        [NameInMap("enableAutoResume")]
        [Validation(Required=false)]
        public bool? EnableAutoResume { get; set; }

        [NameInMap("juiceFsConfig")]
        [Validation(Required=false)]
        public JuiceFsConfig JuiceFsConfig { get; set; }

        /// <summary>
        /// <para>The NAS configuration. After this parameter is configured, instances associated with the session can access the specified NAS resources.</para>
        /// </summary>
        [NameInMap("nasConfig")]
        [Validation(Required=false)]
        public NASConfig NasConfig { get; set; }

        [NameInMap("network")]
        [Validation(Required=false)]
        public CreateSessionNetworkConfig Network { get; set; }

        /// <summary>
        /// <para>The OSS mount configuration. After this parameter is configured, instances associated with the session can access the specified OSS resources.</para>
        /// </summary>
        [NameInMap("ossMountConfig")]
        [Validation(Required=false)]
        public OSSMountConfig OssMountConfig { get; set; }

        /// <summary>
        /// <para>The PolarFs configuration. After this parameter is configured, instances associated with the session can access the specified PolarFs resources.</para>
        /// </summary>
        [NameInMap("polarFsConfig")]
        [Validation(Required=false)]
        public PolarFsConfig PolarFsConfig { get; set; }

        /// <summary>
        /// <para>The custom session ID. If not specified, the server generates one. If specified, this value is used as the session ID. This parameter applies only to the HEADER_FIELD affinity mode. Format: the length is limited to [0,64]. The first character must be from <b>a-zA-Z0-9_</b>. Subsequent characters can be from <b>a-zA-Z0-9_-</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>custom-test-session-id</para>
        /// </summary>
        [NameInMap("sessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>The session idle timeout.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1800</para>
        /// </summary>
        [NameInMap("sessionIdleTimeoutInSeconds")]
        [Validation(Required=false)]
        public long? SessionIdleTimeoutInSeconds { get; set; }

        /// <summary>
        /// <para>The session lifetime.</para>
        /// 
        /// <b>Example:</b>
        /// <para>21600</para>
        /// </summary>
        [NameInMap("sessionTTLInSeconds")]
        [Validation(Required=false)]
        public long? SessionTTLInSeconds { get; set; }

    }

}
