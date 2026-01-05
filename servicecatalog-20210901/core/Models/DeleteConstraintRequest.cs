// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicecatalog20210901.Models
{
    public class DeleteConstraintRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the constraint.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cons-bp1yx7x42v****</para>
        /// </summary>
        [NameInMap("ConstraintId")]
        [Validation(Required=false)]
        public string ConstraintId { get; set; }

    }

}
