// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class GetTenantMemoryConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The tenant memory configuration that matches the business combination.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetTenantMemoryConfigResponseBodyData Data { get; set; }
        public class GetTenantMemoryConfigResponseBodyData : TeaModel {
            /// <summary>
            /// <para>This field is not enabled. The current query result does not provide the disable reason. The example is used to illustrate the field status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>N/A (not enabled)</para>
            /// </summary>
            [NameInMap("DisabledReason")]
            [Validation(Required=false)]
            public string DisabledReason { get; set; }

            /// <summary>
            /// <para>This field is not enabled. The current query result does not provide the effective switch of the instance.</para>
            /// </summary>
            [NameInMap("EffectiveEnabled")]
            [Validation(Required=false)]
            public bool? EffectiveEnabled { get; set; }

            /// <summary>
            /// <para>The tenant-level memory switch for the corresponding business combination. A value of <c>true</c> indicates that the switch is enabled, and a value of <c>false</c> indicates that the switch is disabled. This field may be omitted if no switch is configured for the combination.</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>This field is not enabled. The current query result does not provide the instance desired switch.</para>
            /// </summary>
            [NameInMap("InstanceDesiredEnabled")]
            [Validation(Required=false)]
            public bool? InstanceDesiredEnabled { get; set; }

            /// <summary>
            /// <para>This field is not enabled. To obtain the tenant-level configuration switch returned by the current API operation, read the Enabled field.</para>
            /// </summary>
            [NameInMap("TenantEnabled")]
            [Validation(Required=false)]
            public bool? TenantEnabled { get; set; }

        }

        /// <summary>
        /// <para>The unique identifier of the request, which can be used for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>01A1CEEB-CDFF-18F9-B2BF-9997600D****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
