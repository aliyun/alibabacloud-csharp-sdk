// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class ModifyInstancesSSLShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The certificate type. Currently, only <b>custom</b> is supported, which indicates a custom certificate.</para>
        /// <remarks>
        /// <para>This parameter is required when <b>SSLEnabled</b> is set to <b>1</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>custom</para>
        /// </summary>
        [NameInMap("CAType")]
        [Validation(Required=false)]
        public string CAType { get; set; }

        /// <summary>
        /// <para>The list of instance IDs of AI applications. A maximum of 10 instance IDs are supported.</para>
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
        public string InstanceNamesShrink { get; set; }

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
        /// <para>Specifies whether to enable or disable SSL. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Enable.</description></item>
        /// <item><description><b>0</b>: Disable.</description></item>
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
        /// <para>The custom certificate content.</para>
        /// <remarks>
        /// <para>This parameter is required when <b>CAType</b> is set to <b>custom</b>.</para>
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
        /// <para>This parameter is required when <b>CAType</b> is set to <b>custom</b>.</para>
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
