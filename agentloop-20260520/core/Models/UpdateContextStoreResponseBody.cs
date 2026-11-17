// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class UpdateContextStoreResponseBody : TeaModel {
        /// <summary>
        /// <para>The attributes returned after the runtime recall switch is updated. This block is not returned for other library update operations.</para>
        /// </summary>
        [NameInMap("config")]
        [Validation(Required=false)]
        public UpdateContextStoreResponseBodyConfig Config { get; set; }
        public class UpdateContextStoreResponseBodyConfig : TeaModel {
            /// <summary>
            /// <para>Specifies whether runtime recall is allowed after the experience library is updated.</para>
            /// </summary>
            [NameInMap("runtimeRecallEnabled")]
            [Validation(Required=false)]
            public bool? RuntimeRecallEnabled { get; set; }

            /// <summary>
            /// <para>The version of the runtime recall attributes that takes effect after the current update.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("runtimeRecallRevision")]
            [Validation(Required=false)]
            public long? RuntimeRecallRevision { get; set; }

        }

        /// <summary>
        /// <para>The request ID. It is used to locate the request when you troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9ACFB10A-1B2C-3D4E-5F6G-7H8I9J0K1L2M</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The strategy version number that takes effect after the update for the memory type. If the strategy remains unchanged, the version is the same as the one before the update.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("strategyVersion")]
        [Validation(Required=false)]
        public int? StrategyVersion { get; set; }

    }

}
