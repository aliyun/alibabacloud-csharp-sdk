// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class WebNetworkConfig : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable Internet access for the application. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: enables Internet access.</description></item>
        /// <item><description><b>false</b>: disables Internet access.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("InternetAccess")]
        [Validation(Required=false)]
        public bool? InternetAccess { get; set; }

        /// <summary>
        /// <para>The ID of a security group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sg-bp18hj1wtxgy3b0***</para>
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// <para>The list of vSwitches.</para>
        /// </summary>
        [NameInMap("VSwitchIds")]
        [Validation(Required=false)]
        public List<string> VSwitchIds { get; set; }

    }

}
