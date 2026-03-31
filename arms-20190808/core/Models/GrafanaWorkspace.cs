// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class GrafanaWorkspace : TeaModel {
        /// <summary>
        /// <para>Indicates whether the workspace is commercialized.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("commercial")]
        [Validation(Required=false)]
        public bool? Commercial { get; set; }

        /// <summary>
        /// <para>The deployment mode of Grafana. You can ignore this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>asi</para>
        /// </summary>
        [NameInMap("deployType")]
        [Validation(Required=false)]
        public string DeployType { get; set; }

        /// <summary>
        /// <para>The description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Grafana for Production</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The time when the workspace expires.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1652803200000</para>
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public float? EndTime { get; set; }

        /// <summary>
        /// <para>The time when the workspace was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1642079398000</para>
        /// </summary>
        [NameInMap("gmtCreate")]
        [Validation(Required=false)]
        public float? GmtCreate { get; set; }

        /// <summary>
        /// <para>The version number of Grafana.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>8.2.x</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>10.0.x</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>9.0.x</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- --></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>9.0.x</para>
        /// </summary>
        [NameInMap("grafanaVersion")]
        [Validation(Required=false)]
        public string GrafanaVersion { get; set; }

        /// <summary>
        /// <para>The domain name of the workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-grafana.grafana.aliyuncs.com:443</para>
        /// </summary>
        [NameInMap("grafanaWorkspaceDomain")]
        [Validation(Required=false)]
        public string GrafanaWorkspaceDomain { get; set; }

        /// <summary>
        /// <para>status of workspace domain</para>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("grafanaWorkspaceDomainStatus")]
        [Validation(Required=false)]
        public string GrafanaWorkspaceDomainStatus { get; set; }

        /// <summary>
        /// <para>The version.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>standard：Standard Edition</para>
        /// </description></item>
        /// <item><description><para>personal_deition：Developer Edition</para>
        /// </description></item>
        /// <item><description><para>experts_edition：Expert Edition</para>
        /// </description></item>
        /// <item><description><para>advanced_edition：Advanced Edition</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>personal_edition、experts_edition、advanced_edition、standard</para>
        /// </summary>
        [NameInMap("grafanaWorkspaceEdition")]
        [Validation(Required=false)]
        public string GrafanaWorkspaceEdition { get; set; }

        /// <summary>
        /// <para>The ID of the workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>grafana-cn-4xl3g******</para>
        /// </summary>
        [NameInMap("grafanaWorkspaceId")]
        [Validation(Required=false)]
        public string GrafanaWorkspaceId { get; set; }

        /// <summary>
        /// <para>The public IP address and port number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>47.110.71.***:443</para>
        /// </summary>
        [NameInMap("grafanaWorkspaceIp")]
        [Validation(Required=false)]
        public string GrafanaWorkspaceIp { get; set; }

        /// <summary>
        /// <para>The workspace name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Grafana for Production</para>
        /// </summary>
        [NameInMap("grafanaWorkspaceName")]
        [Validation(Required=false)]
        public string GrafanaWorkspaceName { get; set; }

        /// <summary>
        /// <para>The maximum number of accounts.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("maxAccount")]
        [Validation(Required=false)]
        public string MaxAccount { get; set; }

        /// <summary>
        /// <para>The ID of the purchase order.</para>
        /// 
        /// <b>Example:</b>
        /// <para>grafana-cn-4xl3g******</para>
        /// </summary>
        [NameInMap("ntmId")]
        [Validation(Required=false)]
        public string NtmId { get; set; }

        /// <summary>
        /// <para>The personalized domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-grafana.grafana.aliyuncs.com:443</para>
        /// </summary>
        [NameInMap("personalDomain")]
        [Validation(Required=false)]
        public string PersonalDomain { get; set; }

        /// <summary>
        /// <para>The prefix of the personalized domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-grafana</para>
        /// </summary>
        [NameInMap("personalDomainPrefix")]
        [Validation(Required=false)]
        public string PersonalDomainPrefix { get; set; }

        /// <summary>
        /// <para>The private domain name of the workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-grafana.grafana.aliyuncs.com:80</para>
        /// </summary>
        [NameInMap("privateDomain")]
        [Validation(Required=false)]
        public string PrivateDomain { get; set; }

        /// <summary>
        /// <para>The private IP address and port number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.1.1</para>
        /// </summary>
        [NameInMap("privateIp")]
        [Validation(Required=false)]
        public string PrivateIp { get; set; }

        /// <summary>
        /// <para>The protocol type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>http、https</para>
        /// </summary>
        [NameInMap("protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        /// <summary>
        /// <para>The region ID of the disk.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aek2f4vzrfs6cla</para>
        /// </summary>
        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>Indicates whether the migration guide for the shared edition is provided.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("shareSynced")]
        [Validation(Required=false)]
        public bool? ShareSynced { get; set; }

        /// <summary>
        /// <para>The outbound IP address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>47.110.71.***</para>
        /// </summary>
        [NameInMap("snatIp")]
        [Validation(Required=false)]
        public string SnatIp { get; set; }

        /// <summary>
        /// <para>The status of the workspace.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>StartFailed：The workspace failed to be started</para>
        /// </description></item>
        /// <item><description><para>Stop：The workspace is stopped</para>
        /// </description></item>
        /// <item><description><para>Starting：The workspace is being started</para>
        /// </description></item>
        /// <item><description><para>DeleteFailed：The workspace failed to be deleted</para>
        /// </description></item>
        /// <item><description><para>Running：The workspace is running</para>
        /// </description></item>
        /// <item><description><para>DeleteSucceed：The workspace is deleted</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Starting、Running、Stop、DeleteSucceed</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The tags.</para>
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<GrafanaWorkspaceTags> Tags { get; set; }
        public class GrafanaWorkspaceTags : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The versions that are available for upgrades.</para>
        /// </summary>
        [NameInMap("upgradeVersion")]
        [Validation(Required=false)]
        public List<string> UpgradeVersion { get; set; }

        /// <summary>
        /// <para>The user ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1412143830******</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
