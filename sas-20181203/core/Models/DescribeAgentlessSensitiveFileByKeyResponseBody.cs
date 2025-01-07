// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeAgentlessSensitiveFileByKeyResponseBody : TeaModel {
        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeAgentlessSensitiveFileByKeyResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeAgentlessSensitiveFileByKeyResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The number of entries returned on the current page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
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
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FBBEB173-1F43-505F-A876-C03ECDF6CE4C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the sensitive files that are detected by using the agentless detection feature.</para>
        /// </summary>
        [NameInMap("SensitiveFileList")]
        [Validation(Required=false)]
        public List<DescribeAgentlessSensitiveFileByKeyResponseBodySensitiveFileList> SensitiveFileList { get; set; }
        public class DescribeAgentlessSensitiveFileByKeyResponseBodySensitiveFileList : TeaModel {
            [NameInMap("FilePath")]
            [Validation(Required=false)]
            public string FilePath { get; set; }

            /// <summary>
            /// <para>The timestamp when the first scan was performed. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1663321552000</para>
            /// </summary>
            [NameInMap("FirstScanTime")]
            [Validation(Required=false)]
            public long? FirstScanTime { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The instance name of the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-server</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The public IP address of the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>95.214.XX.XX</para>
            /// </summary>
            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            /// <summary>
            /// <para>The private IP address of the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.68.XX.XX</para>
            /// </summary>
            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }

            /// <summary>
            /// <para>The timestamp when the last scan was performed. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1663691592000</para>
            /// </summary>
            [NameInMap("LastScanTime")]
            [Validation(Required=false)]
            public long? LastScanTime { get; set; }

            [NameInMap("Md5")]
            [Validation(Required=false)]
            public string Md5 { get; set; }

            [NameInMap("Prompt")]
            [Validation(Required=false)]
            public string Prompt { get; set; }

            /// <summary>
            /// <para>The risk level. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>high</b></description></item>
            /// <item><description><b>medium</b></description></item>
            /// <item><description><b>low</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>high</para>
            /// </summary>
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public string RiskLevel { get; set; }

            /// <summary>
            /// <para>The type of the sensitive file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pem</para>
            /// </summary>
            [NameInMap("SensitiveFileKey")]
            [Validation(Required=false)]
            public string SensitiveFileKey { get; set; }

            /// <summary>
            /// <para>The status of the sensitive file. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: unhandled.</description></item>
            /// <item><description><b>1</b>: ignored.</description></item>
            /// <item><description><b>2</b>: false positive.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The name of the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SAS_Agentless_171869952****</para>
            /// </summary>
            [NameInMap("TargetName")]
            [Validation(Required=false)]
            public string TargetName { get; set; }

            /// <summary>
            /// <para>The UUID of the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>73e6a851-e63b-49ef-9d7a-5542d765****</para>
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
