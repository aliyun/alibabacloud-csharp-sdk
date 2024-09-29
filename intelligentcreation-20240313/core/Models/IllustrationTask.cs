// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20240313.Models
{
    public class IllustrationTask : TeaModel {
        [NameInMap("gmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        [NameInMap("gmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        [NameInMap("illustrationIds")]
        [Validation(Required=false)]
        public List<long?> IllustrationIds { get; set; }

        [NameInMap("illustrationTaskId")]
        [Validation(Required=false)]
        public long? IllustrationTaskId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("taskStatus")]
        [Validation(Required=false)]
        public string TaskStatus { get; set; }

        [NameInMap("textId")]
        [Validation(Required=false)]
        public long? TextId { get; set; }

    }

}
