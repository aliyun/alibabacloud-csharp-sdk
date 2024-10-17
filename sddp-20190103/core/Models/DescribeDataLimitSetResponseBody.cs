// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeDataLimitSetResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the data asset.</para>
        /// </summary>
        [NameInMap("DataLimitSet")]
        [Validation(Required=false)]
        public DescribeDataLimitSetResponseBodyDataLimitSet DataLimitSet { get; set; }
        public class DescribeDataLimitSetResponseBodyDataLimitSet : TeaModel {
            /// <summary>
            /// <para>An array that consists of data assets that DSC is authorized to scan.</para>
            /// </summary>
            [NameInMap("DataLimitList")]
            [Validation(Required=false)]
            public List<DescribeDataLimitSetResponseBodyDataLimitSetDataLimitList> DataLimitList { get; set; }
            public class DescribeDataLimitSetResponseBodyDataLimitSetDataLimitList : TeaModel {
                /// <summary>
                /// <para>Indicates whether the test of connectivity between DSC and the data asset is passed.</para>
                /// <list type="bullet">
                /// <item><description><b>2</b>: The connectivity test is in progress.</description></item>
                /// <item><description><b>3</b>: The connectivity test is passed.</description></item>
                /// <item><description><b>4</b>: The connectivity test failed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("CheckStatus")]
                [Validation(Required=false)]
                public int? CheckStatus { get; set; }

                /// <summary>
                /// <para>The name of the data detection status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Connectivity test status</para>
                /// </summary>
                [NameInMap("CheckStatusName")]
                [Validation(Required=false)]
                public string CheckStatusName { get; set; }

                /// <summary>
                /// <para>The connection string that is used to access the data asset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Connection string</para>
                /// </summary>
                [NameInMap("Connector")]
                [Validation(Required=false)]
                public string Connector { get; set; }

                /// <summary>
                /// <para>The time when the data asset was created. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1625587423000</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public long? GmtCreate { get; set; }

                /// <summary>
                /// <para>The ID of the data asset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The region in which the data asset resides.</para>
                /// 
                /// <b>Example:</b>
                /// <para>China (Hangzhou)</para>
                /// </summary>
                [NameInMap("LocalName")]
                [Validation(Required=false)]
                public string LocalName { get; set; }

                /// <summary>
                /// <para>The parent asset ID of the data asset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>db</para>
                /// </summary>
                [NameInMap("ParentId")]
                [Validation(Required=false)]
                public string ParentId { get; set; }

                /// <summary>
                /// <para>The region in which the data asset resides.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-****</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The type of service to which the data asset belongs. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: MaxCompute</description></item>
                /// <item><description><b>2</b>: OSS</description></item>
                /// <item><description><b>3</b>: AnalyticDB for MySQL</description></item>
                /// <item><description><b>4</b>: Tablestore</description></item>
                /// <item><description><b>5</b>: ApsaraDB RDS</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public long? ResourceType { get; set; }

                /// <summary>
                /// <para>The code of the service to which the data asset belongs. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>ODPS</b></description></item>
                /// <item><description><b>OSS</b></description></item>
                /// <item><description><b>ADS</b></description></item>
                /// <item><description><b>OTS</b></description></item>
                /// <item><description><b>RDS</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>OSS</para>
                /// </summary>
                [NameInMap("ResourceTypeCode")]
                [Validation(Required=false)]
                public string ResourceTypeCode { get; set; }

                /// <summary>
                /// <para>The username that is used to access the data asset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tsts</para>
                /// </summary>
                [NameInMap("UserName")]
                [Validation(Required=false)]
                public string UserName { get; set; }

            }

            /// <summary>
            /// <para>An array consisting of the OSS objects that DSC is authorized to scan.</para>
            /// </summary>
            [NameInMap("OssBucketList")]
            [Validation(Required=false)]
            public List<DescribeDataLimitSetResponseBodyDataLimitSetOssBucketList> OssBucketList { get; set; }
            public class DescribeDataLimitSetResponseBodyDataLimitSetOssBucketList : TeaModel {
                /// <summary>
                /// <para>The name of the OSS bucket to which the OSS object belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>oss-bucket</para>
                /// </summary>
                [NameInMap("BucketName")]
                [Validation(Required=false)]
                public string BucketName { get; set; }

                /// <summary>
                /// <para>The region ID of the OSS object.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-****</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

            }

            /// <summary>
            /// <para>An array consisting of the regions in which the data assets can be scanned.</para>
            /// </summary>
            [NameInMap("RegionList")]
            [Validation(Required=false)]
            public List<DescribeDataLimitSetResponseBodyDataLimitSetRegionList> RegionList { get; set; }
            public class DescribeDataLimitSetResponseBodyDataLimitSetRegionList : TeaModel {
                /// <summary>
                /// <para>The name of the region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>China (Hangzhou)</para>
                /// </summary>
                [NameInMap("LocalName")]
                [Validation(Required=false)]
                public string LocalName { get; set; }

                /// <summary>
                /// <para>The ID of the region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-****</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

            }

            /// <summary>
            /// <para>The type of service to which the data asset belongs. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: MaxCompute</description></item>
            /// <item><description><b>2</b>: OSS</description></item>
            /// <item><description><b>3</b>: AnalyticDB for MySQL</description></item>
            /// <item><description><b>4</b>: Tablestore</description></item>
            /// <item><description><b>5</b>: ApsaraDB RDS</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public long? ResourceType { get; set; }

            /// <summary>
            /// <para>The service to which the data asset belongs. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>ODPS</b></description></item>
            /// <item><description><b>OSS</b></description></item>
            /// <item><description><b>ADS</b></description></item>
            /// <item><description><b>OTS</b></description></item>
            /// <item><description><b>RDS</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>OSS</para>
            /// </summary>
            [NameInMap("ResourceTypeCode")]
            [Validation(Required=false)]
            public string ResourceTypeCode { get; set; }

            /// <summary>
            /// <para>The total number of data objects in the data assets.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>769FB3C1-F4C9-42DF-9B72-7077A8989C13</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
