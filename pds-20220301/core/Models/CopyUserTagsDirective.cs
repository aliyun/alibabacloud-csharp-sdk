// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class CopyUserTagsDirective : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>all, include, none, exclude</para>
        /// </summary>
        [NameInMap("directive")]
        [Validation(Required=false)]
        public string Directive { get; set; }

        [NameInMap("keys")]
        [Validation(Required=false)]
        public List<string> Keys { get; set; }

    }

}
