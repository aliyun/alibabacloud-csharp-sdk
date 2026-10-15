// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class UpdateAuthorizationAttributesRequest : TeaModel {
        /// <summary>
        /// <para>The edit permission type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: Private.</description></item>
        /// <item><description>11: All workspace members except guests. For data forms, datasets, and data sources, this value indicates all workspace developers.</description></item>
        /// <item><description>12: Specified members. For data forms, datasets, and data sources, this value indicates specified developers.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("EditPermissionType")]
        [Validation(Required=false)]
        public int? EditPermissionType { get; set; }

        /// <summary>
        /// <para>The ID of the resource to modify.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>al*************7ufv</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// <para>The resource type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>dashboard: dashboard.</description></item>
        /// <item><description>screen: data visualization.</description></item>
        /// <item><description>report: workbook.</description></item>
        /// <item><description>ANALYSIS: ad hoc analysis.</description></item>
        /// <item><description>dashboardOfflineQuery: self-service data retrieval.</description></item>
        /// <item><description>dataForm: data form.</description></item>
        /// <item><description>cube: dataset.</description></item>
        /// <item><description>datasource: data source.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cube</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The usage permission type for datasets and data sources. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: All workspace members except guests.</description></item>
        /// <item><description>2: Specified members.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("UsePermissionType")]
        [Validation(Required=false)]
        public int? UsePermissionType { get; set; }

    }

}
