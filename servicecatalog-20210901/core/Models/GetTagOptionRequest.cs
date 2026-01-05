// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicecatalog20210901.Models
{
    public class GetTagOptionRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the tag option.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tag-bp1r3mxq3t****</para>
        /// </summary>
        [NameInMap("TagOptionId")]
        [Validation(Required=false)]
        public string TagOptionId { get; set; }

    }

}
