// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryWorksByOrganizationRequest : TeaModel {
        /// <summary>
        /// <para>The page number.</para>
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
        /// <para>The number of rows per page.</para>
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
        /// <para>The status of the works to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: Unpublished.</description></item>
        /// <item><description>1: Published.</description></item>
        /// <item><description>2: Modified but not published.</description></item>
        /// <item><description>3: Offline.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>The third-party embedding status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: Embedding is not enabled.</description></item>
        /// <item><description>1: Embedding is enabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ThirdPartAuthFlag")]
        [Validation(Required=false)]
        public int? ThirdPartAuthFlag { get; set; }

        /// <summary>
        /// <para>The type of works to query. Leave this parameter empty to query all types. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>DATAPRODUCT: data portal</description></item>
        /// <item><description>PAGE: dashboard</description></item>
        /// <item><description>REPORT: workbook</description></item>
        /// <item><description>dashboardOfflineQuery: custom query</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PAGE</para>
        /// </summary>
        [NameInMap("WorksType")]
        [Validation(Required=false)]
        public string WorksType { get; set; }

    }

}
