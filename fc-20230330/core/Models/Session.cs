// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class Session : TeaModel {
        /// <summary>
        /// <para>The ID of the function instance associated with the session.</para>
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
        /// <para>Specifies whether an expired session ID can be reused. If <c>true</c>, an expired session ID cannot be reused. If <c>false</c> (the default), sending a request with an expired session ID creates a new session bound to a new instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("disableSessionIdReuse")]
        [Validation(Required=false)]
        public bool? DisableSessionIdReuse { get; set; }

        /// <summary>
        /// <para>The name of the function associated with the session.</para>
        /// 
        /// <b>Example:</b>
        /// <para>functionName1</para>
        /// </summary>
        [NameInMap("functionName")]
        [Validation(Required=false)]
        public string FunctionName { get; set; }

        /// <summary>
        /// <para>The JuiceFS mount configuration, enabling the associated function instance to access specified JuiceFS resources.</para>
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
        /// <para>The NAS configuration, enabling the associated function instance to access specified NAS resources.</para>
        /// </summary>
        [NameInMap("nasConfig")]
        [Validation(Required=false)]
        public NASConfig NasConfig { get; set; }

        /// <summary>
        /// <para>The OSS mount configuration, enabling the associated function instance to access specified OSS resources.</para>
        /// </summary>
        [NameInMap("ossMountConfig")]
        [Validation(Required=false)]
        public OSSMountConfig OssMountConfig { get; set; }

        /// <summary>
        /// <para>The PolarFS mount configuration, enabling the associated function instance to access specified PolarFS resources.</para>
        /// </summary>
        [NameInMap("polarFsConfig")]
        [Validation(Required=false)]
        public PolarFsConfig PolarFsConfig { get; set; }

        /// <summary>
        /// <para>The qualifier, which specifies a function version or alias. Defaults to <c>LATEST</c> if unspecified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AliasName1</para>
        /// </summary>
        [NameInMap("qualifier")]
        [Validation(Required=false)]
        public string Qualifier { get; set; }

        /// <summary>
        /// <para>The type of session affinity.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HEADER_FIELD</para>
        /// </summary>
        [NameInMap("sessionAffinityType")]
        [Validation(Required=false)]
        public string SessionAffinityType { get; set; }

        /// <summary>
        /// <para>The unique identifier for the function session.</para>
        /// 
        /// <b>Example:</b>
        /// <para>81f70ae156904eb9b7d43e12f511fe58</para>
        /// </summary>
        [NameInMap("sessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>The maximum duration, in seconds, that the session can be idle before it expires.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1800</para>
        /// </summary>
        [NameInMap("sessionIdleTimeoutInSeconds")]
        [Validation(Required=false)]
        public long? SessionIdleTimeoutInSeconds { get; set; }

        /// <summary>
        /// <para>The status of the session. <c>Active</c> indicates the session is valid, and <c>Expired</c> indicates it is no longer valid.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Active</para>
        /// </summary>
        [NameInMap("sessionStatus")]
        [Validation(Required=false)]
        public string SessionStatus { get; set; }

        /// <summary>
        /// <para>The maximum lifespan of the session, in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>21600</para>
        /// </summary>
        [NameInMap("sessionTTLInSeconds")]
        [Validation(Required=false)]
        public long? SessionTTLInSeconds { get; set; }

    }

}
