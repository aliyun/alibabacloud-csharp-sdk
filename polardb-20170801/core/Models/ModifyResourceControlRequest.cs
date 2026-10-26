// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class ModifyResourceControlRequest : TeaModel {
        /// <summary>
        /// <para>The updated maximum number of CPU cores. The minimum value is 1, and the maximum value is determined by the resource_control_cpu_count_limit kernel parameter of the cluster. You must specify exactly one of the MaxCpu and CpuCount parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("CpuCount")]
        [Validation(Required=false)]
        public int? CpuCount { get; set; }

        /// <summary>
        /// <para>The ID of the PolarDB cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-**************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The updated maximum CPU quota percentage. Valid values: 1 to 100. You must specify exactly one of the MaxCpu and CpuCount parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("MaxCpu")]
        [Validation(Required=false)]
        public int? MaxCpu { get; set; }

        /// <summary>
        /// <para>The ID of the region where the PolarDB cluster is deployed.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/98041.html">DescribeRegions</a> operation to query available regions.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The name of the resource control rule. The name must be 1 to 63 ASCII characters in length, start with a letter, and contain only letters, digits, and underscores.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_rc</para>
        /// </summary>
        [NameInMap("ResourceControlName")]
        [Validation(Required=false)]
        public string ResourceControlName { get; set; }

    }

}
