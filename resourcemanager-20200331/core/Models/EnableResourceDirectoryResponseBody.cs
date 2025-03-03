// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class EnableResourceDirectoryResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EC2FE94D-A4A2-51A1-A493-5C273A36C46A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information of the resource directory.</para>
        /// </summary>
        [NameInMap("ResourceDirectory")]
        [Validation(Required=false)]
        public EnableResourceDirectoryResponseBodyResourceDirectory ResourceDirectory { get; set; }
        public class EnableResourceDirectoryResponseBodyResourceDirectory : TeaModel {
            /// <summary>
            /// <para>The time when the resource directory was enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-12-08T02:15:31.744Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The ID of the management account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>507408460615****</para>
            /// </summary>
            [NameInMap("MasterAccountId")]
            [Validation(Required=false)]
            public string MasterAccountId { get; set; }

            /// <summary>
            /// <para>The name of the management account.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:alice@example.com">alice@example.com</a></para>
            /// </summary>
            [NameInMap("MasterAccountName")]
            [Validation(Required=false)]
            public string MasterAccountName { get; set; }

            /// <summary>
            /// <para>The ID of the resource directory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rd-54****</para>
            /// </summary>
            [NameInMap("ResourceDirectoryId")]
            [Validation(Required=false)]
            public string ResourceDirectoryId { get; set; }

            /// <summary>
            /// <para>The ID of the Root folder.</para>
            /// 
            /// <b>Example:</b>
            /// <para>r-G9****</para>
            /// </summary>
            [NameInMap("RootFolderId")]
            [Validation(Required=false)]
            public string RootFolderId { get; set; }

        }

    }

}
