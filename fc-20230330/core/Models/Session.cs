// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class Session : TeaModel {
        /// <summary>
        /// <para>The instance ID of the function instance associated with the session.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c-68999e02-16a1955c-d2a03d1ccs</para>
        /// </summary>
        [NameInMap("containerId")]
        [Validation(Required=false)]
        public string ContainerId { get; set; }

        /// <summary>
        /// <para>The time when the session was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-04-01T08:15:27Z</para>
        /// </summary>
        [NameInMap("createdTime")]
        [Validation(Required=false)]
        public string CreatedTime { get; set; }

        /// <summary>
        /// <para>Specifies whether to disable session ID reuse. Default value: False, which indicates that after the session expires, you can use the same session ID to initiate requests. The system treats the request as a new session and binds it to a new instance. If you set this parameter to True, the session ID cannot be reused after the session expires.</para>
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
        /// <para>The NAS configuration. After configuration, the instance associated with the session can access the specified NAS resource.</para>
        /// </summary>
        [NameInMap("nasConfig")]
        [Validation(Required=false)]
        public NASConfig NasConfig { get; set; }

        [NameInMap("ossMountConfig")]
        [Validation(Required=false)]
        public OSSMountConfig OssMountConfig { get; set; }

        [NameInMap("polarFsConfig")]
        [Validation(Required=false)]
        public PolarFsConfig PolarFsConfig { get; set; }

        /// <summary>
        /// <para>The qualifier passed in when the customer created the session. If not specified, the default value is LATEST.</para>
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
        /// <para>The idle timeout period of the session.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1800</para>
        /// </summary>
        [NameInMap("sessionIdleTimeoutInSeconds")]
        [Validation(Required=false)]
        public long? SessionIdleTimeoutInSeconds { get; set; }

        /// <summary>
        /// <para>The session status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Active: The session is valid.</description></item>
        /// <item><description>Expired: The session has expired.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Active</para>
        /// </summary>
        [NameInMap("sessionStatus")]
        [Validation(Required=false)]
        public string SessionStatus { get; set; }

        /// <summary>
        /// <para>The maximum lifetime of the session.</para>
        /// 
        /// <b>Example:</b>
        /// <para>21600</para>
        /// </summary>
        [NameInMap("sessionTTLInSeconds")]
        [Validation(Required=false)]
        public long? SessionTTLInSeconds { get; set; }

    }

}
