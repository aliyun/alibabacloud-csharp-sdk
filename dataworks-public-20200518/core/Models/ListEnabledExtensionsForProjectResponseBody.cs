// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListEnabledExtensionsForProjectResponseBody : TeaModel {
        /// <summary>
        /// The details of the extension.
        /// </summary>
        [NameInMap("Extensions")]
        [Validation(Required=false)]
        public List<ListEnabledExtensionsForProjectResponseBodyExtensions> Extensions { get; set; }
        public class ListEnabledExtensionsForProjectResponseBodyExtensions : TeaModel {
            /// <summary>
            /// The creator of the extension.
            /// </summary>
            [NameInMap("CreateUser")]
            [Validation(Required=false)]
            public string CreateUser { get; set; }

            /// <summary>
            /// The unique code of the extension.
            /// </summary>
            [NameInMap("ExtensionCode")]
            [Validation(Required=false)]
            public string ExtensionCode { get; set; }

            /// <summary>
            /// The description of the extension.
            /// </summary>
            [NameInMap("ExtensionDesc")]
            [Validation(Required=false)]
            public string ExtensionDesc { get; set; }

            /// <summary>
            /// The name of the extension.
            /// </summary>
            [NameInMap("ExtensionName")]
            [Validation(Required=false)]
            public string ExtensionName { get; set; }

            /// <summary>
            /// The modifier of the extension.
            /// </summary>
            [NameInMap("ModifyUser")]
            [Validation(Required=false)]
            public string ModifyUser { get; set; }

            /// <summary>
            /// The owner ID.
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// The parameter settings of the extension. For more information, see [Configure extension parameters](https://help.aliyun.com/document_detail/405354.html).
            /// </summary>
            [NameInMap("ParameterSetting")]
            [Validation(Required=false)]
            public string ParameterSetting { get; set; }

            /// <summary>
            /// The tenant ID.
            /// </summary>
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public long? TenantId { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
