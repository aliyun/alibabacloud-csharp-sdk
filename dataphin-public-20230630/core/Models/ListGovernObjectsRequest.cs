// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListGovernObjectsRequest : TeaModel {
        /// <summary>
        /// <para>The paged query conditions.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ListQuery")]
        [Validation(Required=false)]
        public ListGovernObjectsRequestListQuery ListQuery { get; set; }
        public class ListGovernObjectsRequestListQuery : TeaModel {
            /// <summary>
            /// <para>The governance item type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>TABLE</description></item>
            /// <item><description>DATASOURCE_TABLE</description></item>
            /// <item><description>DATASOURCE</description></item>
            /// <item><description>INDEX</description></item>
            /// <item><description>REALTIME_LOGICAL_TABLE</description></item>
            /// <item><description>QD_FEATURE</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TABLE</para>
            /// </summary>
            [NameInMap("GovernItemType")]
            [Validation(Required=false)]
            public string GovernItemType { get; set; }

            /// <summary>
            /// <para>The search keyword.</para>
            /// 
            /// <b>Example:</b>
            /// <para>table_name</para>
            /// </summary>
            [NameInMap("Keyword")]
            [Validation(Required=false)]
            public string Keyword { get; set; }

            /// <summary>
            /// <para>The owner.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user123</para>
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// <para>The page number. Default value: 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of records per page. Default value: 20.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The list of project names used to filter results.</para>
            /// </summary>
            [NameInMap("ProjectNames")]
            [Validation(Required=false)]
            public List<string> ProjectNames { get; set; }

            /// <summary>
            /// <para>The list of governance object statuses. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>NEW</description></item>
            /// <item><description>VERIFY</description></item>
            /// <item><description>FINISHED</description></item>
            /// <item><description>IGNORE</description></item>
            /// </list>
            /// </summary>
            [NameInMap("StatusList")]
            [Validation(Required=false)]
            public List<string> StatusList { get; set; }

            /// <summary>
            /// <para>The view type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ALL</description></item>
            /// <item><description>OWNER</description></item>
            /// <item><description>PROJECT</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ALL</para>
            /// </summary>
            [NameInMap("ViewType")]
            [Validation(Required=false)]
            public string ViewType { get; set; }

        }

        /// <summary>
        /// <para>The tenant ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

        /// <summary>
        /// <para>The ID of the operator user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

    }

}
