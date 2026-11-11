// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class ListSupabaseProjectsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of instance details.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<ListSupabaseProjectsResponseBodyItems> Items { get; set; }
        public class ListSupabaseProjectsResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable <b>auto-start and auto-stop</b>.
            /// Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: enabled. After this feature is enabled, Supabase automatically pauses and resumes the instance based on traffic.</description></item>
            /// <item><description>false: disabled. After this feature is disabled, the auto-start and auto-stop feature of Supabase is turned off.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("AutoScale")]
            [Validation(Required=false)]
            public string AutoScale { get; set; }

            /// <summary>
            /// <para>The time when the instance was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-10-09T04:54:08Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The password for the Supabase dashboard. This parameter is not used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxpassword</para>
            /// </summary>
            [NameInMap("DashboardPassword")]
            [Validation(Required=false)]
            public string DashboardPassword { get; set; }

            /// <summary>
            /// <para>The username for the Supabase dashboard. This parameter is not used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("DashboardUserName")]
            [Validation(Required=false)]
            public string DashboardUserName { get; set; }

            /// <summary>
            /// <para>The performance level of the cloud disk.</para>
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
            /// <para>The database engine version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6.0</para>
            /// </summary>
            [NameInMap("EngineVersion")]
            [Validation(Required=false)]
            public string EngineVersion { get; set; }

            /// <summary>
            /// <para>The time when the instance expires.</para>
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
            /// <item><description><b>Postpaid</b>: pay-as-you-go.</description></item>
            /// <item><description><b>Prepaid</b>: subscription.</description></item>
            /// <item><description><b>Free</b>: free of charge.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Postpaid</para>
            /// </summary>
            [NameInMap("PayType")]
            [Validation(Required=false)]
            public string PayType { get; set; }

            /// <summary>
            /// <para>The internal network connection string for the Supabase dashboard.</para>
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
            /// <para>The specifications of the Supabase instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1C1G</para>
            /// </summary>
            [NameInMap("ProjectSpec")]
            [Validation(Required=false)]
            public string ProjectSpec { get; set; }

            /// <summary>
            /// <para>The public network connection string for the Supabase dashboard.</para>
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
            /// <para>The IP addresses in the IP whitelist. Separate multiple IP addresses with commas. The following three formats are supported:</para>
            /// <list type="bullet">
            /// <item><description>0.0.0.0/0</description></item>
            /// <item><description>10.23.12.24 (IP address)</description></item>
            /// <item><description>10.23.12.24/24 (CIDR block. <c>/24</c> specifies the length of the prefix in the IP address. Valid values of the prefix length: 1 to 32.)</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>127.0.0.1</para>
            /// </summary>
            [NameInMap("SecurityIPList")]
            [Validation(Required=false)]
            public string SecurityIPList { get; set; }

            /// <summary>
            /// <para>The status of the Supabase instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>running</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The storage capacity. Unit: GB.</para>
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
        /// <para>The maximum number of results to return for the current request. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The next token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of records on the current page.</para>
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
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
