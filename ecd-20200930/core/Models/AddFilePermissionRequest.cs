// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class AddFilePermissionRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the enterprise drive.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou+cds-352282****</para>
        /// </summary>
        [NameInMap("CdsId")]
        [Validation(Required=false)]
        public string CdsId { get; set; }

        /// <summary>
        /// <para>The ID of the user who uses the network disk.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user01</para>
        /// </summary>
        [NameInMap("EndUserId")]
        [Validation(Required=false)]
        public string EndUserId { get; set; }

        /// <summary>
        /// <para>The file ID. You can call the <a href="https://help.aliyun.com/document_detail/2247622.html">ListCdsFiles</a> operation to query the ID of the file.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6333e553a133ce21e6f747cf948bb9ef95d7****</para>
        /// </summary>
        [NameInMap("FileId")]
        [Validation(Required=false)]
        public string FileId { get; set; }

        /// <summary>
        /// <para>The ID of the team space.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cg-i1ruuudp92qpj****</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The users that you want to authorize to use the cloud disk.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("MemberList")]
        [Validation(Required=false)]
        public List<AddFilePermissionRequestMemberList> MemberList { get; set; }
        public class AddFilePermissionRequestMemberList : TeaModel {
            /// <summary>
            /// <para>The user of the cloud disk.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("CdsIdentity")]
            [Validation(Required=false)]
            public AddFilePermissionRequestMemberListCdsIdentity CdsIdentity { get; set; }
            public class AddFilePermissionRequestMemberListCdsIdentity : TeaModel {
                /// <summary>
                /// <para>The ID of the convenience user.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>user01</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The user type.</para>
                /// <para>Set the value to TENANT_ADMIN.</para>
                /// <list type="bullet">
                /// <item><description>IT_Group: group.</description></item>
                /// <item><description>IT_User: user.</description></item>
                /// </list>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>IT_User</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>Specifies whether the users of the child group can inherit the folder permissions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("DisinheritSubGroup")]
            [Validation(Required=false)]
            public bool? DisinheritSubGroup { get; set; }

            /// <summary>
            /// <para>The time when the authorization expires. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC. The value never expires. You can specify a value that is predefined by the system for this parameter. Example: 4775500800000.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4775500800000</para>
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public long? ExpireTime { get; set; }

            /// <summary>
            /// <para>You can set permissions by specifying roles or by customizing operation permissions. This field is used to set permissions by specifying roles. This field is mutually exclusive with <c>ActionList</c>.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>SystemFileEditorWithoutShareLink: The role that can edit but cannot share files.</description></item>
            /// <item><description>SystemFileUploaderAndDownloaderWithShareLink: The role that can upload, download, and share files.</description></item>
            /// <item><description>SystemFileDownloader: The role that can download files.</description></item>
            /// <item><description>SystemFileEditorWithoutDelete: The role that can edit but cannot edit files.</description></item>
            /// <item><description>SystemFileOwner: The role that can collaborate with others on files.</description></item>
            /// <item><description>SystemFileDownloaderWithShareLink: The role that can download and share files.</description></item>
            /// <item><description>SystemFileUploaderAndViewer: The role that can preview and upload files.</description></item>
            /// <item><description>SystemFileViewer: The role that can preview files.</description></item>
            /// <item><description>SystemFileEditor: The role that can edit files.</description></item>
            /// <item><description>SystemFileUploaderWithShareLink: The role that can upload and share files.</description></item>
            /// <item><description>SystemFileUploader: The role that can upload files.</description></item>
            /// <item><description>SystemFileUploaderAndDownloader: The role that can upload and download files.</description></item>
            /// <item><description>SystemFileMetaViewer: The role that can view file list.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SystemFileUploaderAndDownloader</para>
            /// </summary>
            [NameInMap("RoleId")]
            [Validation(Required=false)]
            public string RoleId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the region. You can call the <a href="https://help.aliyun.com/document_detail/196646.html">DescribeRegions</a> operation to query the list of regions where Elastic Desktop Service (EDS) Enterprise is available.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
