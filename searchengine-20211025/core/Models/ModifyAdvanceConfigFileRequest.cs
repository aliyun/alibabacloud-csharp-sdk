// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class ModifyAdvanceConfigFileRequest : TeaModel {
        /// <summary>
        /// The file content.
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// The variables.
        /// </summary>
        [NameInMap("variables")]
        [Validation(Required=false)]
        public Dictionary<string, VariablesValue> Variables { get; set; }

        /// <summary>
        /// The name of the file.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("fileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

    }

}
