// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicecatalog20210901.Models
{
    public class CreateConstraintResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the constraint.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cons-bp1yx7x42v****</para>
        /// </summary>
        [NameInMap("ConstraintId")]
        [Validation(Required=false)]
        public string ConstraintId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0FEEF92D-4052-5202-87D0-3D8EC16F81BF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
