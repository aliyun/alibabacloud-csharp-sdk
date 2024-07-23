// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeHostGroupElasticStrategyParametersResponseBody : TeaModel {
        /// <summary>
        /// <para>The CPU utilization of the instance. Unit: percentage.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("CpuShar")]
        [Validation(Required=false)]
        public int? CpuShar { get; set; }

        /// <summary>
        /// <para>The number of CPU cores used by the instance. Unit: cores.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("CpuZoom")]
        [Validation(Required=false)]
        public int? CpuZoom { get; set; }

        /// <summary>
        /// <para>The number of I/O requests.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("IopsZoom")]
        [Validation(Required=false)]
        public int? IopsZoom { get; set; }

        /// <summary>
        /// <para>The maximum number of concurrent connections supported by the instance type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("MaxConnZoom")]
        [Validation(Required=false)]
        public int? MaxConnZoom { get; set; }

        /// <summary>
        /// <para>The total memory size of the instance in the dedicated cluster. Unit: MB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("MemoryZoom")]
        [Validation(Required=false)]
        public int? MemoryZoom { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60F9A12A-16B8-4728-B099-4CA38D32C31C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
