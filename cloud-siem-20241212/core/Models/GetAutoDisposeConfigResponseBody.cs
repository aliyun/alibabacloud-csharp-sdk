// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class GetAutoDisposeConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The automatic disposal configuration for users.</para>
        /// </summary>
        [NameInMap("AutoDisposeConfig")]
        [Validation(Required=false)]
        public GetAutoDisposeConfigResponseBodyAutoDisposeConfig AutoDisposeConfig { get; set; }
        public class GetAutoDisposeConfigResponseBodyAutoDisposeConfig : TeaModel {
            /// <summary>
            /// <para>The automatic disposal switch. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>enabled: Enabled.</description></item>
            /// <item><description>disabled: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("AutoDecisionStatus")]
            [Validation(Required=false)]
            public string AutoDecisionStatus { get; set; }

            /// <summary>
            /// <para>The code of the cloud service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alibaba_cloud_sas</para>
            /// </summary>
            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>9AAA9ED9-78F4-5021-86DC-D51C7511****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
