// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class UpdateSlsLogStoreRequest : TeaModel {
        /// <summary>
        /// The ID of the application. You can call the ListApplication operation to query the application ID. For more information, see [ListApplication](~~149390~~).
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// The configurations of the Logstore.
        /// 
        /// *   The following parameters are included in the configurations:****
        /// 
        ///     *   **type**: the collection type. Set this parameter to file to specify the file type. Set this parameter to stdout to specify the standard output type.
        /// 
        ///     *   **logstore**: the name of the Logstore. Make sure that the name of the Logstore is unique in the cluster. The name must comply with the following rules:
        /// 
        ///         *   The name can contain only lowercase letters, digits, hyphens (-), and underscores (\_).
        ///         *   The name must start and end with a lowercase letter or a digit.
        ///         *   The name must be 3 to 63 characters in length.
        /// 
        ///         **
        /// 
        ///         **Note**If you leave this parameter empty, the system automatically generates a name.
        /// 
        ///     *   **LogDir**: If the standard output type is used, the collection path is stdout.log. If the file type is used, the collection path is the path of the collected file. Wildcards (\*) are supported. The collection path must match the following regular expression: `^/(.+)/(.*)^/$`.
        /// </summary>
        [NameInMap("Configs")]
        [Validation(Required=false)]
        public string Configs { get; set; }

    }

}
