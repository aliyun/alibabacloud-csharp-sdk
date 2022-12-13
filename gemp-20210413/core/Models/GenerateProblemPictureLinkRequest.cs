// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class GenerateProblemPictureLinkRequest : TeaModel {
        /// <summary>
        /// oss key
        /// </summary>
        [NameInMap("keys")]
        [Validation(Required=false)]
        public List<string> Keys { get; set; }

        [NameInMap("problemId")]
        [Validation(Required=false)]
        public string ProblemId { get; set; }

    }

}
