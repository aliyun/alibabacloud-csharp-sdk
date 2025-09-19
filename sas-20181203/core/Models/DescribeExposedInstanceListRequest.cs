// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeExposedInstanceListRequest : TeaModel {
        /// <summary>
        /// <para>The type of the asset. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: an Elastic Compute Service (ECS) instance.</description></item>
        /// <item><description><b>3</b>: an ApsaraDB RDS instance.</description></item>
        /// <item><description><b>4</b>: an ApsaraDB for MongoDB instance.</description></item>
        /// <item><description><b>5</b>: an ApsaraDB for Redis instance.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("AssetType")]
        [Validation(Required=false)]
        public string AssetType { get; set; }

        /// <summary>
        /// <para>Specifies whether the asset has Cloud Security Posture Management (CSPM) risks. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("CspmStatus")]
        [Validation(Required=false)]
        public bool? CspmStatus { get; set; }

        /// <summary>
        /// <para>The number of the page to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The server component that is exposed on the Internet.</para>
        /// 
        /// <b>Example:</b>
        /// <para>openssl</para>
        /// </summary>
        [NameInMap("ExposureComponent")]
        [Validation(Required=false)]
        public string ExposureComponent { get; set; }

        /// <summary>
        /// <para>Expose component type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>system_service</para>
        /// </summary>
        [NameInMap("ExposureComponentBizType")]
        [Validation(Required=false)]
        public string ExposureComponentBizType { get; set; }

        /// <summary>
        /// <para>The public IP address of the server or the public endpoint of the database.</para>
        /// 
        /// <b>Example:</b>
        /// <para>116.12.XX.XX</para>
        /// </summary>
        [NameInMap("ExposureIp")]
        [Validation(Required=false)]
        public string ExposureIp { get; set; }

        /// <summary>
        /// <para>The port that is exposed on the Internet.</para>
        /// 
        /// <b>Example:</b>
        /// <para>22</para>
        /// </summary>
        [NameInMap("ExposurePort")]
        [Validation(Required=false)]
        public string ExposurePort { get; set; }

        /// <summary>
        /// <para>The ID of the server group.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~DescribeAllGroups~~">DescribeAllGroups</a> operation to query the IDs of server groups.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>9535356</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public long? GroupId { get; set; }

        /// <summary>
        /// <para>Specifies whether the asset has weak password risks. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Unhealthy</para>
        /// </summary>
        [NameInMap("HealthStatus")]
        [Validation(Required=false)]
        public bool? HealthStatus { get; set; }

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
        /// <para>The number of entries to return on each page. Default value: 20. If you leave this parameter empty, 20 entries are returned on each page.</para>
        /// <remarks>
        /// <para> We recommend that you do not leave this parameter empty.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud account ID of the member in the resource directory.</para>
        /// <remarks>
        /// <para> You can call the <a href="~~DescribeMonitorAccounts~~">DescribeMonitorAccounts</a> operation to obtain the ID.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>16670360956*****</para>
        /// </summary>
        [NameInMap("ResourceDirectoryAccountId")]
        [Validation(Required=false)]
        public long? ResourceDirectoryAccountId { get; set; }

        /// <summary>
        /// <para>Specifies whether the asset has vulnerabilities. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
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
