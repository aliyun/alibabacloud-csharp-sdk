// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class ListAuthConfigByResourceRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to query only the records that have permissions.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("HasAuth")]
        [Validation(Required=false)]
        public bool? HasAuth { get; set; }

        /// <summary>
        /// <para>The search keyword for the authorized object.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>The ID of the resource to be authorized.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>al*************7ufv</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// <para>The query granularity. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: User.</description></item>
        /// <item><description>1: User group.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Notice: Authorization records for organizations and workspaces are returned at the user granularity. Datasets and data sources can only be authorized to users.</notice></para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ShareToType")]
        [Validation(Required=false)]
        public int? ShareToType { get; set; }

        /// <summary>
        /// <para>The resource type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>dashboard: Dashboard.</description></item>
        /// <item><description>screen: Data screen.</description></item>
        /// <item><description>report: Workbook.</description></item>
        /// <item><description>ANALYSIS: Ad hoc analysis.</description></item>
        /// <item><description>dashboardOfflineQuery: Self-service data retrieval.</description></item>
        /// <item><description>dataForm: Data entry.</description></item>
        /// <item><description>cube: Dataset.</description></item>
        /// <item><description>datasource: Data source.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>REPORT</para>
        /// </summary>
        [NameInMap("WorksType")]
        [Validation(Required=false)]
        public string WorksType { get; set; }

    }

}
