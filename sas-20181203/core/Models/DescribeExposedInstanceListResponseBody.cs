// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeExposedInstanceListResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of asset exposure analysis results.</para>
        /// </summary>
        [NameInMap("ExposedInstances")]
        [Validation(Required=false)]
        public List<DescribeExposedInstanceListResponseBodyExposedInstances> ExposedInstances { get; set; }
        public class DescribeExposedInstanceListResponseBodyExposedInstances : TeaModel {
            /// <summary>
            /// <para>The number of high-severity vulnerabilities exposed on the Internet that can be exploited by attackers.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AsapVulCount")]
            [Validation(Required=false)]
            public int? AsapVulCount { get; set; }

            /// <summary>
            /// <para>The asset type. Valid values:  </para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Elastic Computing Service (ECS) server</description></item>
            /// <item><description><b>1</b>: load balancing (SLB)</description></item>
            /// <item><description><b>2</b>: NAT gateway</description></item>
            /// <item><description><b>3</b>: ApsaraDB RDS database</description></item>
            /// <item><description><b>4</b>: MongoDB database</description></item>
            /// <item><description><b>5</b>: Redis database</description></item>
            /// <item><description><b>6</b>: container image (IMAGE)</description></item>
            /// <item><description><b>7</b>: container (CONTAINER).</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AssetType")]
            [Validation(Required=false)]
            public int? AssetType { get; set; }

            /// <summary>
            /// <para>The JSON string of cloud service information for database-type assets. The fields include:</para>
            /// <list type="bullet">
            /// <item><description>assetSubType: the asset subtype</description></item>
            /// <item><description>assetSubTypeName: the name of the asset subtype</description></item>
            /// <item><description>assetType: the asset type</description></item>
            /// <item><description>assetTypeName: the name of the asset type</description></item>
            /// <item><description>vendor: the asset vendor.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>{assetSubTypeName&quot;:&quot;INSTANCE&quot;,&quot;assetType&quot;:3,&quot;assetTypeName&quot;:&quot;RDS&quot;,&quot;vendor&quot;:0}</para>
            /// </summary>
            [NameInMap("CloudAssetInfo")]
            [Validation(Required=false)]
            public string CloudAssetInfo { get; set; }

            /// <summary>
            /// <para>The number of CSPM risks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("CspmAlarmCount")]
            [Validation(Required=false)]
            public int? CspmAlarmCount { get; set; }

            /// <summary>
            /// <para>The number of baseline weak password risks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ExploitHealthCount")]
            [Validation(Required=false)]
            public int? ExploitHealthCount { get; set; }

            /// <summary>
            /// <para>The system component exposed on the Internet.</para>
            /// 
            /// <b>Example:</b>
            /// <para>openssl,openssh</para>
            /// </summary>
            [NameInMap("ExposureComponent")]
            [Validation(Required=false)]
            public string ExposureComponent { get; set; }

            /// <summary>
            /// <para>The list of exposed component information.</para>
            /// </summary>
            [NameInMap("ExposureComponentList")]
            [Validation(Required=false)]
            public List<DescribeExposedInstanceListResponseBodyExposedInstancesExposureComponentList> ExposureComponentList { get; set; }
            public class DescribeExposedInstanceListResponseBodyExposedInstancesExposureComponentList : TeaModel {
                /// <summary>
                /// <para>The type of the exposed component.</para>
                /// 
                /// <b>Example:</b>
                /// <para>system_service</para>
                /// </summary>
                [NameInMap("ComponentBizType")]
                [Validation(Required=false)]
                public string ComponentBizType { get; set; }

                /// <summary>
                /// <para>The exposed component.</para>
                /// 
                /// <b>Example:</b>
                /// <para>openssh</para>
                /// </summary>
                [NameInMap("ComponentName")]
                [Validation(Required=false)]
                public string ComponentName { get; set; }

                /// <summary>
                /// <para>The version of the exposed component.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8.7p1</para>
                /// </summary>
                [NameInMap("ComponentVersion")]
                [Validation(Required=false)]
                public string ComponentVersion { get; set; }

                /// <summary>
                /// <para>The exposed port.</para>
                /// 
                /// <b>Example:</b>
                /// <para>22</para>
                /// </summary>
                [NameInMap("ListenPort")]
                [Validation(Required=false)]
                public string ListenPort { get; set; }

            }

            /// <summary>
            /// <para>The public IP address exposed on the Internet.</para>
            /// 
            /// <b>Example:</b>
            /// <para>116.12.XX.XX</para>
            /// </summary>
            [NameInMap("ExposureIp")]
            [Validation(Required=false)]
            public string ExposureIp { get; set; }

            /// <summary>
            /// <para>The port exposed on the Internet.</para>
            /// 
            /// <b>Example:</b>
            /// <para>22</para>
            /// </summary>
            [NameInMap("ExposurePort")]
            [Validation(Required=false)]
            public string ExposurePort { get; set; }

            /// <summary>
            /// <para>The expose type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>INTERNET_IP</b>: public IP addresses of Elastic Compute Service (ECS) instances</para>
            /// </description></item>
            /// <item><description><para><b>SLB</b>: public IP address of a load balancing SLB instance</para>
            /// </description></item>
            /// <item><description><para><b>EIP</b>: elastic IP address (EIP)</para>
            /// </description></item>
            /// <item><description><para><b>DNAT</b>: NAT gateway that uses the DNAT feature to connect to the Internet</para>
            /// </description></item>
            /// <item><description><para><b>DB_CONNECTION</b>: public network connection of a database.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>INTERNET_IP</para>
            /// </summary>
            [NameInMap("ExposureType")]
            [Validation(Required=false)]
            public string ExposureType { get; set; }

            /// <summary>
            /// <para>The instance ID that corresponds to the expose type. Different expose types correspond to different instance IDs. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>If ExposureType is <b>INTERNET_IP</b>: the value is empty.</description></item>
            /// <item><description>If ExposureType is <b>SLB</b>: the value is the ID of the load balancing public instance.</description></item>
            /// <item><description>If ExposureType is <b>EIP</b>: the value is the ID of the EIP instance.</description></item>
            /// <item><description>If ExposureType is <b>DNAT</b>: the value is the ID of the NAT gateway instance.</description></item>
            /// <item><description>If ExposureType is <b>DB_CONNECTION</b>: the value is the ID of the database instance.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>i-ew11313a****</para>
            /// </summary>
            [NameInMap("ExposureTypeId")]
            [Validation(Required=false)]
            public string ExposureTypeId { get; set; }

            /// <summary>
            /// <para>The ID of the server group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9469268</para>
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public long? GroupId { get; set; }

            /// <summary>
            /// <para>The name of the server group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testGroup</para>
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// <para>The instance ID of the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-bp1g6wxdwps7s9dz****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The name of the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>abc_centos7.2_005</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The public IP address of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>116.12.XX.XX</para>
            /// </summary>
            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            /// <summary>
            /// <para>The private IP address of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.XX.XX</para>
            /// </summary>
            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }

            /// <summary>
            /// <para>The number of medium-severity vulnerabilities exposed on the Internet that can be exploited by attackers.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("LaterVulCount")]
            [Validation(Required=false)]
            public int? LaterVulCount { get; set; }

            /// <summary>
            /// <para>The number of low-severity vulnerabilities exposed on the Internet that can be exploited by attackers.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("NntfVulCount")]
            [Validation(Required=false)]
            public int? NntfVulCount { get; set; }

            /// <summary>
            /// <para>The ID of the region where the asset resides.</para>
            /// <remarks>
            /// <para>For the mapping between region IDs and region names, see <a href="https://help.aliyun.com/document_detail/40654.html">Regions and zones</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The total number of vulnerabilities exposed on the Internet that can be exploited by attackers.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("TotalVulCount")]
            [Validation(Required=false)]
            public int? TotalVulCount { get; set; }

            /// <summary>
            /// <para>The UUID of the server or the instance ID of the cloud service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dd803d9e-a337-4add-9c5b-7d503e08****</para>
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeExposedInstanceListResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeExposedInstanceListResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The number of entries returned on the current page in a paged query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The page number of the current page in a paged query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The maximum number of entries per page in a paged query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of Internet-exposed assets.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID, which is a unique identifier generated by Alibaba Cloud for the request. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>598A4A61-ABA7-456B-8725-7378258276D9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
