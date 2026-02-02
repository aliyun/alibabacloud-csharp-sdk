// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class ModifyInstancesSSLRequest : TeaModel {
        /// <summary>
        /// <para>The certificate type. Only <b>custom</b> is supported.</para>
        /// <remarks>
        /// <para> This parameter is required if <b>SSLEnabled</b> is set to <b>1</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>custom</para>
        /// </summary>
        [NameInMap("CAType")]
        [Validation(Required=false)]
        public string CAType { get; set; }

        /// <summary>
        /// <para>The information about the RDS Supabase instances that you want to configure. You can specify up to 10 instances.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[
        ///     &quot;ra-supabase-xxx&quot;,
        ///     &quot;ra-supabase-xxx&quot;
        ///   ]</para>
        /// </summary>
        [NameInMap("InstanceNames")]
        [Validation(Required=false)]
        public List<string> InstanceNames { get; set; }

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
        /// <para>Enables or disables SSL. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: enable</description></item>
        /// <item><description><b>0</b>: disable</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SSLEnabled")]
        [Validation(Required=false)]
        public int? SSLEnabled { get; set; }

        /// <summary>
        /// <para>The content of the custom certificate.</para>
        /// <remarks>
        /// <para> This parameter is required if <b>CAType</b> is set to <b>custom</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>-----BEGIN CERTIFICATE-----MIID*****QqEP-----END CERTIFICATE-----</para>
        /// </summary>
        [NameInMap("ServerCert")]
        [Validation(Required=false)]
        public string ServerCert { get; set; }

        /// <summary>
        /// <para>The private key of the certificate.</para>
        /// <remarks>
        /// <para> This parameter is required if <b>CAType</b> is set to <b>custom</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>-----BEGIN PRIVATE KEY-----MIIE****ihfg==-----END PRIVATE KEY-----</para>
        /// </summary>
        [NameInMap("ServerKey")]
        [Validation(Required=false)]
        public string ServerKey { get; set; }

    }

}
