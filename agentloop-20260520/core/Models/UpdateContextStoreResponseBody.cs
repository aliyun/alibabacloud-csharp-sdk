// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class UpdateContextStoreResponseBody : TeaModel {
        /// <summary>
        /// <para>The configuration properties after updating the runtime recall switch. This block is not returned for other library update operations.</para>
        /// </summary>
        [NameInMap("config")]
        [Validation(Required=false)]
        public UpdateContextStoreResponseBodyConfig Config { get; set; }
        public class UpdateContextStoreResponseBodyConfig : TeaModel {
            /// <summary>
            /// <para>Indicates whether runtime recall is allowed after the experience library is updated.</para>
            /// </summary>
            [NameInMap("runtimeRecallEnabled")]
            [Validation(Required=false)]
            public bool? RuntimeRecallEnabled { get; set; }

            /// <summary>
            /// <para>The runtime recall property version that takes effect after this update.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("runtimeRecallRevision")]
            [Validation(Required=false)]
            public long? RuntimeRecallRevision { get; set; }

        }

        /// <summary>
        /// <para>The request ID. You can use this ID to locate the request when troubleshooting issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9ACFB10A-1B2C-3D4E-5F6G-7H8I9J0K1L2M</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The strategy version number that takes effect after the update for the memory type. If the strategy remains unchanged, the version number is the same as before the update.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("strategyVersion")]
        [Validation(Required=false)]
        public int? StrategyVersion { get; set; }

    }

}
