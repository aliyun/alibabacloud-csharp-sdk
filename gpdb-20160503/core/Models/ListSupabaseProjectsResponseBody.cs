// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class ListSupabaseProjectsResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of instance details.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<ListSupabaseProjectsResponseBodyItems> Items { get; set; }
        public class ListSupabaseProjectsResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>Indicates if the <b>auto start and stop</b> feature is enabled.
            /// Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: The feature is enabled. The Supabase instance automatically pauses and resumes based on traffic.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: The auto start and stop feature is disabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("AutoScale")]
            [Validation(Required=false)]
            public string AutoScale { get; set; }

            /// <summary>
            /// <para>The time when the resource was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-10-09T04:54:08Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The password for the Supabase dashboard. This parameter is reserved.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxpassword</para>
            /// </summary>
            [NameInMap("DashboardPassword")]
            [Validation(Required=false)]
            public string DashboardPassword { get; set; }

            /// <summary>
            /// <para>The username for the Supabase dashboard. This parameter is reserved.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("DashboardUserName")]
            [Validation(Required=false)]
            public string DashboardUserName { get; set; }

            /// <summary>
            /// <para>The disk performance level.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PL0</para>
            /// </summary>
            [NameInMap("DiskPerformanceLevel")]
            [Validation(Required=false)]
            public string DiskPerformanceLevel { get; set; }

            /// <summary>
            /// <para>The database engine.</para>
            /// 
            /// <b>Example:</b>
            /// <para>gpdb</para>
            /// </summary>
            [NameInMap("Engine")]
            [Validation(Required=false)]
            public string Engine { get; set; }

            /// <summary>
            /// <para>The engine version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6.0</para>
            /// </summary>
            [NameInMap("EngineVersion")]
            [Validation(Required=false)]
            public string EngineVersion { get; set; }

            /// <summary>
            /// <para>The expiration time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-04-27T16:00:00Z</para>
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            /// <summary>
            /// <para>The billing method. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Postpaid</b>: pay-as-you-go.</para>
            /// </description></item>
            /// <item><description><para><b>Prepaid</b>: subscription.</para>
            /// </description></item>
            /// <item><description><para><b>Free</b>: The instance is free of charge.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Postpaid</para>
            /// </summary>
            [NameInMap("PayType")]
            [Validation(Required=false)]
            public string PayType { get; set; }

            /// <summary>
            /// <para>The private endpoint for the Supabase dashboard.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.0.1</para>
            /// </summary>
            [NameInMap("PrivateConnectUrl")]
            [Validation(Required=false)]
            public string PrivateConnectUrl { get; set; }

            /// <summary>
            /// <para>The detailed description of the Supabase project.</para>
            /// 
            /// <b>Example:</b>
            /// <para>for-test-project</para>
            /// </summary>
            [NameInMap("ProjectDescription")]
            [Validation(Required=false)]
            public string ProjectDescription { get; set; }

            /// <summary>
            /// <para>The ID of the Supabase instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sbp-12***</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }

            /// <summary>
            /// <para>The name of the Supabase project.</para>
            /// 
            /// <b>Example:</b>
            /// <para>supabase_project</para>
            /// </summary>
            [NameInMap("ProjectName")]
            [Validation(Required=false)]
            public string ProjectName { get; set; }

            /// <summary>
            /// <para>The Supabase instance specification.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1C1G</para>
            /// </summary>
            [NameInMap("ProjectSpec")]
            [Validation(Required=false)]
            public string ProjectSpec { get; set; }

            /// <summary>
            /// <para>The public endpoint for the Supabase dashboard.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.154.11.10</para>
            /// </summary>
            [NameInMap("PublicConnectUrl")]
            [Validation(Required=false)]
            public string PublicConnectUrl { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The IP whitelist. IP addresses are separated by commas. The following formats are supported:</para>
            /// <list type="bullet">
            /// <item><description><para>0.0.0.0/0</para>
            /// </description></item>
            /// <item><description><para>10.23.12.24 (IP)</para>
            /// </description></item>
            /// <item><description><para>10.23.12.24/24 (a Classless Inter-Domain Routing (CIDR) block; the prefix length, which is the number after the <c>/</c>, must be an integer from 1 to 32.)</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>127.0.0.1</para>
            /// </summary>
            [NameInMap("SecurityIPList")]
            [Validation(Required=false)]
            public string SecurityIPList { get; set; }

            /// <summary>
            /// <para>The status of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>running</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The storage size in GB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("StorageSize")]
            [Validation(Required=false)]
            public long? StorageSize { get; set; }

            /// <summary>
            /// <para>The vSwitch ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-bp1cpq8mr64paltkb****</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// <para>The VPC ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-bp19ame5m1r3oejns****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <para>The zone ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-h</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>A pagination token for retrieving the next page of results. If this parameter is not returned, it indicates that all results have been displayed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ABB39CC3-4488-4857-905D-2E4A051D****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
