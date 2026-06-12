// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNest20210601.Models
{
    public class ListServiceInstanceBillRequest : TeaModel {
        /// <summary>
        /// <para>The billing cycle in YYYY-MM format. Only billing cycles in the last 18 months are supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-05</para>
        /// </summary>
        [NameInMap("BillingCycle")]
        [Validation(Required=false)]
        public string BillingCycle { get; set; }

        /// <summary>
        /// <para>The billing date. This parameter is required only when <b>Granularity</b> is set to DAILY. The format is YYYY-MM-DD.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-04-01</para>
        /// </summary>
        [NameInMap("BillingDate")]
        [Validation(Required=false)]
        public string BillingDate { get; set; }

        /// <summary>
        /// <para>The granularity of the bills to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>MONTHLY: monthly. The data is consistent with the bills aggregated by billing cycle in the User Center.</para>
        /// </description></item>
        /// <item><description><para>DAILY: daily. The data is consistent with the bills aggregated by day in the User Center.</para>
        /// </description></item>
        /// </list>
        /// <para>If you set this parameter to DAILY, you must also specify <b>BillingDate</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DAILY</para>
        /// </summary>
        [NameInMap("Granularity")]
        [Validation(Required=false)]
        public string Granularity { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Maximum value: 100. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that is used to retrieve the next page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAVz7BQqj2xtiNSC3d3RAD38=</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the service instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>si-49793f3bfa034ec6a990</para>
        /// </summary>
        [NameInMap("ServiceInstanceId")]
        [Validation(Required=false)]
        public string ServiceInstanceId { get; set; }

    }

}
