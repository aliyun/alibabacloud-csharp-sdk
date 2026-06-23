// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class CheckInstanceForDeleteResponseBody : TeaModel {
        /// <summary>
        /// <para>The check result.</para>
        /// </summary>
        [NameInMap("CheckInstanceResult")]
        [Validation(Required=false)]
        public CheckInstanceForDeleteResponseBodyCheckInstanceResult CheckInstanceResult { get; set; }
        public class CheckInstanceForDeleteResponseBodyCheckInstanceResult : TeaModel {
            /// <summary>
            /// <para>Indicates whether the instance can be deleted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>True</para>
            /// </summary>
            [NameInMap("Deletable")]
            [Validation(Required=false)]
            public bool? Deletable { get; set; }

            /// <summary>
            /// <para>The restriction information for instances that cannot be deleted.</para>
            /// </summary>
            [NameInMap("RestrictScenarios")]
            [Validation(Required=false)]
            public List<CheckInstanceForDeleteResponseBodyCheckInstanceResultRestrictScenarios> RestrictScenarios { get; set; }
            public class CheckInstanceForDeleteResponseBodyCheckInstanceResultRestrictScenarios : TeaModel {
                /// <summary>
                /// <para>The console URL that provides helpful information.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://console-rpa.aliyun.com/">https://console-rpa.aliyun.com/</a></para>
                /// </summary>
                [NameInMap("HelpfulConsoleUrl")]
                [Validation(Required=false)]
                public string HelpfulConsoleUrl { get; set; }

                /// <summary>
                /// <para>The resource ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>eas-r-nguosqgr75ndg784k8</para>
                /// </summary>
                [NameInMap("ResourceId")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

                /// <summary>
                /// <para>The restriction reason.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cloud_product_dependency</para>
                /// </summary>
                [NameInMap("RestrictReason")]
                [Validation(Required=false)]
                public string RestrictReason { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
