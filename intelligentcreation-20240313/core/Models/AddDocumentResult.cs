// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20240313.Models
{
    public class AddDocumentResult : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>example.pdf</para>
        /// </summary>
        [NameInMap("docName")]
        [Validation(Required=false)]
        public string DocName { get; set; }

        [NameInMap("documentInfo")]
        [Validation(Required=false)]
        public DocumentInfo DocumentInfo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
