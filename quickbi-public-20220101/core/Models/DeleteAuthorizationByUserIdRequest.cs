// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class DeleteAuthorizationByUserIdRequest : TeaModel {
        /// <summary>
        /// <para>The Quick BI user ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cc4b***94fa4</para>
        /// </summary>
        [NameInMap("QbiUserId")]
        [Validation(Required=false)]
        public string QbiUserId { get; set; }

        /// <summary>
        /// <para>The resource ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>al*************7ufv</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// <para>The type of the resource. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>dashboard: dashboard</description></item>
        /// <item><description>report: workbook</description></item>
        /// <item><description>dashboardOfflineQuery: self-service data retrieval</description></item>
        /// <item><description>cube: dataset</description></item>
        /// <item><description>datasource: data source</description></item>
        /// <item><description>screen: data dashboard</description></item>
        /// <item><description>ANALYSIS: ad hoc analysis</description></item>
        /// <item><description>dataForm: data entry form</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>report</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

    }

}
