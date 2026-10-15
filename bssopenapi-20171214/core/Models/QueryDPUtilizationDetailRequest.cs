// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QueryDPUtilizationDetailRequest : TeaModel {
        /// <summary>
        /// <para>The commodity code, such as ecsRi and scu_bag. If this parameter is specified, the ProdCode parameter does not take effect.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecsRi</para>
        /// </summary>
        [NameInMap("CommodityCode")]
        [Validation(Required=false)]
        public string CommodityCode { get; set; }

        /// <summary>
        /// <para>The ID of the deducted instance. If this parameter is left empty, the details of all instances are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss-123123</para>
        /// </summary>
        [NameInMap("DeductedInstanceId")]
        [Validation(Required=false)]
        public string DeductedInstanceId { get; set; }

        /// <summary>
        /// <para>The end time. Format: YYYY-MM-dd HH:mm:ss.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-05-23 12:00:00</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>Specifies whether to include the resource plan usage of member accounts in finance trusteeship. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Included.</description></item>
        /// <item><description>false: Not included.</description></item>
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
        /// <para>The instance ID for the filtered query. If this parameter is left empty, the details of all used instances are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss-123123</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The instance type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Instancetyp</para>
        /// </summary>
        [NameInMap("InstanceSpec")]
        [Validation(Required=false)]
        public string InstanceSpec { get; set; }

        /// <summary>
        /// <para>The token that specifies the start position of the query. Set this parameter to null for the first query. For subsequent queries, use the NextToken value returned in the previous response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CAESF***zNTAw</para>
        /// </summary>
        [NameInMap("LastToken")]
        [Validation(Required=false)]
        public string LastToken { get; set; }

        /// <summary>
        /// <para>The number of entries to return per query. Default value: 20. Maximum value: 300.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("Limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        /// <summary>
        /// <para>The product code, such as ecs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss</para>
        /// </summary>
        [NameInMap("ProdCode")]
        [Validation(Required=false)]
        public string ProdCode { get; set; }

        /// <summary>
        /// <para>The start time. Format: YYYY-MM-dd HH:mm:ss.</para>
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
