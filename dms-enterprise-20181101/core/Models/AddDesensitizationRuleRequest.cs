// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class AddDesensitizationRuleRequest : TeaModel {
        /// <summary>
        /// The parameters of the algorithm.
        /// </summary>
        [NameInMap("FunctionParams")]
        [Validation(Required=false)]
        public List<Dictionary<string, string>> FunctionParams { get; set; }

        /// <summary>
        /// The type of the masking algorithm.
        /// 
        /// Valid values:
        /// 
        /// *   FIX_POS : masks characters in the specified position.
        /// *   DATE_ROUNDING: rounds the date.
        /// *   PLAINTEXT: does not mask data.
        /// *   SHA1: masks characters by using the secure hash algorithm 1 (SHA-1)
        /// *   HMAC: masks characters by using the hash-based message authentication code (HMAC).
        /// *   STRING_TRANSFORM: shift characters.
        /// *   NUMBER_ROUNDING: rounds numbers.
        /// *   AES: masks characters by using the advanced encryption standard (AES) algorithm.
        /// *   SHA256: masks characters by using SHA-256 algorithm.
        /// *   DES: masks characters by using the data encryption standard (DES) algorithm.
        /// *   MAP_REPLACE: masks the mapped data.
        /// *   FIX_CHAR: masks fixed characters.
        /// *   DEFAULT: masks all characters.
        /// *   RANDOM_REPLACE: randomly replaces characters.
        /// *   MD5: masks characters by using the MD5 algorithm.
        /// </summary>
        [NameInMap("FunctionType")]
        [Validation(Required=false)]
        public string FunctionType { get; set; }

        /// <summary>
        /// The description of the rule.
        /// </summary>
        [NameInMap("RuleDescription")]
        [Validation(Required=false)]
        public string RuleDescription { get; set; }

        /// <summary>
        /// The name of the rule.
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// The masking algorithm.
        /// 
        /// Valid values:
        /// 
        /// *   PLAINTEXT
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        /// *   TRANSFORM
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        /// *   ENCRYPT
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        /// *   REPLACE
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        /// *   HASH
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        /// *   MASK
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// </summary>
        [NameInMap("RuleType")]
        [Validation(Required=false)]
        public string RuleType { get; set; }

        /// <summary>
        /// The tenant ID.
        /// 
        /// >  To view the ID of the tenant, move the pointer over the profile picture in the upper-right corner of the Data Management (DMS) console. For more information, see the [View information about the current tenant](~~181330~~) section of the "Manage DMS tenants" topic.
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
