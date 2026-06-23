// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListProjectRolesRequest : TeaModel {
        /// <summary>
        /// <para>An array of workspace role codes.</para>
        /// </summary>
        [NameInMap("Codes")]
        [Validation(Required=false)]
        public List<string> Codes { get; set; }

        /// <summary>
        /// <para>An array of workspace role names.</para>
        /// </summary>
        [NameInMap("Names")]
        [Validation(Required=false)]
        public List<string> Names { get; set; }

        /// <summary>
        /// <para>The page number to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return per page. Default value: 10. Maximum value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the DataWorks workspace. You can find the ID on the Workspace Management page in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
        /// <para>This parameter specifies the DataWorks workspace for which you want to list roles.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>21229</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The type of the workspace role.</para>
        /// <list type="bullet">
        /// <item><description><para><c>UserCustom</c>: Custom Role</para>
        /// </description></item>
        /// <item><description><para><c>System</c>: System Role</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>System</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
