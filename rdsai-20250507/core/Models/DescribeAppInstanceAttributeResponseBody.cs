// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class DescribeAppInstanceAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>The name of the AI application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-supabase</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The application type. Currently, only <b>supabase</b> is supported, which indicates <a href="https://help.aliyun.com/document_detail/2938735.html">RDS Supabase</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>supabase</para>
        /// </summary>
        [NameInMap("AppType")]
        [Validation(Required=false)]
        public string AppType { get; set; }

        /// <summary>
        /// <para>Reserved parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Reserved parameter</para>
        /// </summary>
        [NameInMap("BranchName")]
        [Validation(Required=false)]
        public string BranchName { get; set; }

        /// <summary>
        /// <para>Reserved parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Reserved parameter</para>
        /// </summary>
        [NameInMap("BranchingEnabled")]
        [Validation(Required=false)]
        public string BranchingEnabled { get; set; }

        /// <summary>
        /// <para>The list of components.</para>
        /// </summary>
        [NameInMap("Components")]
        [Validation(Required=false)]
        public List<DescribeAppInstanceAttributeResponseBodyComponents> Components { get; set; }
        public class DescribeAppInstanceAttributeResponseBodyComponents : TeaModel {
            /// <summary>
            /// <para>The component status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>enable</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The component type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>supabase</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The ID of the RDS PostgreSQL database instance that the AI application is connected to.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pgm-2ze49qv594vi****</para>
        /// </summary>
        [NameInMap("DBInstanceName")]
        [Validation(Required=false)]
        public string DBInstanceName { get; set; }

        /// <summary>
        /// <para>The instance ID of the EIP.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eip-wz9sfo01afag4hxc0utq0</para>
        /// </summary>
        [NameInMap("EipId")]
        [Validation(Required=false)]
        public string EipId { get; set; }

        /// <summary>
        /// <para>The activation status of the EIP.</para>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("EipStatus")]
        [Validation(Required=false)]
        public string EipStatus { get; set; }

        /// <summary>
        /// <para>The instance class of the AI application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rdsai.supabase.basic</para>
        /// </summary>
        [NameInMap("InstanceClass")]
        [Validation(Required=false)]
        public string InstanceClass { get; set; }

        /// <summary>
        /// <para>The latest minor version of the RDS AI application instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20260903</para>
        /// </summary>
        [NameInMap("InstanceLatestVersion")]
        [Validation(Required=false)]
        public string InstanceLatestVersion { get; set; }

        /// <summary>
        /// <para>The minor version of the RDS AI application instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20241231</para>
        /// </summary>
        [NameInMap("InstanceMinorVersion")]
        [Validation(Required=false)]
        public string InstanceMinorVersion { get; set; }

        /// <summary>
        /// <para>The instance ID of the AI application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ra-supabase-8moov5lxba****</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>Reserved parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Reserved parameter</para>
        /// </summary>
        [NameInMap("LoginToken")]
        [Validation(Required=false)]
        public string LoginToken { get; set; }

        /// <summary>
        /// <para>The minor version details of each component of the RDS AI application instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;studio\&quot;:\&quot;20260602r1\&quot;,\&quot;storage\&quot;:\&quot;v1.48.9\&quot;,\&quot;auth\&quot;:\&quot;v2.188.1\&quot;,\&quot;kong\&quot;:\&quot;3.9.0\&quot;,\&quot;rest\&quot;:\&quot;v12.2.12\&quot;,\&quot;meta\&quot;:\&quot;v0.89.3\&quot;,\&quot;realtime-dev\&quot;:\&quot;v2.34.47\&quot;,\&quot;postgres\&quot;:\&quot;rds_postgres_1700_20260830\&quot;}</para>
        /// </summary>
        [NameInMap("MinorVersionDetail")]
        [Validation(Required=false)]
        public string MinorVersionDetail { get; set; }

        /// <summary>
        /// <para>The creator of the NAT gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user</para>
        /// </summary>
        [NameInMap("NatCreatedBy")]
        [Validation(Required=false)]
        public string NatCreatedBy { get; set; }

        /// <summary>
        /// <para>The ID of the NAT gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ngw-bp1l82hw87m2y77ci1hie</para>
        /// </summary>
        [NameInMap("NatGatewayId")]
        [Validation(Required=false)]
        public string NatGatewayId { get; set; }

        /// <summary>
        /// <para>The activation status of the NAT gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("NatStatus")]
        [Validation(Required=false)]
        public string NatStatus { get; set; }

        /// <summary>
        /// <para>The public connection string of the AI application.</para>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FE9C65D7-930F-57A5-A207-8C396329241C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Reserved parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Reserved parameter</para>
        /// </summary>
        [NameInMap("RetentionHours")]
        [Validation(Required=false)]
        public string RetentionHours { get; set; }

        /// <summary>
        /// <para>Reserved parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Reserved parameter</para>
        /// </summary>
        [NameInMap("SqlExtendMoInstanceId")]
        [Validation(Required=false)]
        public string SqlExtendMoInstanceId { get; set; }

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
        /// <para>Reserved parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Reserved parameter</para>
        /// </summary>
        [NameInMap("UploadKey")]
        [Validation(Required=false)]
        public string UploadKey { get; set; }

        /// <summary>
        /// <para>Reserved parameter.</para>
        /// </summary>
        [NameInMap("UploadKeyList")]
        [Validation(Required=false)]
        public List<DescribeAppInstanceAttributeResponseBodyUploadKeyList> UploadKeyList { get; set; }
        public class DescribeAppInstanceAttributeResponseBodyUploadKeyList : TeaModel {
            /// <summary>
            /// <para>Reserved parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Reserved parameter</para>
            /// </summary>
            [NameInMap("IsSystemKey")]
            [Validation(Required=false)]
            public bool? IsSystemKey { get; set; }

            /// <summary>
            /// <para>Reserved parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Reserved parameter</para>
            /// </summary>
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            /// <summary>
            /// <para>Reserved parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Reserved parameter</para>
            /// </summary>
            [NameInMap("SlsStorageBytes")]
            [Validation(Required=false)]
            public long? SlsStorageBytes { get; set; }

            /// <summary>
            /// <para>Reserved parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Reserved parameter</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>Reserved parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Reserved parameter</para>
            /// </summary>
            [NameInMap("UploadKey")]
            [Validation(Required=false)]
            public string UploadKey { get; set; }

        }

        /// <summary>
        /// <para>The vSwitch ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-2zeaepb8k4ku05ov2****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The internal connection string of the AI application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>172.16.XXX.XXX:8000</para>
        /// </summary>
        [NameInMap("VpcConnectionString")]
        [Validation(Required=false)]
        public string VpcConnectionString { get; set; }

        /// <summary>
        /// <para>The zone ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing-i</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
