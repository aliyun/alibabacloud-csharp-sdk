// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20201002.Models
{
    public class DescribeDirectoriesResponseBody : TeaModel {
        [NameInMap("Directories")]
        [Validation(Required=false)]
        public List<DescribeDirectoriesResponseBodyDirectories> Directories { get; set; }
        public class DescribeDirectoriesResponseBodyDirectories : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>INTERNET</para>
            /// </summary>
            [NameInMap("DesktopAccessType")]
            [Validation(Required=false)]
            public string DesktopAccessType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou+dir-gx2x1dhsmu52rd****</para>
            /// </summary>
            [NameInMap("DirectoryId")]
            [Validation(Required=false)]
            public string DirectoryId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>AD_CONNECTOR</para>
            /// </summary>
            [NameInMap("DirectoryType")]
            [Validation(Required=false)]
            public string DirectoryType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>26842</para>
            /// </summary>
            [NameInMap("ProviderId")]
            [Validation(Required=false)]
            public string ProviderId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://eds-cn-shanghai-67726">https://eds-cn-shanghai-67726</a>****</para>
            /// </summary>
            [NameInMap("SsoServiceUrl")]
            [Validation(Required=false)]
            public string SsoServiceUrl { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>F369A091-002F-49C8-AD55-02A77629****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
