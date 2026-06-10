// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class QueryHistoryAvgMetricListResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of average metric data.</para>
        /// </summary>
        [NameInMap("AvgMetricList")]
        [Validation(Required=false)]
        public List<QueryHistoryAvgMetricListResponseBodyAvgMetricList> AvgMetricList { get; set; }
        public class QueryHistoryAvgMetricListResponseBodyAvgMetricList : TeaModel {
            /// <summary>
            /// <para>The aggregated metric value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("AvgValue")]
            [Validation(Required=false)]
            public float? AvgValue { get; set; }

            /// <summary>
            /// <para>The billing method of the desktop. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>PostPaid</c>: pay-as-you-go</para>
            /// </description></item>
            /// <item><description><para><c>PrePaid</c>: subscription</para>
            /// </description></item>
            /// </list>
            /// <para>Default value: <c>PostPaid</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PrePaid</para>
            /// </summary>
            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// <para>The number of vCPUs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public int? Cpu { get; set; }

            /// <summary>
            /// <para>The desktop group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dg-bogo95eob5avnis9k</para>
            /// </summary>
            [NameInMap("DesktopGroupId")]
            [Validation(Required=false)]
            public string DesktopGroupId { get; set; }

            /// <summary>
            /// <para><b>The desktop ID.</b></para>
            /// 
            /// <b>Example:</b>
            /// <para>ecd-bx9i0nsjd3zmibnzq</para>
            /// </summary>
            [NameInMap("DesktopId")]
            [Validation(Required=false)]
            public string DesktopId { get; set; }

            /// <summary>
            /// <para><b>The desktop name.</b></para>
            /// 
            /// <b>Example:</b>
            /// <para>C-051</para>
            /// </summary>
            [NameInMap("DesktopName")]
            [Validation(Required=false)]
            public string DesktopName { get; set; }

            /// <summary>
            /// <para>The status of the desktop. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>Stopped</c>: The desktop is stopped.</para>
            /// </description></item>
            /// <item><description><para><c>Starting</c>: The desktop is being started.</para>
            /// </description></item>
            /// <item><description><para><c>Rebuilding</c>: The desktop is being rebuilt.</para>
            /// </description></item>
            /// <item><description><para><c>Running</c>: The desktop is running.</para>
            /// </description></item>
            /// <item><description><para><c>Stopping</c>: The desktop is being stopped.</para>
            /// </description></item>
            /// <item><description><para><c>Expired</c>: The desktop has expired.</para>
            /// </description></item>
            /// <item><description><para><c>Deleted</c>: The desktop has been deleted.</para>
            /// </description></item>
            /// <item><description><para><c>Pending</c>: The desktop is in a pending state.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("DesktopStatus")]
            [Validation(Required=false)]
            public string DesktopStatus { get; set; }

            /// <summary>
            /// <para>The desktop type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eds.enterprise_office.8c16g</para>
            /// </summary>
            [NameInMap("DesktopType")]
            [Validation(Required=false)]
            public string DesktopType { get; set; }

            /// <summary>
            /// <para>The IDs of the authorized end users.</para>
            /// </summary>
            [NameInMap("EndUserIds")]
            [Validation(Required=false)]
            public List<string> EndUserIds { get; set; }

            /// <summary>
            /// <para>The GPU memory size.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("GpuSpec")]
            [Validation(Required=false)]
            public string GpuSpec { get; set; }

            /// <summary>
            /// <para>The management flag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ManagementFlag")]
            [Validation(Required=false)]
            public string ManagementFlag { get; set; }

            /// <summary>
            /// <para>The memory size, in MB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2048</para>
            /// </summary>
            [NameInMap("Memory")]
            [Validation(Required=false)]
            public long? Memory { get; set; }

            /// <summary>
            /// <para>Whether the desktop is a multi-user shared desktop.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("MultiResource")]
            [Validation(Required=false)]
            public bool? MultiResource { get; set; }

            /// <summary>
            /// <para>The type of the system image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Winserver2025</para>
            /// </summary>
            [NameInMap("Platform")]
            [Validation(Required=false)]
            public string Platform { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>A list of session details.</para>
            /// </summary>
            [NameInMap("Sessions")]
            [Validation(Required=false)]
            public List<QueryHistoryAvgMetricListResponseBodyAvgMetricListSessions> Sessions { get; set; }
            public class QueryHistoryAvgMetricListResponseBodyAvgMetricListSessions : TeaModel {
                /// <summary>
                /// <para>The ID of the end user.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testUser</para>
                /// </summary>
                [NameInMap("EndUserId")]
                [Validation(Required=false)]
                public string EndUserId { get; set; }

                /// <summary>
                /// <para>The time when the session was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-04-17T14:51:53Z</para>
                /// </summary>
                [NameInMap("EstablishmentTime")]
                [Validation(Required=false)]
                public string EstablishmentTime { get; set; }

                /// <summary>
                /// <para>The external username of the end user.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testUserName</para>
                /// </summary>
                [NameInMap("ExternalUserName")]
                [Validation(Required=false)]
                public string ExternalUserName { get; set; }

                /// <summary>
                /// <para>The nickname of the end user.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sz-sygc-07-03</para>
                /// </summary>
                [NameInMap("NickName")]
                [Validation(Required=false)]
                public string NickName { get; set; }

            }

            /// <summary>
            /// <para>The payment type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>monthPackage</para>
            /// </summary>
            [NameInMap("SubPayType")]
            [Validation(Required=false)]
            public string SubPayType { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>269BDB16-2CD8-4865-84BD-11C40BC2****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
