// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicecatalog20210901.Models
{
    public class AssociateTagOptionWithResourceRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the resource with which the tag option is associated.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>port-bp15p96922****</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// <para>The ID of the tag option.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tag-bp1u6mdf3d****</para>
        /// </summary>
        [NameInMap("TagOptionId")]
        [Validation(Required=false)]
        public string TagOptionId { get; set; }

    }

}
