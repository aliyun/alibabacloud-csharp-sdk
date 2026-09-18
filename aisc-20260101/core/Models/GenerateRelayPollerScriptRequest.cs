// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AISC20260101.Models
{
    public class GenerateRelayPollerScriptRequest : TeaModel {
        /// <summary>
        /// <para>The target platform in the &quot;operating system-architecture&quot; format. Only linux-amd64 and linux-arm64 are supported. Compatible architecture values include amd64, x86_64, x86, arm64, and aarch64. If only the architecture is specified, the operating system defaults to linux. Other operating systems such as macOS and Windows return HTTP status code 400. If this parameter is not specified, the default value is linux-amd64.</para>
        /// 
        /// <b>Example:</b>
        /// <para>linux-amd64</para>
        /// </summary>
        [NameInMap("Platform")]
        [Validation(Required=false)]
        public string Platform { get; set; }

        /// <summary>
        /// <para>The unique identifier of the scan target. The target must use the enterprise_relay connection method (see CreateAttackTarget). Otherwise, HTTP status code 400 is returned. If the target does not exist or belongs to another tenant, HTTP status code 400 is returned without exposing whether the resource exists. This parameter is registered as optional but is required in practice.</para>
        /// 
        /// <b>Example:</b>
        /// <para>target-abc123def4567</para>
        /// </summary>
        [NameInMap("TargetId")]
        [Validation(Required=false)]
        public string TargetId { get; set; }

    }

}
