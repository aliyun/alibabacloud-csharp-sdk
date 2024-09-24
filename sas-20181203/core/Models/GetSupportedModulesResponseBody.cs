// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetSupportedModulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C699E4E4-F2F4-58FC-A949-457FFE59****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The supported modules. The module information is classified by cloud service provider.</para>
        /// </summary>
        [NameInMap("SupportedModuleResponse")]
        [Validation(Required=false)]
        public List<GetSupportedModulesResponseBodySupportedModuleResponse> SupportedModuleResponse { get; set; }
        public class GetSupportedModulesResponseBodySupportedModuleResponse : TeaModel {
            /// <summary>
            /// <para>The modules supported by the cloud service provider.</para>
            /// </summary>
            [NameInMap("SupportedModules")]
            [Validation(Required=false)]
            public List<GetSupportedModulesResponseBodySupportedModuleResponseSupportedModules> SupportedModules { get; set; }
            public class GetSupportedModulesResponseBodySupportedModuleResponseSupportedModules : TeaModel {
                /// <summary>
                /// <para>The code of the module. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>HOST</b>: host</description></item>
                /// <item><description><b>CSPM</b>: configuration assessment</description></item>
                /// <item><description><b>SIEM</b>: CloudSiem</description></item>
                /// <item><description><b>TRIAL</b>: log audit</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>HOST</para>
                /// </summary>
                [NameInMap("Module")]
                [Validation(Required=false)]
                public string Module { get; set; }

                /// <summary>
                /// <para>The display name of the module.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Configuration assessment</para>
                /// </summary>
                [NameInMap("ModuleDisp")]
                [Validation(Required=false)]
                public string ModuleDisp { get; set; }

            }

            /// <summary>
            /// <para>The cloud service provider. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Tencent</b>: Tencent Cloud</description></item>
            /// <item><description><b>HUAWEICLOUD</b>:Huawei Cloud</description></item>
            /// <item><description><b>Azure</b>: Microsoft Azure</description></item>
            /// <item><description><b>AWS</b>: Amazon Web Services (AWS)</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Tencent</para>
            /// </summary>
            [NameInMap("Vendor")]
            [Validation(Required=false)]
            public string Vendor { get; set; }

        }

    }

}
