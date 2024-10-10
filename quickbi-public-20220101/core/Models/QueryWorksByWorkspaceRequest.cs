// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryWorksByWorkspaceRequest : TeaModel {
        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// <list type="bullet">
        /// <item><description>Default value: 1.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// <list type="bullet">
        /// <item><description>Default value: 10.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The status of the work. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: unpublished</description></item>
        /// <item><description>1: published</description></item>
        /// <item><description>2: modified but not published</description></item>
        /// <item><description>3: unpublished</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>Third-party embedding status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: The embed service is not enabled.</description></item>
        /// <item><description>1: Embed is enabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ThirdPartAuthFlag")]
        [Validation(Required=false)]
        public int? ThirdPartAuthFlag { get; set; }

        /// <summary>
        /// <para>The type of the work. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>DATAPRODUCT: BI portal</description></item>
        /// <item><description>PAGE: Dashboard</description></item>
        /// <item><description>FULLPAGE: full-screen dashboards</description></item>
        /// <item><description>REPORT: workbook</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PAGE</para>
        /// </summary>
        [NameInMap("WorksType")]
        [Validation(Required=false)]
        public string WorksType { get; set; }

        /// <summary>
        /// <para>The ID of the workspace.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>89713491-cb4f-4579-b889-e82c35f1****</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
