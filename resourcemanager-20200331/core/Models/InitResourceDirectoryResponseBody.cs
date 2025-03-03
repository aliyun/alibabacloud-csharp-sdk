// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class InitResourceDirectoryResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CD76D376-2517-4924-92C5-DBC52262F93A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information of the resource directory.</para>
        /// </summary>
        [NameInMap("ResourceDirectory")]
        [Validation(Required=false)]
        public InitResourceDirectoryResponseBodyResourceDirectory ResourceDirectory { get; set; }
        public class InitResourceDirectoryResponseBodyResourceDirectory : TeaModel {
            /// <summary>
            /// <para>The time when the resource directory was enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-02-18T15:32:10.473Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The ID of the enterprise management account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>172841235500****</para>
            /// </summary>
            [NameInMap("MasterAccountId")]
            [Validation(Required=false)]
            public string MasterAccountId { get; set; }

            /// <summary>
            /// <para>The name of the enterprise management account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aliyun-****</para>
            /// </summary>
            [NameInMap("MasterAccountName")]
            [Validation(Required=false)]
            public string MasterAccountName { get; set; }

            /// <summary>
            /// <para>The ID of the resource directory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rd-Ss****</para>
            /// </summary>
            [NameInMap("ResourceDirectoryId")]
            [Validation(Required=false)]
            public string ResourceDirectoryId { get; set; }

            /// <summary>
            /// <para>The ID of the root folder.</para>
            /// 
            /// <b>Example:</b>
            /// <para>r-Zo****</para>
            /// </summary>
            [NameInMap("RootFolderId")]
            [Validation(Required=false)]
            public string RootFolderId { get; set; }

        }

    }

}
