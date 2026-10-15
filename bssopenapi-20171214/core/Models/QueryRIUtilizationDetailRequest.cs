// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QueryRIUtilizationDetailRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the deducted instance. If this parameter is left empty, the details of all instances are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>jsdgfsdhgsdjh</para>
        /// </summary>
        [NameInMap("DeductedInstanceId")]
        [Validation(Required=false)]
        public string DeductedInstanceId { get; set; }

        /// <summary>
        /// <para>The end time. Format: YYYY-MM-DD HH:mm:ss.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-05-23 12:00:00</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The instance type corresponding to the reserved instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Instancetyp</para>
        /// </summary>
        [NameInMap("InstanceSpec")]
        [Validation(Required=false)]
        public string InstanceSpec { get; set; }

        /// <summary>
        /// <para>The page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 20. Maximum value: 300.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ecsRi: ECS reserved instances. This is the default value.</description></item>
        /// <item><description>scu_bag: Storage capacity unit (SCU) plans.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecsRi</para>
        /// </summary>
        [NameInMap("RICommodityCode")]
        [Validation(Required=false)]
        public string RICommodityCode { get; set; }

        /// <summary>
        /// <para>The instance ID of the reserved instance for the filtered query. If this parameter is left empty, the details of all used reserved instances are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dsudfgdsjh</para>
        /// </summary>
        [NameInMap("RIInstanceId")]
        [Validation(Required=false)]
        public string RIInstanceId { get; set; }

        /// <summary>
        /// <para>The start time. Format: YYYY-MM-DD HH:mm:ss.</para>
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
