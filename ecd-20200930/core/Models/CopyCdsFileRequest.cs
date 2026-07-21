// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class CopyCdsFileRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to automatically rename the file when a file with the same name exists in the destination folder.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoRename")]
        [Validation(Required=false)]
        public bool? AutoRename { get; set; }

        /// <summary>
        /// <para>The enterprise cloud drive ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou+cds-352282****</para>
        /// </summary>
        [NameInMap("CdsId")]
        [Validation(Required=false)]
        public string CdsId { get; set; }

        /// <summary>
        /// <para>The ID of the user who is logged on to the cloud drive.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user01</para>
        /// </summary>
        [NameInMap("EndUserId")]
        [Validation(Required=false)]
        public string EndUserId { get; set; }

        /// <summary>
        /// <para>The file ID. You can call <a href="https://help.aliyun.com/document_detail/2247622.html">ListCdsFiles</a> to query the ID of the file.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>640985a0ca2f71f489d2497682ca0bf468de****</para>
        /// </summary>
        [NameInMap("FileId")]
        [Validation(Required=false)]
        public string FileId { get; set; }

        /// <summary>
        /// <para>The ID of the personal drive (which can be obtained from the <c>UserId</c> response parameter of the <a href="https://help.aliyun.com/document_detail/2357237.html">DescribeCloudDriveUsers</a> operation) or the team space ID (which can be obtained from the <c>GroupId</c> response parameter of the <a href="https://help.aliyun.com/document_detail/609896.html">DescribeCloudDriveGroups</a> operation) at the copy destination.</para>
        /// <remarks>
        /// <para>If both <c>FileReceiverId</c> and <c>FileReceiverType</c> are empty, the file is copied to the personal drive where the file currently resides by default.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>user02</para>
        /// </summary>
        [NameInMap("FileReceiverId")]
        [Validation(Required=false)]
        public string FileReceiverId { get; set; }

        /// <summary>
        /// <para>The type of space to which the file belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user</para>
        /// </summary>
        [NameInMap("FileReceiverType")]
        [Validation(Required=false)]
        public string FileReceiverType { get; set; }

        /// <summary>
        /// <para>The team space ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cg-hs3i1w39o68ma****</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The ID of the parent folder at the copy destination. You can call <a href="https://help.aliyun.com/document_detail/2247622.html">ListCdsFiles</a> to query the ID of the folder. Set this parameter to <c>root</c> if you want to copy the file to the root directory.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>root</para>
        /// </summary>
        [NameInMap("ParentFolderId")]
        [Validation(Required=false)]
        public string ParentFolderId { get; set; }

        /// <summary>
        /// <para>The region ID. You can call <a href="https://help.aliyun.com/document_detail/196646.html">DescribeRegions</a> to query the regions supported by Elastic Desktop Service.</para>
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
