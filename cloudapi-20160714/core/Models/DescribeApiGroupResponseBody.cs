// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeApiGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The root path of the API.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/qqq</para>
        /// </summary>
        [NameInMap("BasePath")]
        [Validation(Required=false)]
        public string BasePath { get; set; }

        /// <summary>
        /// <para>The billing status of the API group.</para>
        /// <list type="bullet">
        /// <item><description><b>NORMAL</b>: The API group is normal.</description></item>
        /// <item><description><b>LOCKED</b>: The API group is locked due to overdue payments.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>NORMAL</para>
        /// </summary>
        [NameInMap("BillingStatus")]
        [Validation(Required=false)]
        public string BillingStatus { get; set; }

        /// <summary>
        /// <para>The products on Alibaba Cloud Marketplace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("CloudMarketCommodity")]
        [Validation(Required=false)]
        public bool? CloudMarketCommodity { get; set; }

        /// <summary>
        /// <para>The CloudMonitor application group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>217008423</para>
        /// </summary>
        [NameInMap("CmsMonitorGroup")]
        [Validation(Required=false)]
        public string CmsMonitorGroup { get; set; }

        /// <summary>
        /// <para>The list of associated tags. Separate multiple tags with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>depart:dep1</para>
        /// </summary>
        [NameInMap("CompatibleFlags")]
        [Validation(Required=false)]
        public string CompatibleFlags { get; set; }

        /// <summary>
        /// <para>The creation time (UTC) of the API group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2016-08-01T06:53:02Z</para>
        /// </summary>
        [NameInMap("CreatedTime")]
        [Validation(Required=false)]
        public string CreatedTime { get; set; }

        /// <summary>
        /// <para>The custom appcode configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;location&quot;:&quot;HEADER&quot;,&quot;name&quot;:&quot;myAppCodeHeader&quot;}</para>
        /// </summary>
        [NameInMap("CustomAppCodeConfig")]
        [Validation(Required=false)]
        public string CustomAppCodeConfig { get; set; }

        [NameInMap("CustomDomains")]
        [Validation(Required=false)]
        public DescribeApiGroupResponseBodyCustomDomains CustomDomains { get; set; }
        public class DescribeApiGroupResponseBodyCustomDomains : TeaModel {
            [NameInMap("DomainItem")]
            [Validation(Required=false)]
            public List<DescribeApiGroupResponseBodyCustomDomainsDomainItem> DomainItem { get; set; }
            public class DescribeApiGroupResponseBodyCustomDomainsDomainItem : TeaModel {
                [NameInMap("BindStageAlias")]
                [Validation(Required=false)]
                public string BindStageAlias { get; set; }

                [NameInMap("BindStageName")]
                [Validation(Required=false)]
                public string BindStageName { get; set; }

                [NameInMap("CertificateId")]
                [Validation(Required=false)]
                public string CertificateId { get; set; }

                [NameInMap("CertificateName")]
                [Validation(Required=false)]
                public string CertificateName { get; set; }

                [NameInMap("CertificateValidEnd")]
                [Validation(Required=false)]
                public long? CertificateValidEnd { get; set; }

                [NameInMap("CertificateValidStart")]
                [Validation(Required=false)]
                public long? CertificateValidStart { get; set; }

                [NameInMap("ClientCertSDnPassThrough")]
                [Validation(Required=false)]
                public bool? ClientCertSDnPassThrough { get; set; }

                [NameInMap("CustomDomainType")]
                [Validation(Required=false)]
                public string CustomDomainType { get; set; }

                [NameInMap("DomainBindingStatus")]
                [Validation(Required=false)]
                public string DomainBindingStatus { get; set; }

                [NameInMap("DomainCNAMEStatus")]
                [Validation(Required=false)]
                public string DomainCNAMEStatus { get; set; }

                [NameInMap("DomainLegalStatus")]
                [Validation(Required=false)]
                public string DomainLegalStatus { get; set; }

                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                [NameInMap("DomainRemark")]
                [Validation(Required=false)]
                public string DomainRemark { get; set; }

                [NameInMap("DomainWebSocketStatus")]
                [Validation(Required=false)]
                public string DomainWebSocketStatus { get; set; }

                [NameInMap("IsHttpRedirectToHttps")]
                [Validation(Required=false)]
                public bool? IsHttpRedirectToHttps { get; set; }

                [NameInMap("SslOcspCacheEnable")]
                [Validation(Required=false)]
                public bool? SslOcspCacheEnable { get; set; }

                [NameInMap("SslOcspEnable")]
                [Validation(Required=false)]
                public bool? SslOcspEnable { get; set; }

                [NameInMap("SslVerifyDepth")]
                [Validation(Required=false)]
                public int? SslVerifyDepth { get; set; }

                [NameInMap("WildcardDomainPatterns")]
                [Validation(Required=false)]
                public string WildcardDomainPatterns { get; set; }

            }

        }

        /// <summary>
        /// <para>The custom trace configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;parameterLocation\&quot;:\&quot;HEADER\&quot;,\&quot;parameterName\&quot;:\&quot;traceId\&quot;}</para>
        /// </summary>
        [NameInMap("CustomTraceConfig")]
        [Validation(Required=false)]
        public string CustomTraceConfig { get; set; }

        /// <summary>
        /// <para>The list of custom configuration items.</para>
        /// 
        /// <b>Example:</b>
        /// <para>removeResponseServerHeader</para>
        /// </summary>
        [NameInMap("CustomerConfigs")]
        [Validation(Required=false)]
        public string CustomerConfigs { get; set; }

        /// <summary>
        /// <para>The type of exclusive instance where the group is located</para>
        /// <list type="bullet">
        /// <item><description>VPC fusion type exclusive instance: vpc_connect</description></item>
        /// <item><description>Traditional type exclusive instance: normal</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>normal</para>
        /// </summary>
        [NameInMap("DedicatedInstanceType")]
        [Validation(Required=false)]
        public string DedicatedInstanceType { get; set; }

        /// <summary>
        /// <para>The default domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mkt.api.gaore.com</para>
        /// </summary>
        [NameInMap("DefaultDomain")]
        [Validation(Required=false)]
        public string DefaultDomain { get; set; }

        /// <summary>
        /// <para>The description of the API group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>New weather informations.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Indicates whether access over the public second-level domain name is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DisableInnerDomain")]
        [Validation(Required=false)]
        public bool? DisableInnerDomain { get; set; }

        /// <summary>
        /// <para>The ID of the API group. This ID is generated by the system and globally unique.</para>
        /// 
        /// <b>Example:</b>
        /// <para>523e8dc7bbe04613b5b1d726c2a7889d</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The name of the group to which the API belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NewWeather</para>
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// <para>The HTTPS policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HTTPS2_TLS1_0</para>
        /// </summary>
        [NameInMap("HttpsPolicy")]
        [Validation(Required=false)]
        public string HttpsPolicy { get; set; }

        /// <summary>
        /// <para>The validity status of the API group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>NORMAL</b>: The API group is normal.</description></item>
        /// <item><description><b>LOCKED</b>: The API group is locked because it is not valid.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>NORMAL</para>
        /// </summary>
        [NameInMap("IllegalStatus")]
        [Validation(Required=false)]
        public string IllegalStatus { get; set; }

        /// <summary>
        /// <para>The ID of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>apigateway-cn-v6419k43xxxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The type of the instance.</para>
        /// <list type="bullet">
        /// <item><description>CLASSIC_SHARED: shared instance that uses the classic network configuration</description></item>
        /// <item><description>VPC_SHARED: shared instance that uses VPC</description></item>
        /// <item><description>VPC_DEDICATED: dedicated instance that uses VPC</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>VPC_SHARED</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>The IPv6 status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UNBIND</para>
        /// </summary>
        [NameInMap("Ipv6Status")]
        [Validation(Required=false)]
        public string Ipv6Status { get; set; }

        /// <summary>
        /// <para>The reason for the failure of the group migration instance task. When the value of the MigrationStatus parameter is Failed, it is not empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The current instance conflicts with the target instance.</para>
        /// </summary>
        [NameInMap("MigrationError")]
        [Validation(Required=false)]
        public string MigrationError { get; set; }

        /// <summary>
        /// <para>Group migration instance task status</para>
        /// <list type="bullet">
        /// <item><description>Running</description></item>
        /// <item><description>Success</description></item>
        /// <item><description>Failed</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Fail</para>
        /// </summary>
        [NameInMap("MigrationStatus")]
        [Validation(Required=false)]
        public string MigrationStatus { get; set; }

        /// <summary>
        /// <para>The last modification time (UTC) of the API group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2016-08-01T06:54:32Z</para>
        /// </summary>
        [NameInMap("ModifiedTime")]
        [Validation(Required=false)]
        public string ModifiedTime { get; set; }

        /// <summary>
        /// <para>Specifies whether to pass headers.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eagleeye-rpcid,x-b3-traceid</para>
        /// </summary>
        [NameInMap("PassthroughHeaders")]
        [Validation(Required=false)]
        public string PassthroughHeaders { get; set; }

        /// <summary>
        /// <para>The region to which the API group belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>03442A3D-3B7D-434C-8A95-A5FEB989B519</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StageItems")]
        [Validation(Required=false)]
        public DescribeApiGroupResponseBodyStageItems StageItems { get; set; }
        public class DescribeApiGroupResponseBodyStageItems : TeaModel {
            [NameInMap("StageInfo")]
            [Validation(Required=false)]
            public List<DescribeApiGroupResponseBodyStageItemsStageInfo> StageInfo { get; set; }
            public class DescribeApiGroupResponseBodyStageItemsStageInfo : TeaModel {
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("StageId")]
                [Validation(Required=false)]
                public string StageId { get; set; }

                [NameInMap("StageName")]
                [Validation(Required=false)]
                public string StageName { get; set; }

            }

        }

        /// <summary>
        /// <para>The status of the API group.</para>
        /// <list type="bullet">
        /// <item><description><b>NORMAL</b>: The API group is normal.</description></item>
        /// <item><description><b>DELETE</b>: The API group is deleted.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>NORMAL</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The second-level domain name automatically assigned to the API group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>27d50c0f2e54b359919923d908bb015-cn-hangzhou.alicloudapi.com</para>
        /// </summary>
        [NameInMap("SubDomain")]
        [Validation(Required=false)]
        public string SubDomain { get; set; }

        /// <summary>
        /// <para>The upper QPS limit of the API group. The default value is 500. You can increase the upper limit by submitting an application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("TrafficLimit")]
        [Validation(Required=false)]
        public int? TrafficLimit { get; set; }

        /// <summary>
        /// <para>The user log settings.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;requestBody\&quot;:true,\&quot;responseBody\&quot;:true,\&quot;queryString\&quot;:\&quot;test\&quot;,\&quot;requestHeaders\&quot;:\&quot;test\&quot;,\&quot;responseHeaders\&quot;:\&quot;test\&quot;,\&quot;jwtClaims\&quot;:\&quot;test\&quot;}</para>
        /// </summary>
        [NameInMap("UserLogConfig")]
        [Validation(Required=false)]
        public string UserLogConfig { get; set; }

        /// <summary>
        /// <para>The VPC domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e4<em><em><b>7151954</b></em>acbd9f7</em>***1058a-ap-southeast-1-vpc.alicloudapi.com</para>
        /// </summary>
        [NameInMap("VpcDomain")]
        [Validation(Required=false)]
        public string VpcDomain { get; set; }

        /// <summary>
        /// <para>The VPC SLB domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>257e9d450e924d00b976b0ecfb7184c2-cn-beijing-intranet.alicloudapi.com</para>
        /// </summary>
        [NameInMap("VpcSlbIntranetDomain")]
        [Validation(Required=false)]
        public string VpcSlbIntranetDomain { get; set; }

    }

}
