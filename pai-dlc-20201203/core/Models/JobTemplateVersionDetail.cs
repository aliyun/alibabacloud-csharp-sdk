// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class JobTemplateVersionDetail : TeaModel {
        [NameInMap("Constraints")]
        [Validation(Required=false)]
        public Dictionary<string, string> Constraints { get; set; }

        /// <summary>
        /// <para>Configuration content of the job template. It supports all parameter fields of the CreateJob API and is stored as a JSON object.</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>User ID that created this version</para>
        /// </summary>
        [NameInMap("CreatedBy")]
        [Validation(Required=false)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// <para>Creation time of this version</para>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ss.SSSZ</para>
        /// </summary>
        [NameInMap("GmtCreated")]
        [Validation(Required=false)]
        public string GmtCreated { get; set; }

        /// <summary>
        /// <para>Template version number</para>
        /// </summary>
        [NameInMap("Version")]
        [Validation(Required=false)]
        public int? Version { get; set; }

    }

}
