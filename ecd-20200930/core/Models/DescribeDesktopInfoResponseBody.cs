// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeDesktopInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>Basic desktop information.</para>
        /// </summary>
        [NameInMap("Desktops")]
        [Validation(Required=false)]
        public List<DescribeDesktopInfoResponseBodyDesktops> Desktops { get; set; }
        public class DescribeDesktopInfoResponseBodyDesktops : TeaModel {
            /// <summary>
            /// <para>User connection status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Disconnected</para>
            /// </summary>
            [NameInMap("ConnectionStatus")]
            [Validation(Required=false)]
            public string ConnectionStatus { get; set; }

            /// <summary>
            /// <para>Desktop image version number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.4.0-R-***</para>
            /// </summary>
            [NameInMap("CurrentAppVersion")]
            [Validation(Required=false)]
            public string CurrentAppVersion { get; set; }

            /// <summary>
            /// <para>Desktop group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dg-3uiojcc0j4kh7****</para>
            /// </summary>
            [NameInMap("DesktopGroupId")]
            [Validation(Required=false)]
            public string DesktopGroupId { get; set; }

            /// <summary>
            /// <para>Desktop ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecd-gx2x1dhsmucyy****</para>
            /// </summary>
            [NameInMap("DesktopId")]
            [Validation(Required=false)]
            public string DesktopId { get; set; }

            /// <summary>
            /// <para>The status of the cloud desktop.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("DesktopStatus")]
            [Validation(Required=false)]
            public string DesktopStatus { get; set; }

            /// <summary>
            /// <para>The management flag.</para>
            /// </summary>
            [NameInMap("ManagementFlag")]
            [Validation(Required=false)]
            public List<string> ManagementFlag { get; set; }

            /// <summary>
            /// <para>Upgrade package size, in KB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>568533470</para>
            /// </summary>
            [NameInMap("NewAppSize")]
            [Validation(Required=false)]
            public long? NewAppSize { get; set; }

            /// <summary>
            /// <para>Desktop upgradable image version number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.6.0-R-***</para>
            /// </summary>
            [NameInMap("NewAppVersion")]
            [Validation(Required=false)]
            public string NewAppVersion { get; set; }

            /// <summary>
            /// <para>Description of the upgradable image version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test upgrade package 03-07</para>
            /// </summary>
            [NameInMap("ReleaseNote")]
            [Validation(Required=false)]
            public string ReleaseNote { get; set; }

            /// <summary>
            /// <para>Desktop first startup time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-11-06T08:31Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

        }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>062B1439-709A-580E-85DF-CE97A1560565</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
