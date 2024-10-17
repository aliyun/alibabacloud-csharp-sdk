// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeDataLimitDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the data asset.</para>
        /// </summary>
        [NameInMap("DataLimit")]
        [Validation(Required=false)]
        public DescribeDataLimitDetailResponseBodyDataLimit DataLimit { get; set; }
        public class DescribeDataLimitDetailResponseBodyDataLimit : TeaModel {
            /// <summary>
            /// <para>The status of the connectivity test between the data asset and DSC. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>2</b>: indicates that the data asset was being connected.</description></item>
            /// <item><description><b>3</b>: indicates that the data asset was connected to DSC.</description></item>
            /// <item><description><b>4</b>: indicates that the data asset failed to be connected.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("CheckStatus")]
            [Validation(Required=false)]
            public int? CheckStatus { get; set; }

            /// <summary>
            /// <para>The result that indicates the status of the connectivity test between the data asset and DSC. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Passed</b></description></item>
            /// <item><description><b>Failed</b></description></item>
            /// <item><description><b>Testing</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Passed</para>
            /// </summary>
            [NameInMap("CheckStatusName")]
            [Validation(Required=false)]
            public string CheckStatusName { get; set; }

            /// <summary>
            /// <para>The time when the data asset was connected to DSC. The value is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>145600000</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <para>The ID of the data asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12300</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The region in which the data asset resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>China (Qingdao)</para>
            /// </summary>
            [NameInMap("LocalName")]
            [Validation(Required=false)]
            public string LocalName { get; set; }

            /// <summary>
            /// <para>The ID and name of the data asset in the service to which the data asset belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rm-m5eup49p6o274****.RDS_example</para>
            /// </summary>
            [NameInMap("ParentId")]
            [Validation(Required=false)]
            public string ParentId { get; set; }

            /// <summary>
            /// <para>The port number that is used to connect to the database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3306</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            /// <summary>
            /// <para>The ID of the region in which the data asset resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-qingdao</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The type of the service to which the data asset belongs. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: MaxCompute</description></item>
            /// <item><description><b>2</b>: OSS</description></item>
            /// <item><description><b>3</b>: AnalyticDB for MySQL</description></item>
            /// <item><description><b>4</b>: Tablestore</description></item>
            /// <item><description><b>5</b>: ApsaraDB RDS</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public long? ResourceType { get; set; }

            /// <summary>
            /// <para>The service to which the data asset belongs. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>MaxCompute</b></description></item>
            /// <item><description><b>OSS</b></description></item>
            /// <item><description><b>ADS</b></description></item>
            /// <item><description><b>OTS</b></description></item>
            /// <item><description><b>RDS</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>RDS</para>
            /// </summary>
            [NameInMap("ResourceTypeCode")]
            [Validation(Required=false)]
            public string ResourceTypeCode { get; set; }

            /// <summary>
            /// <para>The account of the user who manages the data asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>User01</para>
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>769FB3C1-F4C9-42DF-9B72-7077A8989C13</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
