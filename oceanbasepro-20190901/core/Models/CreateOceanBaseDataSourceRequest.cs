// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class CreateOceanBaseDataSourceRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>cluster_name</para>
        /// </summary>
        [NameInMap("Cluster")]
        [Validation(Required=false)]
        public string Cluster { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="http://xxx.xxx.xxx.2:2883/services?Action=ObRootServiceInfo&User_ID=alibaba&UID=ocpmaster&ObRegion=ob_1***29.admin">http://xxx.xxx.xxx.2:2883/services?Action=ObRootServiceInfo&amp;User_ID=alibaba&amp;UID=ocpmaster&amp;ObRegion=ob_1***29.admin</a></para>
        /// </summary>
        [NameInMap("ConfigUrl")]
        [Validation(Required=false)]
        public string ConfigUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>pas***</para>
        /// </summary>
        [NameInMap("DrcPassword")]
        [Validation(Required=false)]
        public string DrcPassword { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>user_na***</para>
        /// </summary>
        [NameInMap("DrcUserName")]
        [Validation(Required=false)]
        public string DrcUserName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>in***</para>
        /// </summary>
        [NameInMap("InnerDrcPassword")]
        [Validation(Required=false)]
        public string InnerDrcPassword { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxx.xxx.xxx.1</para>
        /// </summary>
        [NameInMap("Ip")]
        [Validation(Required=false)]
        public string Ip { get; set; }

        /// <summary>
        /// <para>LogProxy IP。</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("LogProxyIp")]
        [Validation(Required=false)]
        public string LogProxyIp { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("LogProxyPort")]
        [Validation(Required=false)]
        public string LogProxyPort { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>source_name</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pass_word</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2883</para>
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public int? Port { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tenant_name</para>
        /// </summary>
        [NameInMap("Tenant")]
        [Validation(Required=false)]
        public string Tenant { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OB_MYSQL_VPC</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user_name</para>
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>vpc-bp1d2q3mhg9i23ofi****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
