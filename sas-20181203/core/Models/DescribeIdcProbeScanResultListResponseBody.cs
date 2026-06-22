// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeIdcProbeScanResultListResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of instances.</para>
        /// </summary>
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public List<DescribeIdcProbeScanResultListResponseBodyInstances> Instances { get; set; }
        public class DescribeIdcProbeScanResultListResponseBodyInstances : TeaModel {
            /// <summary>
            /// <para>The online status of the probe instance client. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>online</b>: The Agent client on the asset is enabled.</description></item>
            /// <item><description><b>offline</b>: The Agent client on the asset is disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>online</para>
            /// </summary>
            [NameInMap("ClientStatus")]
            [Validation(Required=false)]
            public string ClientStatus { get; set; }

            /// <summary>
            /// <para>The name of the IDC server room.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3K机房广州</para>
            /// </summary>
            [NameInMap("IdcName")]
            [Validation(Required=false)]
            public string IdcName { get; set; }

            /// <summary>
            /// <para>The IP segment list.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.2.0/24</para>
            /// </summary>
            [NameInMap("IpSegment")]
            [Validation(Required=false)]
            public string IpSegment { get; set; }

            /// <summary>
            /// <para>The timestamp of the latest scan, in milliseconds.</para>
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
            /// <item><description><b>linux</b>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Linux</para>
            /// </summary>
            [NameInMap("Os")]
            [Validation(Required=false)]
            public string Os { get; set; }

            /// <summary>
            /// <para>The public IP address of the associated machine instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>42.121.<em>.</em></para>
            /// </summary>
            [NameInMap("ProbeInternetIp")]
            [Validation(Required=false)]
            public string ProbeInternetIp { get; set; }

            /// <summary>
            /// <para>The private IP address of the associated machine instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.<em>.</em></para>
            /// </summary>
            [NameInMap("ProbeIntranetIp")]
            [Validation(Required=false)]
            public string ProbeIntranetIp { get; set; }

            /// <summary>
            /// <para>The name of the associated machine instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-xxxx</para>
            /// </summary>
            [NameInMap("ProbeMachineName")]
            [Validation(Required=false)]
            public string ProbeMachineName { get; set; }

            /// <summary>
            /// <para>The UUID of the associated machine instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11C96623-E106-59C9-866D-A6C82911****</para>
            /// </summary>
            [NameInMap("ProbeUuid")]
            [Validation(Required=false)]
            public string ProbeUuid { get; set; }

            /// <summary>
            /// <para>The scan result ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1231</para>
            /// </summary>
            [NameInMap("ScanResultId")]
            [Validation(Required=false)]
            public long? ScanResultId { get; set; }

            /// <summary>
            /// <para>The scanned IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.<em>.</em></para>
            /// </summary>
            [NameInMap("ScannedIp")]
            [Validation(Required=false)]
            public string ScannedIp { get; set; }

            /// <summary>
            /// <para>The scanned port.</para>
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
            /// <para>The number of entries on the current page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The page number of the current page in a paged query.</para>
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
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>69</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID. Alibaba Cloud generates a unique identifier for each API request. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A3D7C47D-3F11-57BB-90E8-E5C20C61****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
