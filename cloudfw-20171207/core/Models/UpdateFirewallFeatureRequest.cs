// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class UpdateFirewallFeatureRequest : TeaModel {
        /// <summary>
        /// <para>The name of the feature to enable. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ApplicationControl</b>: application control.</description></item>
        /// <item><description><b>WebFilter</b>: web filtering.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ApplicationControl</para>
        /// </summary>
        [NameInMap("FeatureName")]
        [Validation(Required=false)]
        public string FeatureName { get; set; }

        /// <summary>
        /// <para>The feature status. The only valid value is <b>Enable</b>, which enables the feature. If you specify Disable or any other value, an error is returned. This operation is idempotent if the feature is already enabled.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Enable</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
