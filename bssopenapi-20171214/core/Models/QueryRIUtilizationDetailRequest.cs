// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QueryRIUtilizationDetailRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the instance whose fees are deducted by using the RI. If this parameter is left empty, the usage details of all instances are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>jsdgfsdhgsdjh</para>
        /// </summary>
        [NameInMap("DeductedInstanceId")]
        [Validation(Required=false)]
        public string DeductedInstanceId { get; set; }

        /// <summary>
        /// <para>The time when the RI expires. Specify the time in the YYYY-MM-DD HH:mm:ss format.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-05-23 12:00:00</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The instance type of the RI.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Instancetyp</para>
        /// </summary>
        [NameInMap("InstanceSpec")]
        [Validation(Required=false)]
        public string InstanceSpec { get; set; }

        /// <summary>
        /// <para>The number of the page to return. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Default value: 20. Maximum value: 300.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The code of the service to which the RI is applied. Default value: ecsRi. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ecsRi: ECS RI.</description></item>
        /// <item><description>scu_bag: storage capacity unit (SCU).</description></item>
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
        /// <para>The ID of the RI. If this parameter is left empty, the usage details of all RIs are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dsudfgdsjh</para>
        /// </summary>
        [NameInMap("RIInstanceId")]
        [Validation(Required=false)]
        public string RIInstanceId { get; set; }

        /// <summary>
        /// <para>The time when the RI was created. Specify the time in the YYYY-MM-DD HH:mm:ss format.</para>
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
