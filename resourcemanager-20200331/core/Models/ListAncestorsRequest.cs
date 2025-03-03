// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class ListAncestorsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the child folder.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fd-i1c9nr****</para>
        /// </summary>
        [NameInMap("ChildId")]
        [Validation(Required=false)]
        public string ChildId { get; set; }

    }

}
