// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class ModelSpecification : TeaModel {
        /// <summary>
        /// <para>The basic model information.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("MetaData")]
        [Validation(Required=false)]
        public MetaData MetaData { get; set; }

        /// <summary>
        /// <para>The model specification information.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Spec")]
        [Validation(Required=false)]
        public Spec Spec { get; set; }

    }

}
