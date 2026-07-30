// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ChangeResourceGroupRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the destination resource group. You can view resource group IDs in the Resource Management console.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aekzuqyxxxxxxxx</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The ID of the resource to be moved. The value must match the specified ResourceType.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gw-cq2vmc93km41m3dm4bg0</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// <para>The resource type. The value is case-sensitive and must exactly match one of the valid values.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Gateway</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The cloud service identifier. Fixed as APIG. You generally do not need to specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>APIG</para>
        /// </summary>
        [NameInMap("Service")]
        [Validation(Required=false)]
        public string Service { get; set; }

    }

}
