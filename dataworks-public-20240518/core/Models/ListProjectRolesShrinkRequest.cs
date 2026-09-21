// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListProjectRolesShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The list of workspace role codes.</para>
        /// </summary>
        [NameInMap("Codes")]
        [Validation(Required=false)]
        public string CodesShrink { get; set; }

        /// <summary>
        /// <para>The list of workspace role names.</para>
        /// </summary>
        [NameInMap("Names")]
        [Validation(Required=false)]
        public string NamesShrink { get; set; }

        /// <summary>
        /// <para>The page number. Used for paging.</para>
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
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the DataWorks workspace. You can log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a> and go to the workspace management page to obtain the ID.</para>
        /// <para>This parameter specifies the DataWorks workspace for this API invoke operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>21229</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The type of the workspace role. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>UserCustom: user-defined role.</description></item>
        /// <item><description>System: system role.</description></item>
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
