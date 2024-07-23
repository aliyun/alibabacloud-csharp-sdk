// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class AddFilePermissionRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the cloud disk whose folder you want to share.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou+cds-352282****</para>
        /// </summary>
        [NameInMap("CdsId")]
        [Validation(Required=false)]
        public string CdsId { get; set; }

        /// <summary>
        /// <para>The ID of the end user who uses the cloud disk.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user01</para>
        /// </summary>
        [NameInMap("EndUserId")]
        [Validation(Required=false)]
        public string EndUserId { get; set; }

        /// <summary>
        /// <para>The ID of the file.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6333e553a133ce21e6f747cf948bb9ef95d7****</para>
        /// </summary>
        [NameInMap("FileId")]
        [Validation(Required=false)]
        public string FileId { get; set; }

        /// <summary>
        /// <para>The ID of the team that uses cloud disks in Cloud Drive Service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cg-i1ruuudp92qpj****</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The members who are granted the folder permissions.</para>
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
                /// <para>The ID of the user.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>user01</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The type of the user.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description><!-- -->
                /// 
                /// <para>IT_Group</para>
                /// <!-- -->
                /// 
                /// <!-- -->
                /// </description></item>
                /// <item><description><!-- -->
                /// 
                /// <para>IT_User</para>
                /// <!-- -->
                /// 
                /// <!-- --></description></item>
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
            /// <para>The ID of the role to which you want to attach the folder permissions. To configure the folder permissions: you can specify a role or create custom operation permissions. You can use RoleId to specify a role. RoleId is mutually exclusive with ActionList. If you specify both of them, the value of RoleId takes precedence.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>SystemFileEditorWithoutShareLink</description></item>
            /// <item><description>SystemFileUploaderAndDownloaderWithShareLink</description></item>
            /// <item><description>SystemFileDownloader</description></item>
            /// <item><description>SystemFileEditorWithoutDelete</description></item>
            /// <item><description>SystemFileOwner</description></item>
            /// <item><description>SystemFileDownloaderWithShareLink</description></item>
            /// <item><description>SystemFileUploaderAndViewer</description></item>
            /// <item><description>SystemFileViewer</description></item>
            /// <item><description>SystemFileEditor</description></item>
            /// <item><description>SystemFileUploaderWithShareLink</description></item>
            /// <item><description>SystemFileUploader</description></item>
            /// <item><description>SystemFileUploaderAndDownloader</description></item>
            /// <item><description>SystemFileMetaViewer</description></item>
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
        /// <para>The region ID of the folder. You can call the <a href="https://help.aliyun.com/document_detail/196646.html">DescribeRegions</a> operation to query the most recent region list.</para>
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
