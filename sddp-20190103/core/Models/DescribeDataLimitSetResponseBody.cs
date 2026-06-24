// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeDataLimitSetResponseBody : TeaModel {
        /// <summary>
        /// <para>Information about the authorized data assets.</para>
        /// </summary>
        [NameInMap("DataLimitSet")]
        [Validation(Required=false)]
        public DescribeDataLimitSetResponseBodyDataLimitSet DataLimitSet { get; set; }
        public class DescribeDataLimitSetResponseBodyDataLimitSet : TeaModel {
            /// <summary>
            /// <para>A list of authorized data assets.</para>
            /// </summary>
            [NameInMap("DataLimitList")]
            [Validation(Required=false)]
            public List<DescribeDataLimitSetResponseBodyDataLimitSetDataLimitList> DataLimitList { get; set; }
            public class DescribeDataLimitSetResponseBodyDataLimitSetDataLimitList : TeaModel {
                /// <summary>
                /// <para>The status of the connectivity test between Security Center and the authorized data asset.</para>
                /// <list type="bullet">
                /// <item><description><para><b>2</b>: The connectivity test is in progress.</para>
                /// </description></item>
                /// <item><description><para><b>3</b>: The connectivity test is passed.</para>
                /// </description></item>
                /// <item><description><para><b>4</b>: The connectivity test has failed.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("CheckStatus")]
                [Validation(Required=false)]
                public int? CheckStatus { get; set; }

                /// <summary>
                /// <para>The name of the connectivity test status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Connected</para>
                /// </summary>
                [NameInMap("CheckStatusName")]
                [Validation(Required=false)]
                public string CheckStatusName { get; set; }

                /// <summary>
                /// <para>The connection string for the data asset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>jdbc:mysql://10.<em>.</em>.94:3306/test_demo</para>
                /// </summary>
                [NameInMap("Connector")]
                [Validation(Required=false)]
                public string Connector { get; set; }

                /// <summary>
                /// <para>The time when the data asset was created. This value is a UNIX timestamp. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1625587423000</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public long? GmtCreate { get; set; }

                /// <summary>
                /// <para>The unique ID of the data asset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The name of the region where the data asset is located.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("LocalName")]
                [Validation(Required=false)]
                public string LocalName { get; set; }

                /// <summary>
                /// <para>The ID of the parent asset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>db</para>
                /// </summary>
                [NameInMap("ParentId")]
                [Validation(Required=false)]
                public string ParentId { get; set; }

                /// <summary>
                /// <para>The ID of the region where the data asset is located.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-****</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The type of the data asset. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>1</b>: MaxCompute.</para>
                /// </description></item>
                /// <item><description><para><b>2</b>: OSS.</para>
                /// </description></item>
                /// <item><description><para><b>3</b>: ADS.</para>
                /// </description></item>
                /// <item><description><para><b>4</b>: OTS.</para>
                /// </description></item>
                /// <item><description><para><b>5</b>: RDS.</para>
                /// </description></item>
                /// <item><description><para><b>6</b>: SELF_DB.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public long? ResourceType { get; set; }

                /// <summary>
                /// <para>The code for the data asset type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>MaxCompute</b></para>
                /// </description></item>
                /// <item><description><para><b>OSS</b></para>
                /// </description></item>
                /// <item><description><para><b>ADS</b></para>
                /// </description></item>
                /// <item><description><para><b>OTS</b></para>
                /// </description></item>
                /// <item><description><para><b>RDS</b></para>
                /// </description></item>
                /// <item><description><para><b>SELF_DB</b></para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>OSS</para>
                /// </summary>
                [NameInMap("ResourceTypeCode")]
                [Validation(Required=false)]
                public string ResourceTypeCode { get; set; }

                /// <summary>
                /// <para>The username of the data owner.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tsts</para>
                /// </summary>
                [NameInMap("UserName")]
                [Validation(Required=false)]
                public string UserName { get; set; }

            }

            /// <summary>
            /// <para>A list of authorized OSS buckets.</para>
            /// </summary>
            [NameInMap("OssBucketList")]
            [Validation(Required=false)]
            public List<DescribeDataLimitSetResponseBodyDataLimitSetOssBucketList> OssBucketList { get; set; }
            public class DescribeDataLimitSetResponseBodyDataLimitSetOssBucketList : TeaModel {
                /// <summary>
                /// <para>The name of the OSS bucket.</para>
                /// 
                /// <b>Example:</b>
                /// <para>oss-bucket</para>
                /// </summary>
                [NameInMap("BucketName")]
                [Validation(Required=false)]
                public string BucketName { get; set; }

                /// <summary>
                /// <para>The ID of the region where the OSS bucket is located.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-****</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

            }

            /// <summary>
            /// <para>A list of regions that support scanning.</para>
            /// </summary>
            [NameInMap("RegionList")]
            [Validation(Required=false)]
            public List<DescribeDataLimitSetResponseBodyDataLimitSetRegionList> RegionList { get; set; }
            public class DescribeDataLimitSetResponseBodyDataLimitSetRegionList : TeaModel {
                /// <summary>
                /// <para>The region name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("LocalName")]
                [Validation(Required=false)]
                public string LocalName { get; set; }

                /// <summary>
                /// <para>The region ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-****</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

            }

            /// <summary>
            /// <para>The type of the data asset. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>1</b>: MaxCompute.</para>
            /// </description></item>
            /// <item><description><para><b>2</b>: OSS.</para>
            /// </description></item>
            /// <item><description><para><b>3</b>: ADS.</para>
            /// </description></item>
            /// <item><description><para><b>4</b>: OTS.</para>
            /// </description></item>
            /// <item><description><para><b>5</b>: RDS.</para>
            /// </description></item>
            /// <item><description><para><b>6</b>: SELF_DB.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public long? ResourceType { get; set; }

            /// <summary>
            /// <para>The code for the data asset type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>MaxCompute</b></para>
            /// </description></item>
            /// <item><description><para><b>OSS</b></para>
            /// </description></item>
            /// <item><description><para><b>ADS</b></para>
            /// </description></item>
            /// <item><description><para><b>OTS</b></para>
            /// </description></item>
            /// <item><description><para><b>RDS</b></para>
            /// </description></item>
            /// <item><description><para><b>SELF_DB</b></para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>OSS</para>
            /// </summary>
            [NameInMap("ResourceTypeCode")]
            [Validation(Required=false)]
            public string ResourceTypeCode { get; set; }

            /// <summary>
            /// <para>The total number of assets found.</para>
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
