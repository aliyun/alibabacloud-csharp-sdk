// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class UpdateSessionInput : TeaModel {
        [NameInMap("allowInternetAccess")]
        [Validation(Required=false)]
        public bool? AllowInternetAccess { get; set; }

        /// <summary>
        /// <para>Specifies whether to save only the file system during auto-pause.</para>
        /// </summary>
        [NameInMap("autoPauseFileSystemOnly")]
        [Validation(Required=false)]
        public bool? AutoPauseFileSystemOnly { get; set; }

        /// <summary>
        /// <para>Specifies whether to disable session ID reuse. Default value: false. A value of false indicates that after a session ID expires, you can continue to send requests with the same session ID, and the system treats it as a new session and binds it to a new instance. A value of true indicates that the session ID cannot be reused after the session expires.</para>
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

        /// <summary>
        /// <para>The JuiceFS mount configuration.</para>
        /// </summary>
        [NameInMap("juiceFsConfig")]
        [Validation(Required=false)]
        public JuiceFsConfig JuiceFsConfig { get; set; }

        /// <summary>
        /// <para>The NAS mount point configuration for the session.</para>
        /// </summary>
        [NameInMap("nasConfig")]
        [Validation(Required=false)]
        public NASConfig NasConfig { get; set; }

        [NameInMap("network")]
        [Validation(Required=false)]
        public UpdateSessionNetworkConfig Network { get; set; }

        /// <summary>
        /// <para>The OSS mount point configuration for the session.</para>
        /// </summary>
        [NameInMap("ossMountConfig")]
        [Validation(Required=false)]
        public OSSMountConfig OssMountConfig { get; set; }

        /// <summary>
        /// <para>The deep sleep retention period in seconds. The minimum value is 600, and the maximum value is determined by the plan configuration. If this parameter is not specified, the original value is retained. The update takes effect upon the next successful pause. This parameter cannot be modified when the session is in the Paused state.</para>
        /// 
        /// <b>Example:</b>
        /// <para>86400</para>
        /// </summary>
        [NameInMap("pausedExpirationSeconds")]
        [Validation(Required=false)]
        public long? PausedExpirationSeconds { get; set; }

        /// <summary>
        /// <para>The PolarFS mount point configuration for the session.</para>
        /// </summary>
        [NameInMap("polarFsConfig")]
        [Validation(Required=false)]
        public PolarFsConfig PolarFsConfig { get; set; }

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
        /// <para>The session time-to-live.</para>
        /// 
        /// <b>Example:</b>
        /// <para>21600</para>
        /// </summary>
        [NameInMap("sessionTTLInSeconds")]
        [Validation(Required=false)]
        public long? SessionTTLInSeconds { get; set; }

        /// <summary>
        /// <para>The retention period for subsequently created user snapshots in seconds. The minimum value is 600, and the maximum value is determined by the plan configuration. If this parameter is not specified, the original value is retained. This update only affects snapshots created after the update, and the expiration time of existing snapshots remains unchanged.</para>
        /// 
        /// <b>Example:</b>
        /// <para>86400</para>
        /// </summary>
        [NameInMap("snapshotExpirationSeconds")]
        [Validation(Required=false)]
        public long? SnapshotExpirationSeconds { get; set; }

    }

}
