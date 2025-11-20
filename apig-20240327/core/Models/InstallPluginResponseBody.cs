// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class InstallPluginResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ok</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response payload.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public InstallPluginResponseBodyData Data { get; set; }
        public class InstallPluginResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The installation result.</para>
            /// </summary>
            [NameInMap("installPluginResults")]
            [Validation(Required=false)]
            public List<InstallPluginResponseBodyDataInstallPluginResults> InstallPluginResults { get; set; }
            public class InstallPluginResponseBodyDataInstallPluginResults : TeaModel {
                /// <summary>
                /// <para>The gateway ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>gw-d28mjcmm1hkub84mdbi0</para>
                /// </summary>
                [NameInMap("gatewayId")]
                [Validation(Required=false)]
                public string GatewayId { get; set; }

                /// <summary>
                /// <para>The plug-in ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pl-cvs7gbum1hkhs6us6vbg</para>
                /// </summary>
                [NameInMap("pluginId")]
                [Validation(Required=false)]
                public string PluginId { get; set; }

            }

        }

        /// <summary>
        /// <para>The status message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>201CFCA0-3AF5-52D0-A0F3-FBA697AF55CB</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
