// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20210202.Models
{
    public class MigrateExperimentFoldersResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>NO_PERMISSION</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("FolderIdMapping")]
        [Validation(Required=false)]
        public Dictionary<string, Dictionary<string, object>> FolderIdMapping { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>9CFA2665-1FFE-5929-8468-C14C25890486</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
