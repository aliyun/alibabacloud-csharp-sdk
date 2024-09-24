// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateOpaClusterPluginResponseBody : TeaModel {
        /// <summary>
        /// <para>The installation status of the components.</para>
        /// </summary>
        [NameInMap("InstallStatus")]
        [Validation(Required=false)]
        public List<CreateOpaClusterPluginResponseBodyInstallStatus> InstallStatus { get; set; }
        public class CreateOpaClusterPluginResponseBodyInstallStatus : TeaModel {
            /// <summary>
            /// <para>The cluster ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c60b77fe62093480db6164a3c2fa****</para>
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>Indicates whether the component is installed. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("InstallStatus")]
            [Validation(Required=false)]
            public bool? InstallStatus { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D65AADFC-1D20-5A6A-8F6A-9FA53C0DC1F8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
