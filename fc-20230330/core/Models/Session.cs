// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class Session : TeaModel {
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
        /// <para>The function instance ID associated with the session.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c-68999e02-16a1955c-d2a03d1ccs</para>
        /// </summary>
        [NameInMap("containerId")]
        [Validation(Required=false)]
        public string ContainerId { get; set; }

        /// <summary>
        /// <para>The creation time of the session.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-04-01T08:15:27Z</para>
        /// </summary>
        [NameInMap("createdTime")]
        [Validation(Required=false)]
        public string CreatedTime { get; set; }

        /// <summary>
        /// <para>Specifies whether to disable session ID reuse. Default value: False. A value of False indicates that after a session expires, you can continue to send requests with the same session ID, and the system treats it as a new session and binds it to a new instance. A value of True indicates that after a session expires, the session ID cannot be reused.</para>
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
        /// <para>The name of the function to which the session belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>functionName1</para>
        /// </summary>
        [NameInMap("functionName")]
        [Validation(Required=false)]
        public string FunctionName { get; set; }

        /// <summary>
        /// <para>The JuiceFS mount configuration.</para>
        /// </summary>
        [NameInMap("juiceFsConfig")]
        [Validation(Required=false)]
        public JuiceFsConfig JuiceFsConfig { get; set; }

        /// <summary>
        /// <para>The time when the session was last updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-04-01T18:15:27Z</para>
        /// </summary>
        [NameInMap("lastModifiedTime")]
        [Validation(Required=false)]
        public string LastModifiedTime { get; set; }

        /// <summary>
        /// <para>The NAS configuration. After this configuration is applied, the instance associated with the session can access the specified NAS resources.</para>
        /// </summary>
        [NameInMap("nasConfig")]
        [Validation(Required=false)]
        public NASConfig NasConfig { get; set; }

        [NameInMap("network")]
        [Validation(Required=false)]
        public CreateSessionNetworkConfig Network { get; set; }

        /// <summary>
        /// <para>The OSS mount configuration, which allows the associated function instance to access the specified OSS resources.</para>
        /// </summary>
        [NameInMap("ossMountConfig")]
        [Validation(Required=false)]
        public OSSMountConfig OssMountConfig { get; set; }

        /// <summary>
        /// <para>The deep hibernation retention duration for the saved session, in seconds. The minimum value is 600. The timing starts each time the session successfully enters deep hibernation. If this parameter is not configured, this field may not be returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>600</para>
        /// </summary>
        [NameInMap("pausedExpirationSeconds")]
        [Validation(Required=false)]
        public long? PausedExpirationSeconds { get; set; }

        /// <summary>
        /// <para>The PolarFS mount configuration, which allows the associated function instance to access the specified PolarFS resources.</para>
        /// </summary>
        [NameInMap("polarFsConfig")]
        [Validation(Required=false)]
        public PolarFsConfig PolarFsConfig { get; set; }

        /// <summary>
        /// <para>The qualifier passed by the user when creating the session. If no qualifier is passed, the default value LATEST is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AliasName1</para>
        /// </summary>
        [NameInMap("qualifier")]
        [Validation(Required=false)]
        public string Qualifier { get; set; }

        /// <summary>
        /// <para>The session affinity type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HEADER_FIELD</para>
        /// </summary>
        [NameInMap("sessionAffinityType")]
        [Validation(Required=false)]
        public string SessionAffinityType { get; set; }

        /// <summary>
        /// <para>The unique identifier of the function session.</para>
        /// 
        /// <b>Example:</b>
        /// <para>81f70ae156904eb9b7d43e12f511fe58</para>
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
        /// <para>The session status. Active indicates that the session is valid, and Expired indicates that the session has expired.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Active</para>
        /// </summary>
        [NameInMap("sessionStatus")]
        [Validation(Required=false)]
        public string SessionStatus { get; set; }

        /// <summary>
        /// <para>The maximum session lifetime.</para>
        /// 
        /// <b>Example:</b>
        /// <para>21600</para>
        /// </summary>
        [NameInMap("sessionTTLInSeconds")]
        [Validation(Required=false)]
        public long? SessionTTLInSeconds { get; set; }

        /// <summary>
        /// <para>The retention duration for subsequent user snapshots saved in the session, in seconds. The minimum value is 600. Updating this policy affects only newly created user snapshots and does not modify the expiration time of existing snapshots.</para>
        /// 
        /// <b>Example:</b>
        /// <para>600</para>
        /// </summary>
        [NameInMap("snapshotExpirationSeconds")]
        [Validation(Required=false)]
        public long? SnapshotExpirationSeconds { get; set; }

        [NameInMap("trafficAccessToken")]
        [Validation(Required=false)]
        public string TrafficAccessToken { get; set; }

    }

}
