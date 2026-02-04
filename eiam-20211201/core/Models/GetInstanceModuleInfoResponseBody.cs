// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class GetInstanceModuleInfoResponseBody : TeaModel {
        [NameInMap("Module")]
        [Validation(Required=false)]
        public GetInstanceModuleInfoResponseBodyModule Module { get; set; }
        public class GetInstanceModuleInfoResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>二级模块信息</para>
            /// </summary>
            [NameInMap("Features")]
            [Validation(Required=false)]
            public List<GetInstanceModuleInfoResponseBodyModuleFeatures> Features { get; set; }
            public class GetInstanceModuleInfoResponseBodyModuleFeatures : TeaModel {
                /// <summary>
                /// <para>二级模块标识</para>
                /// 
                /// <b>Example:</b>
                /// <para>urn:alibaba:idaas:license:module:application:standard:oidc</para>
                /// </summary>
                [NameInMap("FeatureKey")]
                [Validation(Required=false)]
                public string FeatureKey { get; set; }

                /// <summary>
                /// <para>二级模块状态</para>
                /// 
                /// <b>Example:</b>
                /// <para>enabled</para>
                /// </summary>
                [NameInMap("FeatureStatus")]
                [Validation(Required=false)]
                public string FeatureStatus { get; set; }

            }

            /// <summary>
            /// <para>模块状态</para>
            /// 
            /// <b>Example:</b>
            /// <para>urn:alibaba:idaas:license:module:application</para>
            /// </summary>
            [NameInMap("ModuleKey")]
            [Validation(Required=false)]
            public string ModuleKey { get; set; }

            /// <summary>
            /// <para>一级模块状态</para>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("ModuleStatus")]
            [Validation(Required=false)]
            public string ModuleStatus { get; set; }

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
