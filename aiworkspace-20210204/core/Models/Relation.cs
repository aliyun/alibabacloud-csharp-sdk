// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class Relation : TeaModel {
        /// <summary>
        /// <para>ErrMsg</para>
        /// </summary>
        [NameInMap("ErrMsg")]
        [Validation(Required=false)]
        public string ErrMsg { get; set; }

        /// <summary>
        /// <para>LineageRelation</para>
        /// </summary>
        [NameInMap("LineageRelation")]
        [Validation(Required=false)]
        public LineageRelation LineageRelation { get; set; }

        /// <summary>
        /// <para>Result</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public bool? Result { get; set; }

    }

}
