// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeGroupedInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of asset information returned.</para>
        /// </summary>
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public List<DescribeGroupedInstancesResponseBodyInstances> Instances { get; set; }
        public class DescribeGroupedInstancesResponseBodyInstances : TeaModel {
            /// <summary>
            /// <para>The number of assets that have high-priority vulnerabilities.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11</para>
            /// </summary>
            [NameInMap("AsapVulInstanceCount")]
            [Validation(Required=false)]
            public long? AsapVulInstanceCount { get; set; }

            /// <summary>
            /// <para>The number of assets that meet the edition-based filter condition.</para>
            /// 
            /// <b>Example:</b>
            /// <para>205</para>
            /// </summary>
            [NameInMap("AuthVersionCheckCount")]
            [Validation(Required=false)]
            public int? AuthVersionCheckCount { get; set; }

            /// <summary>
            /// <para>The name of the server group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testA</para>
            /// </summary>
            [NameInMap("FieldAliasName")]
            [Validation(Required=false)]
            public string FieldAliasName { get; set; }

            /// <summary>
            /// <para>The server group type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Default group.</description></item>
            /// <item><description><b>1</b>: Other group.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("GroupFlag")]
            [Validation(Required=false)]
            public int? GroupFlag { get; set; }

            /// <summary>
            /// <para>The total number of compute cores of all assets of the specified asset type.</para>
            /// <remarks>
            /// <para>If the request parameter <b>MachineTypes</b> is not set, this parameter returns the total number of compute cores of assets of all types.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>610</para>
            /// </summary>
            [NameInMap("InstanceCoreCount")]
            [Validation(Required=false)]
            public long? InstanceCoreCount { get; set; }

            /// <summary>
            /// <para>The total number of assets of the specified asset type.</para>
            /// <remarks>
            /// <para>If the request parameter <b>MachineTypes</b> is not set, this parameter returns the total number of assets of all types.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>205</para>
            /// </summary>
            [NameInMap("InstanceCount")]
            [Validation(Required=false)]
            public string InstanceCount { get; set; }

            /// <summary>
            /// <para>The operating system type of the asset. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>windows</b></description></item>
            /// <item><description><b>linux</b><remarks>
            /// <para>Notice: This field is returned only when <b>Lang</b> is set to <b>zh</b>.</para>
            /// </remarks>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>windows</para>
            /// </summary>
            [NameInMap("Os")]
            [Validation(Required=false)]
            public string Os { get; set; }

            /// <summary>
            /// <para>The number of assets that have security risks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>172</para>
            /// </summary>
            [NameInMap("RiskInstanceCount")]
            [Validation(Required=false)]
            public string RiskInstanceCount { get; set; }

            /// <summary>
            /// <para>The number of assets that are not protected by Security Center.</para>
            /// 
            /// <b>Example:</b>
            /// <para>32</para>
            /// </summary>
            [NameInMap("UnProtectedInstanceCount")]
            [Validation(Required=false)]
            public string UnProtectedInstanceCount { get; set; }

        }

        /// <summary>
        /// <para>The pagination information of the query results.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeGroupedInstancesResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeGroupedInstancesResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The number of assets displayed on the current page in a paged query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The page number of the current page in a paged query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The number of entries per page in a paged query. Default value: <b>20</b>, which indicates that 20 entries of asset information are displayed per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of asset entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID, which is a unique identifier generated by Alibaba Cloud for the request. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>52A3AEE6-114A-499D-8990-4BA9B27FE0AA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
