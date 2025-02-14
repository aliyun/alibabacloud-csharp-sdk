// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyHybridProxyPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The name of the proxy cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sas-proxy</para>
        /// </summary>
        [NameInMap("ClusterName")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        /// <summary>
        /// <para>The policy of the proxy cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[
        ///     {
        ///         &quot;policyType&quot;: &quot;limitFrequency&quot;,
        ///         &quot;info&quot;:
        ///         [
        ///             {
        ///                 &quot;type&quot;: &quot;file&quot;,
        ///                 &quot;config&quot;: &quot;10&quot;
        ///             }
        ///         ]
        ///     },
        ///     {
        ///         &quot;policyType&quot;: &quot;limitBandWidth&quot;,
        ///         &quot;info&quot;:
        ///         [
        ///             {
        ///                 &quot;type&quot;: &quot;net&quot;
        ///             },
        ///             {
        ///                 &quot;type&quot;: &quot;process&quot;
        ///             }
        ///         ]
        ///     }
        /// ]</para>
        /// </summary>
        [NameInMap("PolicyInfo")]
        [Validation(Required=false)]
        public string PolicyInfo { get; set; }

    }

}
