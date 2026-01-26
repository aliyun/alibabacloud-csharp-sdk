// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeAccessPointsRequest : TeaModel {
        /// <summary>
        /// <para>The name of the permission group.</para>
        /// <para>This parameter is required for a General-purpose NAS file system.</para>
        /// <para>The default permission group for virtual private clouds (VPCs) is named DEFAULT_VPC_GROUP_NAME.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DEFAULT_VPC_GROUP_NAME</para>
        /// </summary>
        [NameInMap("AccessGroup")]
        [Validation(Required=false)]
        public string AccessGroup { get; set; }

        /// <summary>
        /// <para>The ID of the file system.</para>
        /// 
        /// <b>Example:</b>
        /// <para>174494****</para>
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// <para>The number of results for each query.</para>
        /// <para>Valid values: 10 to 100. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token used to retrieve the next page of results. Do not specify this parameter for the first request. For subsequent requests, set this value to the NextToken returned in the previous response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MTY4NzcxOTcwMjAzMDk2Nzc0MyM4MDM4****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The tags of the access point.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeAccessPointsRequestTag> Tag { get; set; }
        public class DescribeAccessPointsRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of the tag.</para>
            /// <para>Limits:</para>
            /// <list type="bullet">
            /// <item><description>Valid values of N: 1 to 20.</description></item>
            /// <item><description>Maximum length is 128 characters.</description></item>
            /// <item><description>Cannot start with aliyun or acs:.</description></item>
            /// <item><description>Cannot contain http:// or https://.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the tag.</para>
            /// <para>Limits:</para>
            /// <list type="bullet">
            /// <item><description>Valid values of N: 1 to 20.</description></item>
            /// <item><description>Maximum length is 128 characters.</description></item>
            /// <item><description>Cannot start with aliyun or acs:.</description></item>
            /// <item><description>Cannot contain http:// or https://.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
