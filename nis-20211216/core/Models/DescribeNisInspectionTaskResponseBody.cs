// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nis20211216.Models
{
    public class DescribeNisInspectionTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The configuration of the inspected resources.</para>
        /// </summary>
        [NameInMap("CheckResourceList")]
        [Validation(Required=false)]
        public List<DescribeNisInspectionTaskResponseBodyCheckResourceList> CheckResourceList { get; set; }
        public class DescribeNisInspectionTaskResponseBodyCheckResourceList : TeaModel {
            /// <summary>
            /// <para>The inspection rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CheckAll</para>
            /// </summary>
            [NameInMap("CheckScope")]
            [Validation(Required=false)]
            public string CheckScope { get; set; }

            /// <summary>
            /// <para>The resource type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>EIP</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

        }

        /// <summary>
        /// <para>The time when the task was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-07-01 10:00:57</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The inspection interval. The unit is <b>day</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("InspectionInterval")]
        [Validation(Required=false)]
        public string InspectionInterval { get; set; }

        /// <summary>
        /// <para>The name of the inspection task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Default</para>
        /// </summary>
        [NameInMap("InspectionName")]
        [Validation(Required=false)]
        public string InspectionName { get; set; }

        /// <summary>
        /// <para>The type of inspection plan for the task. Valid values: basic and customized.</para>
        /// 
        /// <b>Example:</b>
        /// <para>basic</para>
        /// </summary>
        [NameInMap("InspectionProject")]
        [Validation(Required=false)]
        public string InspectionProject { get; set; }

        /// <summary>
        /// <para>The ID of the inspection task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ni-8svmpe0yso2bhzr7fh79</para>
        /// </summary>
        [NameInMap("InspectionTaskId")]
        [Validation(Required=false)]
        public string InspectionTaskId { get; set; }

        /// <summary>
        /// <para>The time when the inspection task was triggered.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-07-01 15:15:57</para>
        /// </summary>
        [NameInMap("InspectionTriggerTime")]
        [Validation(Required=false)]
        public string InspectionTriggerTime { get; set; }

        /// <summary>
        /// <para>The ID of the latest report.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nir-7c3dd178738a429abe6d</para>
        /// </summary>
        [NameInMap("LastUpdateReportId")]
        [Validation(Required=false)]
        public string LastUpdateReportId { get; set; }

        /// <summary>
        /// <para>The time when the task was last updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-07-01 10:00:59</para>
        /// </summary>
        [NameInMap("LastUpdateTime")]
        [Validation(Required=false)]
        public string LastUpdateTime { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A7F0D6EC-E19E-58AC-AC9F-08036763960F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The running status of the task.</para>
        /// <para>Creating</para>
        /// <para>Active</para>
        /// <para>Running</para>
        /// <para>Inactive</para>
        /// 
        /// <b>Example:</b>
        /// <para>Active</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
