// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class ChangeResourceGroupOutput : TeaModel {
        /// <summary>
        /// <para>The ID of the new resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aek0example0abc0d</para>
        /// </summary>
        [NameInMap("NewResourceGroupId")]
        [Validation(Required=false)]
        public string NewResourceGroupId { get; set; }

        /// <summary>
        /// <para>The ID of the original resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aek0example0abc0d</para>
        /// </summary>
        [NameInMap("OldResourceGroupId")]
        [Validation(Required=false)]
        public string OldResourceGroupId { get; set; }

        /// <summary>
        /// <para>The ID of the resource whose resource group is changed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example-function-one</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

    }

}
