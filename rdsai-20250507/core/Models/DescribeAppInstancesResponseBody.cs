// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class DescribeAppInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of instances.</para>
        /// </summary>
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public List<DescribeAppInstancesResponseBodyInstances> Instances { get; set; }
        public class DescribeAppInstancesResponseBodyInstances : TeaModel {
            /// <summary>
            /// <para>The application name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-supabase</para>
            /// </summary>
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            /// <summary>
            /// <para>The application type. The only supported value is <b>supabase</b>, which represents <a href="https://help.aliyun.com/document_detail/2938735.html">RDS Supabase</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>supabase</para>
            /// </summary>
            [NameInMap("AppType")]
            [Validation(Required=false)]
            public string AppType { get; set; }

            /// <summary>
            /// <para>The components of the instance.</para>
            /// </summary>
            [NameInMap("Components")]
            [Validation(Required=false)]
            public List<DescribeAppInstancesResponseBodyInstancesComponents> Components { get; set; }
            public class DescribeAppInstancesResponseBodyInstancesComponents : TeaModel {
                /// <summary>
                /// <para>The component status.</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The component type.</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The DB instance ID of the connected ApsaraDB RDS for PostgreSQL instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pgm-2ze49qv594vi****</para>
            /// </summary>
            [NameInMap("DBInstanceName")]
            [Validation(Required=false)]
            public string DBInstanceName { get; set; }

            /// <summary>
            /// <para>The instance type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rdsai.supabase.basic</para>
            /// </summary>
            [NameInMap("InstanceClass")]
            [Validation(Required=false)]
            public string InstanceClass { get; set; }

            /// <summary>
            /// <para>The minor version of the AI application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20241231</para>
            /// </summary>
            [NameInMap("InstanceMinorVersion")]
            [Validation(Required=false)]
            public string InstanceMinorVersion { get; set; }

            /// <summary>
            /// <para>The ID of the application instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ra-supabase-8moov5lxba****</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The public connection string.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8.152. XXX.XXX:8000</para>
            /// </summary>
            [NameInMap("PublicConnectionString")]
            [Validation(Required=false)]
            public string PublicConnectionString { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The instance status. For more information, see <a href="https://help.aliyun.com/document_detail/2623972.html">Instance status table</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The VSwitch ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-2zeaepb8k4ku05ov2****</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// <para>The VPC connection string.</para>
            /// 
            /// <b>Example:</b>
            /// <para>172.16.XXX.XXX:8000</para>
            /// </summary>
            [NameInMap("VpcConnectionString")]
            [Validation(Required=false)]
            public string VpcConnectionString { get; set; }

        }

        /// <summary>
        /// <para>This parameter is reserved for future use.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>32DEFB4A-861F-5D1D-ADD5-918E4FD7AB8C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
