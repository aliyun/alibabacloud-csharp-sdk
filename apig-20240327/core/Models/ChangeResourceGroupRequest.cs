// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ChangeResourceGroupRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the destination resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aekzdrfx2xdnaja</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The resource ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gw-ct4i14um1hkn0tpqfae0</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// <para>The resource type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gateway</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The service name. Set this parameter to apig.</para>
        /// 
        /// <b>Example:</b>
        /// <para>apig</para>
        /// </summary>
        [NameInMap("Service")]
        [Validation(Required=false)]
        public string Service { get; set; }

    }

}
