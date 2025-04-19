// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20201002.Models
{
    public class DescribeDirectoriesResponseBody : TeaModel {
        /// <summary>
        /// <para>The directories.</para>
        /// </summary>
        [NameInMap("Directories")]
        [Validation(Required=false)]
        public List<DescribeDirectoriesResponseBodyDirectories> Directories { get; set; }
        public class DescribeDirectoriesResponseBodyDirectories : TeaModel {
            /// <summary>
            /// <para>The connection method.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>VPC: End users connect to cloud computers over an enterprise virtual private cloud (VPC).</description></item>
            /// <item><description>INTERNET: End users connect to cloud computers over the Internet.</description></item>
            /// <item><description>ANY: End users connect to cloud computers over the Internet or an enterprise VPC.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>INTERNET</para>
            /// </summary>
            [NameInMap("DesktopAccessType")]
            [Validation(Required=false)]
            public string DesktopAccessType { get; set; }

            /// <summary>
            /// <para>The directory ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou+dir-gx2x1dhsmu52rd****</para>
            /// </summary>
            [NameInMap("DirectoryId")]
            [Validation(Required=false)]
            public string DirectoryId { get; set; }

            /// <summary>
            /// <para>The directory type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AD_CONNECTOR</para>
            /// </summary>
            [NameInMap("DirectoryType")]
            [Validation(Required=false)]
            public string DirectoryType { get; set; }

            /// <summary>
            /// <para>The provider ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>26842</para>
            /// </summary>
            [NameInMap("ProviderId")]
            [Validation(Required=false)]
            public string ProviderId { get; set; }

            /// <summary>
            /// <para>The URL of the SSO service.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://eds-cn-shanghai-67726">https://eds-cn-shanghai-67726</a>****</para>
            /// </summary>
            [NameInMap("SsoServiceUrl")]
            [Validation(Required=false)]
            public string SsoServiceUrl { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F369A091-002F-49C8-AD55-02A77629****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
