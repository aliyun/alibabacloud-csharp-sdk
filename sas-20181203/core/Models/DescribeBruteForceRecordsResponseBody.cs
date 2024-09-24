// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeBruteForceRecordsResponseBody : TeaModel {
        /// <summary>
        /// <para>The IP addresses.</para>
        /// </summary>
        [NameInMap("MachineList")]
        [Validation(Required=false)]
        public List<DescribeBruteForceRecordsResponseBodyMachineList> MachineList { get; set; }
        public class DescribeBruteForceRecordsResponseBodyMachineList : TeaModel {
            /// <summary>
            /// <para>The status of the host network extension. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: online</description></item>
            /// <item><description><b>false</b>: offline</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("AliNetOnline")]
            [Validation(Required=false)]
            public bool? AliNetOnline { get; set; }

            /// <summary>
            /// <para>The timestamp when the block action on the IP address becomes invalid.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1671506882063</para>
            /// </summary>
            [NameInMap("BlockExpireDate")]
            [Validation(Required=false)]
            public long? BlockExpireDate { get; set; }

            /// <summary>
            /// <para>The IP address that is blocked.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.12.XX.XX</para>
            /// </summary>
            [NameInMap("BlockIp")]
            [Validation(Required=false)]
            public string BlockIp { get; set; }

            /// <summary>
            /// <para>The blocking type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>group</b>: security group</description></item>
            /// <item><description><b>alinet</b>: host network extension</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>alinet</para>
            /// </summary>
            [NameInMap("BlockType")]
            [Validation(Required=false)]
            public string BlockType { get; set; }

            /// <summary>
            /// <para>The error code returned when the defense rule fails to block the IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>InstanceSecurityGroupLimitExceeded</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <para>The ID of the primary key that is recorded in the defense rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>112XX</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The instance name of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>record-test-***</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The public IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>120.79.XX.XX</para>
            /// </summary>
            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            /// <summary>
            /// <para>The private IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.XX.XX</para>
            /// </summary>
            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }

            /// <summary>
            /// <para>The port that is attacked.</para>
            /// 
            /// <b>Example:</b>
            /// <para>22/22</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public string Port { get; set; }

            /// <summary>
            /// <para>The name of the defense rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AntiRuleName</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <para>The type of the defense rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>userRule</b>: custom rule</description></item>
            /// <item><description><b>blinkRule</b>: system rule</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>userRule</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>The status of the defense rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: invalid</description></item>
            /// <item><description><b>1</b>: enabled</description></item>
            /// <item><description><b>2</b>: failed</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The UUID of the server on which the defense rule takes effect.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6d5b361f-958d-48a8-a9d2-d6e82c1****</para>
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeBruteForceRecordsResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeBruteForceRecordsResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The number of entries returned on the current page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The page number of the returned page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The number of entries returned per page. Default value: <b>20</b>.</para>
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
            /// <para>263</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7E0618A9-D5EF-4220-9471-C42B5E92719F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
