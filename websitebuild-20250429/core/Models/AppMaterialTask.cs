// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class AppMaterialTask : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2025-12-26 11:30:05</para>
        /// </summary>
        [NameInMap("CompleteTime")]
        [Validation(Required=false)]
        public string CompleteTime { get; set; }

        [NameInMap("CompleteTimeFormat")]
        [Validation(Required=false)]
        public string CompleteTimeFormat { get; set; }

        [NameInMap("FailReason")]
        [Validation(Required=false)]
        public string FailReason { get; set; }

        [NameInMap("FinalFileUrls")]
        [Validation(Required=false)]
        public List<string> FinalFileUrls { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>RUNNING</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>PENDING</para>
        /// </summary>
        [NameInMap("SubStatus")]
        [Validation(Required=false)]
        public string SubStatus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2025-12-26 11:30:05</para>
        /// </summary>
        [NameInMap("SubmitTime")]
        [Validation(Required=false)]
        public string SubmitTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>81d04d62c3483b32bacf1d306d2622b2</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        [NameInMap("TaskParam")]
        [Validation(Required=false)]
        public string TaskParam { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>IMAGE_LOGO</para>
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}
