// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeIdcProbeScanResultListResponseBody : TeaModel {
        /// <summary>
        /// <para>The instances.</para>
        /// </summary>
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public List<DescribeIdcProbeScanResultListResponseBodyInstances> Instances { get; set; }
        public class DescribeIdcProbeScanResultListResponseBodyInstances : TeaModel {
            /// <summary>
            /// <para>The status of the client of the instance on which the probe is installed. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>online</b>: The Security Center agent on the asset is <b>enabled</b>.</description></item>
            /// <item><description><b>offline</b>: The Security Center agent on the asset is <b>disabled</b>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>online</para>
            /// </summary>
            [NameInMap("ClientStatus")]
            [Validation(Required=false)]
            public string ClientStatus { get; set; }

            /// <summary>
            /// <para>The name of the IDC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test</para>
            /// </summary>
            [NameInMap("IdcName")]
            [Validation(Required=false)]
            public string IdcName { get; set; }

            /// <summary>
            /// <para>The CIDR blocks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.2.0/24</para>
            /// </summary>
            [NameInMap("IpSegment")]
            [Validation(Required=false)]
            public string IpSegment { get; set; }

            /// <summary>
            /// <para>The timestamp when the last scan was performed. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1720006818000</para>
            /// </summary>
            [NameInMap("LastScanTime")]
            [Validation(Required=false)]
            public long? LastScanTime { get; set; }

            /// <summary>
            /// <para>The operating system type of the asset. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>windows</b></description></item>
            /// <item><description><b>linux</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Linux</para>
            /// </summary>
            [NameInMap("Os")]
            [Validation(Required=false)]
            public string Os { get; set; }

            /// <summary>
            /// <para>The private IP address of the associated instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>42.121.<em>.</em></para>
            /// </summary>
            [NameInMap("ProbeInternetIp")]
            [Validation(Required=false)]
            public string ProbeInternetIp { get; set; }

            /// <summary>
            /// <para>The private IP address of the associated instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.<em>.</em></para>
            /// </summary>
            [NameInMap("ProbeIntranetIp")]
            [Validation(Required=false)]
            public string ProbeIntranetIp { get; set; }

            /// <summary>
            /// <para>The name of the associated instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-xxxx</para>
            /// </summary>
            [NameInMap("ProbeMachineName")]
            [Validation(Required=false)]
            public string ProbeMachineName { get; set; }

            /// <summary>
            /// <para>The UUID of the associated instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11C96623-E106-59C9-866D-A6C82911****</para>
            /// </summary>
            [NameInMap("ProbeUuid")]
            [Validation(Required=false)]
            public string ProbeUuid { get; set; }

            /// <summary>
            /// <para>The ID of the scan result.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1231</para>
            /// </summary>
            [NameInMap("ScanResultId")]
            [Validation(Required=false)]
            public long? ScanResultId { get; set; }

            /// <summary>
            /// <para>The IP address that is scanned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.<em>.</em></para>
            /// </summary>
            [NameInMap("ScannedIp")]
            [Validation(Required=false)]
            public string ScannedIp { get; set; }

            /// <summary>
            /// <para>The port that is scanned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>22</para>
            /// </summary>
            [NameInMap("ValidPort")]
            [Validation(Required=false)]
            public string ValidPort { get; set; }

        }

        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeIdcProbeScanResultListResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeIdcProbeScanResultListResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The number of entries returned on the current page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>69</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A3D7C47D-3F11-57BB-90E8-E5C20C61****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
