// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribePackagesResponseBody : TeaModel {
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
        /// <para>An array that consists of the information about the packages.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribePackagesResponseBodyItems> Items { get; set; }
        public class DescribePackagesResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The point in time when the MaxCompute package was created. The value is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1536751124000</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public long? CreationTime { get; set; }

            /// <summary>
            /// <para>The ID of the package.</para>
            /// 
            /// <b>Example:</b>
            /// <para>111111</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The ID of the instance to which the package belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>223453332</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public long? InstanceId { get; set; }

            /// <summary>
            /// <para>The name of the package.</para>
            /// 
            /// <b>Example:</b>
            /// <para>gxdata</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The account of the user that owns the package.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cou-2221</para>
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// <para>The sensitivity level of the package. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: N/A, which indicates that no sensitive data is detected.</description></item>
            /// <item><description><b>2</b>: S1, which indicates the low sensitivity level.</description></item>
            /// <item><description><b>3</b>: S2, which indicates the medium sensitivity level.</description></item>
            /// <item><description><b>4</b>: S3, which indicates the high sensitivity level.</description></item>
            /// <item><description><b>5</b>: S4, which indicates the highest sensitivity level.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("RiskLevelId")]
            [Validation(Required=false)]
            public long? RiskLevelId { get; set; }

            /// <summary>
            /// <para>The name of the sensitivity level for the package.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Highest sensitivity level</para>
            /// </summary>
            [NameInMap("RiskLevelName")]
            [Validation(Required=false)]
            public string RiskLevelName { get; set; }

            /// <summary>
            /// <para>Indicates whether the package contains sensitive data. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: yes</description></item>
            /// <item><description>false: no</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Sensitive")]
            [Validation(Required=false)]
            public bool? Sensitive { get; set; }

            /// <summary>
            /// <para>The total volume of sensitive data in the package. For example, the value can be the total number of sensitive tables in the MaxCompute package.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("SensitiveCount")]
            [Validation(Required=false)]
            public int? SensitiveCount { get; set; }

            /// <summary>
            /// <para>The total volume of data in the package. For example, the value can be the total number of tables in the MaxCompute package.</para>
            /// 
            /// <b>Example:</b>
            /// <para>321</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>769FB3C1-F4C9-42DF-9B72-7077A8989C13</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
