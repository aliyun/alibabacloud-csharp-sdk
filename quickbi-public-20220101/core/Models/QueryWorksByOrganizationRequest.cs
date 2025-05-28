// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryWorksByOrganizationRequest : TeaModel {
        /// <summary>
        /// <para>Page number.</para>
        /// <list type="bullet">
        /// <item><description>Default value is 1.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// <para>Number of items per page.</para>
        /// <list type="bullet">
        /// <item><description>Default value is 10.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The status of the work to query. Possible values:</para>
        /// <list type="bullet">
        /// <item><description>0: Unpublished</description></item>
        /// <item><description>1: Published</description></item>
        /// <item><description>2: Modified but not published</description></item>
        /// <item><description>3: Offline</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>Third-party embedding status. Possible values:</para>
        /// <list type="bullet">
        /// <item><description>0: Embedding not enabled</description></item>
        /// <item><description>1: Embedding enabled</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ThirdPartAuthFlag")]
        [Validation(Required=false)]
        public int? ThirdPartAuthFlag { get; set; }

        /// <summary>
        /// <para>The type of work to query. Leave blank to query all types. Possible values:</para>
        /// <list type="bullet">
        /// <item><description>DATAPRODUCT: Data Portal</description></item>
        /// <item><description>PAGE: Dashboard</description></item>
        /// <item><description>REPORT: Spreadsheet</description></item>
        /// <item><description>dashboardOfflineQuery: Self-service Data Retrieval</description></item>
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
