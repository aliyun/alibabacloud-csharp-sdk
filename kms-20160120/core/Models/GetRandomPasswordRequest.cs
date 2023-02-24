// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class GetRandomPasswordRequest : TeaModel {
        /// <summary>
        /// The characters that are not included in the password to be generated.
        /// 
        /// Valid values:
        /// 
        /// ` Valid characters: 0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ! \"#$%&\"()*+,-. /:;<=>? @[\] your_project_id} ~  `.
        /// 
        /// This parameter is empty by default.
        /// </summary>
        [NameInMap("ExcludeCharacters")]
        [Validation(Required=false)]
        public string ExcludeCharacters { get; set; }

        /// <summary>
        /// Specifies whether to exclude lowercase letters.
        /// 
        /// Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("ExcludeLowercase")]
        [Validation(Required=false)]
        public string ExcludeLowercase { get; set; }

        /// <summary>
        /// Specifies whether to exclude digits.
        /// 
        /// Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("ExcludeNumbers")]
        [Validation(Required=false)]
        public string ExcludeNumbers { get; set; }

        /// <summary>
        /// Specifies whether to exclude special characters.
        /// 
        /// Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("ExcludePunctuation")]
        [Validation(Required=false)]
        public string ExcludePunctuation { get; set; }

        /// <summary>
        /// Specifies whether to exclude uppercase letters.
        /// 
        /// Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("ExcludeUppercase")]
        [Validation(Required=false)]
        public string ExcludeUppercase { get; set; }

        /// <summary>
        /// The number of bytes that the password to be generated contains.
        /// 
        /// Valid values: 8 to 128.
        /// 
        /// Default value: 32
        /// </summary>
        [NameInMap("PasswordLength")]
        [Validation(Required=false)]
        public string PasswordLength { get; set; }

        /// <summary>
        /// Specifies whether to include all the preceding character types.
        /// 
        /// Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("RequireEachIncludedType")]
        [Validation(Required=false)]
        public string RequireEachIncludedType { get; set; }

    }

}
