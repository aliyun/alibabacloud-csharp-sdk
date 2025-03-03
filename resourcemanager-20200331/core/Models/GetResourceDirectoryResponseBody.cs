// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class GetResourceDirectoryResponseBody : TeaModel {
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
        public GetResourceDirectoryResponseBodyResourceDirectory ResourceDirectory { get; set; }
        public class GetResourceDirectoryResponseBodyResourceDirectory : TeaModel {
            /// <summary>
            /// <para>The status of the Control Policy feature. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Enabled: The feature is enabled.</description></item>
            /// <item><description>PendingEnable: The feature is being enabled.</description></item>
            /// <item><description>Disabled: The feature is disabled.</description></item>
            /// <item><description>PendingDisable: The feature is being disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Enabled</para>
            /// </summary>
            [NameInMap("ControlPolicyStatus")]
            [Validation(Required=false)]
            public string ControlPolicyStatus { get; set; }

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
            /// <para>The real-name verification information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>\<em>\</em>\* Co., Ltd.</para>
            /// </summary>
            [NameInMap("IdentityInformation")]
            [Validation(Required=false)]
            public string IdentityInformation { get; set; }

            /// <summary>
            /// <para>The ID of the management account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>172845045600****</para>
            /// </summary>
            [NameInMap("MasterAccountId")]
            [Validation(Required=false)]
            public string MasterAccountId { get; set; }

            /// <summary>
            /// <para>The name of the management account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aliyun-admin</para>
            /// </summary>
            [NameInMap("MasterAccountName")]
            [Validation(Required=false)]
            public string MasterAccountName { get; set; }

            /// <summary>
            /// <para>The status of the member deletion feature. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Enabled: The feature is enabled. You can call the <a href="https://help.aliyun.com/document_detail/311546.html">DeleteAccount</a> operation to delete members of the resource account type.</description></item>
            /// <item><description>Disabled: The feature is disabled. You cannot delete members of the resource account type.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Enabled</para>
            /// </summary>
            [NameInMap("MemberDeletionStatus")]
            [Validation(Required=false)]
            public string MemberDeletionStatus { get; set; }

            /// <summary>
            /// <para>The ID of the resource directory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rd-St****</para>
            /// </summary>
            [NameInMap("ResourceDirectoryId")]
            [Validation(Required=false)]
            public string ResourceDirectoryId { get; set; }

            /// <summary>
            /// <para>The ID of the Root folder.</para>
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
