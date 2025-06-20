// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class ChangeResourceGroupRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the resource group into which you want to change.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aekzyqdwnfabx6q</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The resource ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i118099391667548921125</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-wulanchabu</para>
        /// </summary>
        [NameInMap("ResourceRegionId")]
        [Validation(Required=false)]
        public string ResourceRegionId { get; set; }

        /// <summary>
        /// <para>The resource type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Node</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

    }

}
