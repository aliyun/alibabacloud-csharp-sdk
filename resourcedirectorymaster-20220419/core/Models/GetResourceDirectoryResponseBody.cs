// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceDirectoryMaster20220419.Models
{
    public class GetResourceDirectoryResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>CD76D376-2517-4924-92C5-DBC52262F93A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResourceDirectory")]
        [Validation(Required=false)]
        public GetResourceDirectoryResponseBodyResourceDirectory ResourceDirectory { get; set; }
        public class GetResourceDirectoryResponseBodyResourceDirectory : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>Enabled</para>
            /// </summary>
            [NameInMap("ControlPolicyStatus")]
            [Validation(Required=false)]
            public string ControlPolicyStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2019-02-18T15:32:10.473Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("IdentityInformation")]
            [Validation(Required=false)]
            public string IdentityInformation { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>172845045600****</para>
            /// </summary>
            [NameInMap("MasterAccountId")]
            [Validation(Required=false)]
            public string MasterAccountId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>aliyun-admin</para>
            /// </summary>
            [NameInMap("MasterAccountName")]
            [Validation(Required=false)]
            public string MasterAccountName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Enabled</para>
            /// </summary>
            [NameInMap("MemberDeletionStatus")]
            [Validation(Required=false)]
            public string MemberDeletionStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>rd-St****</para>
            /// </summary>
            [NameInMap("ResourceDirectoryId")]
            [Validation(Required=false)]
            public string ResourceDirectoryId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>r-Zo****</para>
            /// </summary>
            [NameInMap("RootFolderId")]
            [Validation(Required=false)]
            public string RootFolderId { get; set; }

        }

    }

}
