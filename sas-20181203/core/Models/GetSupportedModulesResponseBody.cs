// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetSupportedModulesResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The supported modules. The module information is classified by cloud service provider.
        /// </summary>
        [NameInMap("SupportedModuleResponse")]
        [Validation(Required=false)]
        public List<GetSupportedModulesResponseBodySupportedModuleResponse> SupportedModuleResponse { get; set; }
        public class GetSupportedModulesResponseBodySupportedModuleResponse : TeaModel {
            /// <summary>
            /// The modules supported by the cloud service provider.
            /// </summary>
            [NameInMap("SupportedModules")]
            [Validation(Required=false)]
            public List<GetSupportedModulesResponseBodySupportedModuleResponseSupportedModules> SupportedModules { get; set; }
            public class GetSupportedModulesResponseBodySupportedModuleResponseSupportedModules : TeaModel {
                /// <summary>
                /// The code of the module. Valid values:
                /// 
                /// *   **HOST**: host
                /// *   **CSPM**: configuration assessment
                /// *   **SIEM**: CloudSiem
                /// *   **TRIAL**: log audit
                /// </summary>
                [NameInMap("Module")]
                [Validation(Required=false)]
                public string Module { get; set; }

                /// <summary>
                /// The display name of the module.
                /// </summary>
                [NameInMap("ModuleDisp")]
                [Validation(Required=false)]
                public string ModuleDisp { get; set; }

            }

            /// <summary>
            /// The cloud service provider. Valid values:
            /// 
            /// *   **Tencent**: Tencent Cloud
            /// *   **HUAWEICLOUD**:Huawei Cloud
            /// *   **Azure**: Microsoft Azure
            /// *   **AWS**: Amazon Web Services (AWS)
            /// </summary>
            [NameInMap("Vendor")]
            [Validation(Required=false)]
            public string Vendor { get; set; }

        }

    }

}
