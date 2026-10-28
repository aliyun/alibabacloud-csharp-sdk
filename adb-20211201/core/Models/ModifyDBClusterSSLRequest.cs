// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class ModifyDBClusterSSLRequest : TeaModel {
        /// <summary>
        /// <para>The internal or public endpoint for which to create or update a server certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amv-***********.ads.aliyuncs.com</para>
        /// </summary>
        [NameInMap("ConnectionString")]
        [Validation(Required=false)]
        public string ConnectionString { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amv-************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable SSL connection encryption. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Enabled.</description></item>
        /// <item><description><b>false</b>: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableSSL")]
        [Validation(Required=false)]
        public bool? EnableSSL { get; set; }

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
        /// <para>The SSL operation. This parameter and EnableSSL are mutually exclusive. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Enable: Enables SSL.</description></item>
        /// <item><description>Disable: Disables SSL.</description></item>
        /// <item><description>Update: Updates the validity period of an enabled SSL certificate and retains the current endpoint bound to the certificate. When you set this parameter to Update, do not specify ConnectionString, or specify an endpoint that is the same as the current endpoint bound to the certificate.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Update</para>
        /// </summary>
        [NameInMap("SSLEnabled")]
        [Validation(Required=false)]
        public string SSLEnabled { get; set; }

    }

}
