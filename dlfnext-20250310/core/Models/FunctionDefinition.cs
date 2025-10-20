// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class FunctionDefinition : TeaModel {
        /// <summary>
        /// <para>required in FileFunctionDefinition</para>
        /// </summary>
        [NameInMap("className")]
        [Validation(Required=false)]
        public string ClassName { get; set; }

        /// <summary>
        /// <para>required in SQLFunctionDefinition/LambdaFunctionDefinition</para>
        /// </summary>
        [NameInMap("definition")]
        [Validation(Required=false)]
        public string Definition { get; set; }

        /// <summary>
        /// <para>required in FileFunctionDefinition</para>
        /// </summary>
        [NameInMap("fileResources")]
        [Validation(Required=false)]
        public List<FunctionFileResource> FileResources { get; set; }

        /// <summary>
        /// <para>required in FileFunctionDefinition</para>
        /// </summary>
        [NameInMap("functionName")]
        [Validation(Required=false)]
        public string FunctionName { get; set; }

        /// <summary>
        /// <para>required in LambdaFunctionDefinition/FileFunctionDefinition</para>
        /// </summary>
        [NameInMap("language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
