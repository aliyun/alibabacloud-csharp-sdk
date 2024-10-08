// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class UpdateHanaInstanceRequest : TeaModel {
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
        /// <para>The ID of the SAP HANA instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cl-000axjt******c6j8</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The name of the SAP HANA instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SAP-HANA-DEV</para>
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
        /// <para>This parameter is required.</para>
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
        /// <para>rg-aekzvx7d3c4kpny</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>Specifies whether to connect with the SAP HANA database over Secure Sockets Layer (SSL). Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The SAP HANA database is connected over SSL.</description></item>
        /// <item><description>false: The SAP HANA database is not connected over SSL.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
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
        /// <para>Specifies whether to verify the SSL certificate of the SAP HANA database. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The SSL certificate of the SAP HANA database is verified.</description></item>
        /// <item><description>false: The SSL certificate of the SAP HANA database is not verified.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ValidateCertificate")]
        [Validation(Required=false)]
        public bool? ValidateCertificate { get; set; }

        /// <summary>
        /// <para>The ID of the backup vault.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v-0003v4ah******9xp</para>
        /// </summary>
        [NameInMap("VaultId")]
        [Validation(Required=false)]
        public string VaultId { get; set; }

    }

}
