// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListDataServiceApiCallStatisticsShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The search conditions.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ListQuery")]
        [Validation(Required=false)]
        public string ListQueryShrink { get; set; }

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
        /// <para>The ID of the operator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

        /// <summary>
        /// <para>The data service project ID.</para>
        /// <remarks>
        /// <para>If this parameter is not specified:</para>
        /// <list type="bullet">
        /// <item><description>Super administrators can query data of all service projects.</description></item>
        /// <item><description>Users other than super administrators can query data of service projects where they have the service project administrator or O&amp;M user permissions.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>102102</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public int? ProjectId { get; set; }

    }

}
