// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20180308.Models
{
    public class GetLineSplitResultRequest : TeaModel {
        [NameInMap("Line")]
        [Validation(Required=false)]
        public string Line { get; set; }

        [NameInMap("Prefix")]
        [Validation(Required=false)]
        public string Prefix { get; set; }

        [NameInMap("Regex")]
        [Validation(Required=false)]
        public string Regex { get; set; }

        [NameInMap("SelectContent")]
        [Validation(Required=false)]
        public string SelectContent { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>simple|regex</para>
        /// </summary>
        [NameInMap("SplitType")]
        [Validation(Required=false)]
        public string SplitType { get; set; }

    }

}
