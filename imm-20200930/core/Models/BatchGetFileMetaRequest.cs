// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class BatchGetFileMetaRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("DatasetName")]
        [Validation(Required=false)]
        public string DatasetName { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("URIs")]
        [Validation(Required=false)]
        public List<string> URIs { get; set; }

        [NameInMap("WithFields")]
        [Validation(Required=false)]
        public List<string> WithFields { get; set; }

    }

}
