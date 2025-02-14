// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeIdcProbeListResponseBody : TeaModel {
        /// <summary>
        /// <para>IDC probe list.</para>
        /// </summary>
        [NameInMap("IdcProbes")]
        [Validation(Required=false)]
        public List<DescribeIdcProbeListResponseBodyIdcProbes> IdcProbes { get; set; }
        public class DescribeIdcProbeListResponseBodyIdcProbes : TeaModel {
            /// <summary>
            /// <para>IDC data center name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3K IDC</para>
            /// </summary>
            [NameInMap("IdcName")]
            [Validation(Required=false)]
            public string IdcName { get; set; }

            /// <summary>
            /// <para>Region.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("IdcRegion")]
            [Validation(Required=false)]
            public string IdcRegion { get; set; }

            /// <summary>
            /// <para>Instance ID of the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-xxxxx</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>Instance name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oraclexxx</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>Public IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>47.98.<em>.</em></para>
            /// </summary>
            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            /// <summary>
            /// <para>Scan period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16</para>
            /// </summary>
            [NameInMap("IntervalPeriod")]
            [Validation(Required=false)]
            public int? IntervalPeriod { get; set; }

            /// <summary>
            /// <para>Private IP of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.68.<em>.</em></para>
            /// </summary>
            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }

            /// <summary>
            /// <para>IP segment range.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.1.0/24</para>
            /// </summary>
            [NameInMap("IpSegments")]
            [Validation(Required=false)]
            public string IpSegments { get; set; }

            /// <summary>
            /// <para>Linux port.</para>
            /// 
            /// <b>Example:</b>
            /// <para>22</para>
            /// </summary>
            [NameInMap("LinuxPort")]
            [Validation(Required=false)]
            public string LinuxPort { get; set; }

            /// <summary>
            /// <para>The unit of the scan period, with values:</para>
            /// <list type="bullet">
            /// <item><description><b>day</b>: day.</description></item>
            /// <item><description><b>hour</b>: hour.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>day</para>
            /// </summary>
            [NameInMap("PeriodUnit")]
            [Validation(Required=false)]
            public string PeriodUnit { get; set; }

            /// <summary>
            /// <para>Probe service status. Values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Active</description></item>
            /// <item><description><b>1</b>: Inactive</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ServiceStatus")]
            [Validation(Required=false)]
            public int? ServiceStatus { get; set; }

            /// <summary>
            /// <para>Probe status. Values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Enabled</description></item>
            /// <item><description><b>1</b>: Disabled</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>Server UUID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>inet-eae02b9a-1dbd-44a6-844c-69072b27****</para>
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

            /// <summary>
            /// <para>Windows port.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3389</para>
            /// </summary>
            [NameInMap("WinPort")]
            [Validation(Required=false)]
            public string WinPort { get; set; }

        }

        /// <summary>
        /// <para>Pagination information.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeIdcProbeListResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeIdcProbeListResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The number of data entries displayed on the current page in a paginated query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>17</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The page number in a paginated query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The maximum number of data entries to display per page in a paginated query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>Total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The ID of this call request, which is a unique identifier generated by Alibaba Cloud for the request and can be used for troubleshooting and problem localization.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0C8487EF-50C2-54BB-8634-10F8C35D****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
