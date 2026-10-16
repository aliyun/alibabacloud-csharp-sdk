// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class GetResourceDirectoryResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CD76D376-2517-4924-92C5-DBC52262F93A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The resource directory information.</para>
        /// </summary>
        [NameInMap("ResourceDirectory")]
        [Validation(Required=false)]
        public GetResourceDirectoryResponseBodyResourceDirectory ResourceDirectory { get; set; }
        public class GetResourceDirectoryResponseBodyResourceDirectory : TeaModel {
            /// <summary>
            /// <para>The status of the control policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Enabled: Enabled.</description></item>
            /// <item><description>PendingEnable: Being enabled.</description></item>
            /// <item><description>Disabled: Disabled.</description></item>
            /// <item><description>PendingDisable: Being disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Enabled</para>
            /// </summary>
            [NameInMap("ControlPolicyStatus")]
            [Validation(Required=false)]
            public string ControlPolicyStatus { get; set; }

            /// <summary>
            /// <para>The time when the resource directory was created. The time is displayed in UTC in RFC 3339 format, indicated by Z.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-02-18T15:32:10.473Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The real-name verification information of the member.</para>
            /// 
            /// <b>Example:</b>
            /// <para>***有限公司</para>
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
            /// <para>Indicates whether member deletion is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Enabled: Enabled. You can call <a href="https://help.aliyun.com/document_detail/311546.html">DeleteAccount</a> to delete members of the resource account type.</description></item>
            /// <item><description>Disabled: Disabled. You cannot delete members of the resource account type.</description></item>
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
