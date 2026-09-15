// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class ListDataAgentThemeRequest : TeaModel {
        /// <summary>
        /// <para>The common scenario of the theme. Valid values: report, infographic, and others.</para>
        /// 
        /// <b>Example:</b>
        /// <para>report</para>
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// <para><b>[Not currently supported]</b> The maximum number of entries per page. Maximum value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para><b>[Not currently supported]</b> The pagination token for the next query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If <b>NextToken</b> is empty, no next query exists.</description></item>
        /// <item><description>If <b>NextToken</b> has a return value, the value is the token for the next query.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>f056501ada12****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The source of the theme. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>system</description></item>
        /// <item><description>custom</description></item>
        /// <item><description>derived</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>custom</para>
        /// </summary>
        [NameInMap("ThemeFrom")]
        [Validation(Required=false)]
        public string ThemeFrom { get; set; }

        /// <summary>
        /// <para>The theme stage. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>design: The theme contains only design.md.</description></item>
        /// <item><description>template: The theme is complete and renderable.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>template</para>
        /// </summary>
        [NameInMap("ThemeType")]
        [Validation(Required=false)]
        public string ThemeType { get; set; }

        /// <summary>
        /// <para>The workspace context. If this parameter is left empty or set to personal, the personal workspace is used. To query themes in a collaborative workspace, specify the workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>99fad*******6c0l4nlacu</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
