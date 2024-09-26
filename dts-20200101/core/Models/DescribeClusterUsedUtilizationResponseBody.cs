// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DescribeClusterUsedUtilizationResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code returned by the backend service. The number is incremented.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The CPU utilization of the cluster. Unit: percentage.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("CpuTotal")]
        [Validation(Required=false)]
        public float? CpuTotal { get; set; }

        /// <summary>
        /// <para>The ID of the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dtscluster_h3fl1cs217sx952</para>
        /// </summary>
        [NameInMap("DedicatedClusterId")]
        [Validation(Required=false)]
        public string DedicatedClusterId { get; set; }

        /// <summary>
        /// <para>The total disk size of the cluster. Unit: GB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1024</para>
        /// </summary>
        [NameInMap("DiskTotal")]
        [Validation(Required=false)]
        public float? DiskTotal { get; set; }

        /// <summary>
        /// <para>The disk usage of the cluster. Unit: GB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>96</para>
        /// </summary>
        [NameInMap("DiskUsed")]
        [Validation(Required=false)]
        public float? DiskUsed { get; set; }

        /// <summary>
        /// <para>The total number of DTS units (DUs).</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("DuTotal")]
        [Validation(Required=false)]
        public int? DuTotal { get; set; }

        /// <summary>
        /// <para>The usage of DUs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("DuUsed")]
        [Validation(Required=false)]
        public int? DuUsed { get; set; }

        /// <summary>
        /// <para>The dynamic part in the error message. This parameter is used to replace %s in the ErrMessage parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Type</para>
        /// </summary>
        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// <para>The error code returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InternalError</para>
        /// </summary>
        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>The error message returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The Value of Input Parameter %s is not valid.</para>
        /// </summary>
        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <para>The HTTP status code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The total amount of memory. A value of 0 is temporarily returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("MemoryTotal")]
        [Validation(Required=false)]
        public float? MemoryTotal { get; set; }

        /// <summary>
        /// <para>The memory usage. A value of 0 is temporarily returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("MemoryUsed")]
        [Validation(Required=false)]
        public float? MemoryUsed { get; set; }

        /// <summary>
        /// <para>The memory usage.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.0</para>
        /// </summary>
        [NameInMap("MemoryUsedPercentage")]
        [Validation(Required=false)]
        public float? MemoryUsedPercentage { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>621BB4F8-3016-4FAA-8D5A-5D3163CC****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The number of tasks that are in progress.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("TaskRunning")]
        [Validation(Required=false)]
        public int? TaskRunning { get; set; }

    }

}
