// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class GetDoctorComputeSummaryRequest : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c-b933c5aac8fe****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The resource information, which is used to filter the results.</para>
        /// </summary>
        [NameInMap("ComponentInfo")]
        [Validation(Required=false)]
        public GetDoctorComputeSummaryRequestComponentInfo ComponentInfo { get; set; }
        public class GetDoctorComputeSummaryRequestComponentInfo : TeaModel {
            /// <summary>
            /// <para>Set the filter condition name based on the value of ComponentType. For example, if you set ComponentType to queue, you can specify a specific queue name to obtain the resource usage of a specific queue.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MAPREDUCE</para>
            /// </summary>
            [NameInMap("ComponentName")]
            [Validation(Required=false)]
            public string ComponentName { get; set; }

            /// <summary>
            /// <para>The resource type for filtering. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>engine: filters results by engine.</description></item>
            /// <item><description>queue: filters results by queue.</description></item>
            /// <item><description>cluster: displays the results at the cluster level.</description></item>
            /// </list>
            /// <para>If you do not specify this parameter, the information at the cluster level is displayed by default.</para>
            /// 
            /// <b>Example:</b>
            /// <para>engine</para>
            /// </summary>
            [NameInMap("ComponentType")]
            [Validation(Required=false)]
            public string ComponentType { get; set; }

        }

        /// <summary>
        /// <para>Specify the date in the ISO 8601 standard. For example, 2023-01-01 represents January 1, 2023.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-01-01</para>
        /// </summary>
        [NameInMap("DateTime")]
        [Validation(Required=false)]
        public string DateTime { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
