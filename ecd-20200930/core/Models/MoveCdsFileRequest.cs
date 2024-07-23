// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class MoveCdsFileRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the cloud disk.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou+cds-346063****</para>
        /// </summary>
        [NameInMap("CdsId")]
        [Validation(Required=false)]
        public string CdsId { get; set; }

        /// <summary>
        /// <para>The processing mode of files that have the same name.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><!-- -->
        /// 
        /// <para>refuse</para>
        /// <!-- -->
        /// 
        /// <para>: If you want to create a file that uses the same name as an existing file in the cloud, the system denies your request and returns the details of the existing file.</para>
        /// <!-- -->
        /// </description></item>
        /// <item><description><!-- -->
        /// 
        /// <para>auto_rename</para>
        /// <!-- -->
        /// 
        /// <para>: If you want to create a file that uses the same name as an existing file in the cloud, the system renames the file that you want to create by appending the current time point.</para>
        /// <!-- -->
        /// </description></item>
        /// <item><description><!-- -->
        /// 
        /// <para>ignore</para>
        /// <!-- -->
        /// 
        /// <para>: The system allows you to create a file that uses the same name as an existing file in the cloud.</para>
        /// <!-- -->
        /// </description></item>
        /// <item><description><!-- -->
        /// 
        /// <para>over_write</para>
        /// <!-- -->
        /// 
        /// <para>: After you create a file that uses the same name as an existing file in the cloud, the new file overwrites the existing file.</para>
        /// <!-- --></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ignore</para>
        /// </summary>
        [NameInMap("ConflictPolicy")]
        [Validation(Required=false)]
        public string ConflictPolicy { get; set; }

        /// <summary>
        /// <para>The user ID that you want to use to access the cloud disk.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user01</para>
        /// </summary>
        [NameInMap("EndUserId")]
        [Validation(Required=false)]
        public string EndUserId { get; set; }

        /// <summary>
        /// <para>The ID of the file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>63f3257b68b018170b194d87b875512d108f****</para>
        /// </summary>
        [NameInMap("FileId")]
        [Validation(Required=false)]
        public string FileId { get; set; }

        /// <summary>
        /// <para>The group ID.</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The ID of the parent folder that you want to move. If you want to remove the root folder, set the value to root.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6409848a6da91d6240604e7ba7337d85ba8a1****</para>
        /// </summary>
        [NameInMap("ParentFolderId")]
        [Validation(Required=false)]
        public string ParentFolderId { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the <a href="https://help.aliyun.com/document_detail/196646.html">DescribeRegions</a> operation to query the most recent region list.</para>
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
