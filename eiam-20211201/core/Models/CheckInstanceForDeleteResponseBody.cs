// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class CheckInstanceForDeleteResponseBody : TeaModel {
        [NameInMap("CheckInstanceResult")]
        [Validation(Required=false)]
        public CheckInstanceForDeleteResponseBodyCheckInstanceResult CheckInstanceResult { get; set; }
        public class CheckInstanceForDeleteResponseBodyCheckInstanceResult : TeaModel {
            /// <summary>
            /// <para>true表示实例可以被删除；false表示实例不可被删除，具体查看RestrictScenarios属性。</para>
            /// 
            /// <b>Example:</b>
            /// <para>True</para>
            /// </summary>
            [NameInMap("Deletable")]
            [Validation(Required=false)]
            public bool? Deletable { get; set; }

            /// <summary>
            /// <para>true表示实例可以被删除；false表示实例不可被删除，具体查看RestrictScenarios属性。</para>
            /// </summary>
            [NameInMap("RestrictScenarios")]
            [Validation(Required=false)]
            public List<CheckInstanceForDeleteResponseBodyCheckInstanceResultRestrictScenarios> RestrictScenarios { get; set; }
            public class CheckInstanceForDeleteResponseBodyCheckInstanceResultRestrictScenarios : TeaModel {
                /// <summary>
                /// <para>有帮助的控制台地址，可以管理对应的资源，从而解除实例删除限制。可能返回为空，不一定所有的资源ID都有管理地址返回。</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://console-rpa.aliyun.com/">https://console-rpa.aliyun.com/</a></para>
                /// </summary>
                [NameInMap("HelpfulConsoleUrl")]
                [Validation(Required=false)]
                public string HelpfulConsoleUrl { get; set; }

                /// <summary>
                /// <para>导致实例删除受限的资源ID。</para>
                /// 
                /// <b>Example:</b>
                /// <para>eas-r-nguosqgr75ndg784k8</para>
                /// </summary>
                [NameInMap("ResourceId")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

                /// <summary>
                /// <para>针对实例删除受限的原因文字描述。</para>
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
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
