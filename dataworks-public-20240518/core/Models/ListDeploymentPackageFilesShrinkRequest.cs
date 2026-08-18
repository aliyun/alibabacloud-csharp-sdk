// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListDeploymentPackageFilesShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the workflow. You can call the <a href="https://help.aliyun.com/document_detail/173945.html">ListBusiness</a> operation to query the ID of the workflow by name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100001</para>
        /// </summary>
        [NameInMap("BusinessId")]
        [Validation(Required=false)]
        public long? BusinessId { get; set; }

        /// <summary>
        /// <para>The change type. Valid values: </para>
        /// <list type="bullet">
        /// <item><description>0: added.</description></item>
        /// <item><description>1: updated.</description></item>
        /// <item><description>2: deleted.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ChangeType")]
        [Validation(Required=false)]
        public int? ChangeType { get; set; }

        /// <summary>
        /// <para>The start date for the commit, in the format yyyy-MM-dd.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-01</para>
        /// </summary>
        [NameInMap("CommitFrom")]
        [Validation(Required=false)]
        public string CommitFrom { get; set; }

        /// <summary>
        /// <para>The end date for the commit (inclusive), in the format yyyy-MM-dd.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-31</para>
        /// </summary>
        [NameInMap("CommitTo")]
        [Validation(Required=false)]
        public string CommitTo { get; set; }

        /// <summary>
        /// <para>The user ID of the committer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2003****</para>
        /// </summary>
        [NameInMap("CommitUserId")]
        [Validation(Required=false)]
        public string CommitUserId { get; set; }

        /// <summary>
        /// <para>The list of file IDs to query.</para>
        /// </summary>
        [NameInMap("FileIds")]
        [Validation(Required=false)]
        public string FileIdsShrink { get; set; }

        /// <summary>
        /// <para>The name of the file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Filename</para>
        /// </summary>
        [NameInMap("FileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        /// <summary>
        /// <para>The code type of the file.</para>
        /// <para>Different file types have different codes. For more information, see <a href="https://help.aliyun.com/document_detail/600169.html">DataWorks nodes</a>.
        /// You can also call the <a href="https://help.aliyun.com/document_detail/212428.html">ListFileType</a> operation to query the code type of a file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("FileType")]
        [Validation(Required=false)]
        public int? FileType { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 10. Maximum value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the DataWorks workspace. You can log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a> and go to the workspace configuration page to obtain the workspace ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The Solutions ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8065</para>
        /// </summary>
        [NameInMap("SolutionId")]
        [Validation(Required=false)]
        public long? SolutionId { get; set; }

    }

}
