// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeExposedInstanceListRequest : TeaModel {
        /// <summary>
        /// <para>The asset type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: ECS</para>
        /// </description></item>
        /// <item><description><para><b>3</b>: RDS</para>
        /// </description></item>
        /// <item><description><para><b>4</b>: MONGODB</para>
        /// </description></item>
        /// <item><description><para><b>5</b>: RDS-Redis.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("AssetType")]
        [Validation(Required=false)]
        public string AssetType { get; set; }

        /// <summary>
        /// <para>Specifies whether the asset that you want to query has Cloud Security Posture Management (CSPM) risks. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The asset has CSPM risks.</description></item>
        /// <item><description><b>false</b>: The asset does not have CSPM risks.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("CspmStatus")]
        [Validation(Required=false)]
        public bool? CspmStatus { get; set; }

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
        /// <para>The name of the system component exposed on the Internet that you want to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>openssl</para>
        /// </summary>
        [NameInMap("ExposureComponent")]
        [Validation(Required=false)]
        public string ExposureComponent { get; set; }

        /// <summary>
        /// <para>The type of the exposed component.</para>
        /// 
        /// <b>Example:</b>
        /// <para>system_service</para>
        /// </summary>
        [NameInMap("ExposureComponentBizType")]
        [Validation(Required=false)]
        public string ExposureComponentBizType { get; set; }

        /// <summary>
        /// <para>The public IP address of the server type or the public network connection address of the database type that you want to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>116.12.XX.XX</para>
        /// </summary>
        [NameInMap("ExposureIp")]
        [Validation(Required=false)]
        public string ExposureIp { get; set; }

        /// <summary>
        /// <para>The exposed port that you want to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>22</para>
        /// </summary>
        [NameInMap("ExposurePort")]
        [Validation(Required=false)]
        public string ExposurePort { get; set; }

        /// <summary>
        /// <para>The ID of the server group that you want to query.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~DescribeAllGroups~~">DescribeAllGroups</a> operation to query server group IDs.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>9535356</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public long? GroupId { get; set; }

        /// <summary>
        /// <para>Specifies whether the asset that you want to query has baseline weak password risks. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The asset has baseline weak password risks.</description></item>
        /// <item><description><b>false</b>: The asset does not have baseline weak password risks.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("HealthStatus")]
        [Validation(Required=false)]
        public bool? HealthStatus { get; set; }

        /// <summary>
        /// <para>The instance ID of the asset that you want to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp1g6wxdwps7s9dz****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The name of the asset that you want to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abc_centos7.2_005</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The number of entries per page in a paged query. Default value: 20. If you leave this parameter empty, 20 entries are returned per page.</para>
        /// <remarks>
        /// <para>Do not leave PageSize empty.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud account ID of the member accounts in the resource folder.</para>
        /// <remarks>
        /// <para>You can invoke the <a href="~~DescribeMonitorAccounts~~">DescribeMonitorAccounts</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>16670360956*****</para>
        /// </summary>
        [NameInMap("ResourceDirectoryAccountId")]
        [Validation(Required=false)]
        public long? ResourceDirectoryAccountId { get; set; }

        /// <summary>
        /// <para>Specifies whether the asset that you want to query has vulnerabilities. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The asset has vulnerabilities.</description></item>
        /// <item><description><b>false</b>: The asset does not have vulnerabilities.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("VulStatus")]
        [Validation(Required=false)]
        public bool? VulStatus { get; set; }

    }

}
