// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QueryDPUtilizationDetailRequest : TeaModel {
        /// <summary>
        /// <para>The code of the resource, such as ecsRi and scu_bag. If this parameter is specified, the ProdCode parameter does not take effect for the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecsRi</para>
        /// </summary>
        [NameInMap("CommodityCode")]
        [Validation(Required=false)]
        public string CommodityCode { get; set; }

        /// <summary>
        /// <para>The ID of the deducted instance. If this parameter is not specified, the details of all instances are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss-123123</para>
        /// </summary>
        [NameInMap("DeductedInstanceId")]
        [Validation(Required=false)]
        public string DeductedInstanceId { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. Specify the time in the YYYY-MM-DD HH:mm:ss format.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-05-23 12:00:00</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>Specifies whether to query the resource plan usage of linked accounts. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: queries the resource plan usage of linked accounts.</description></item>
        /// <item><description>false: does not query the resource plan usage of linked accounts.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IncludeShare")]
        [Validation(Required=false)]
        public bool? IncludeShare { get; set; }

        /// <summary>
        /// <para>The ID of the instance to query. If this parameter is not specified, the details of all used instances are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss-123123</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The instance type of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Instancetyp</para>
        /// </summary>
        [NameInMap("InstanceSpec")]
        [Validation(Required=false)]
        public string InstanceSpec { get; set; }

        /// <summary>
        /// <para>The token that is used to retrieve the next page of results. For the first query, set the value to null. For subsequent queries, set the value to the token that is obtained from the NextToken parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CAESF***zNTAw</para>
        /// </summary>
        [NameInMap("LastToken")]
        [Validation(Required=false)]
        public string LastToken { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Default value: 20. Maximum value: 300.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("Limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        /// <summary>
        /// <para>The code of the service. Example: ecs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss</para>
        /// </summary>
        [NameInMap("ProdCode")]
        [Validation(Required=false)]
        public string ProdCode { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. Specify the time in the YYYY-MM-DD HH:mm:ss format.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-05-23 12:00:00</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
