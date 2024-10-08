// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class CreateHanaInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The alert settings. Valid value: INHERITED, which indicates that the Cloud Backup client sends alert notifications by using the same method configured for the backup vault.</para>
        /// 
        /// <b>Example:</b>
        /// <para>INHERITED</para>
        /// </summary>
        [NameInMap("AlertSetting")]
        [Validation(Required=false)]
        public string AlertSetting { get; set; }

        /// <summary>
        /// <para>The name of the Resource Access Management (RAM) role that is created within the source Alibaba Cloud account and assigned to the current Alibaba Cloud account to authorize the current Alibaba Cloud account to back up data across Alibaba Cloud accounts.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hbrcrossrole</para>
        /// </summary>
        [NameInMap("CrossAccountRoleName")]
        [Validation(Required=false)]
        public string CrossAccountRoleName { get; set; }

        /// <summary>
        /// <para>The backup type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>SELF_ACCOUNT</b>: Data is backed up within the same Alibaba Cloud account.</description></item>
        /// <item><description><b>CROSS_ACCOUNT</b>: Data is backed up across Alibaba Cloud accounts.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CROSS_ACCOUNT</para>
        /// </summary>
        [NameInMap("CrossAccountType")]
        [Validation(Required=false)]
        public string CrossAccountType { get; set; }

        /// <summary>
        /// <para>The ID of the source Alibaba Cloud account that authorizes the current Alibaba Cloud account to back up data across Alibaba Cloud accounts.</para>
        /// 
        /// <b>Example:</b>
        /// <para>158975xxxxx4625</para>
        /// </summary>
        [NameInMap("CrossAccountUserId")]
        [Validation(Required=false)]
        public long? CrossAccountUserId { get; set; }

        /// <summary>
        /// <para>The IDs of the ECS instances that host the SAP HANA instance to be registered. Cloud Backup installs backup clients on the specified ECS instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[\&quot;i-uf6ir9y******hvisj\&quot;]</para>
        /// </summary>
        [NameInMap("EcsInstanceId")]
        [Validation(Required=false)]
        public string EcsInstanceId { get; set; }

        /// <summary>
        /// <para>The name of the SAP HANA instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HANA-DEV</para>
        /// </summary>
        [NameInMap("HanaName")]
        [Validation(Required=false)]
        public string HanaName { get; set; }

        /// <summary>
        /// <para>The private or internal IP address of the host where the primary node of the SAP HANA instance resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>47.100.XX.XX</para>
        /// </summary>
        [NameInMap("Host")]
        [Validation(Required=false)]
        public string Host { get; set; }

        /// <summary>
        /// <para>The instance number of the SAP HANA system.</para>
        /// 
        /// <b>Example:</b>
        /// <para>00</para>
        /// </summary>
        [NameInMap("InstanceNumber")]
        [Validation(Required=false)]
        public int? InstanceNumber { get; set; }

        /// <summary>
        /// <para>The password that is used to connect with the SAP HANA database.</para>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfm4ebtpkzx7zy</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The security identifier (SID) of the SAP HANA database. For more information, see <a href="https://answers.sap.com/questions/555192/how-to-find-sid-user-and-instance-number-of-hana-d.html?spm=a2c4g.11186623.0.0.55c34b4ftZeXNK">How to find sid user and instance number of HANA db?</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HXE</para>
        /// </summary>
        [NameInMap("Sid")]
        [Validation(Required=false)]
        public string Sid { get; set; }

        /// <summary>
        /// <para>Specifies whether to connect with the SAP HANA database over Secure Sockets Layer (SSL).</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("UseSsl")]
        [Validation(Required=false)]
        public bool? UseSsl { get; set; }

        /// <summary>
        /// <para>The username of the SYSTEMDB database.</para>
        /// 
        /// <b>Example:</b>
        /// <para>admin</para>
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

        /// <summary>
        /// <para>Specifies whether to verify the SSL certificate of the SAP HANA database.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ValidateCertificate")]
        [Validation(Required=false)]
        public bool? ValidateCertificate { get; set; }

        /// <summary>
        /// <para>The ID of the backup vault.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v-0003v4a******gfv2</para>
        /// </summary>
        [NameInMap("VaultId")]
        [Validation(Required=false)]
        public string VaultId { get; set; }

    }

}
