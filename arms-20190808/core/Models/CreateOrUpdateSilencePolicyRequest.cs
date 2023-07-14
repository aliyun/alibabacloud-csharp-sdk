// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class CreateOrUpdateSilencePolicyRequest : TeaModel {
        /// <summary>
        /// The ID of the silence policy.
        /// 
        /// *   If you do not configure this parameter, a new silence policy is created.
        /// *   If you configure this parameter, the specified silence policy is modified.
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// The matching rules. The following code shows the format of matching rules:
        /// 
        ///     [
        ///          {
        ///     	 "matchingConditions": [
        ///     	 {
        ///     	 "value": "test", // The value of the matching condition. 
        ///     	 "key": "altertname", // The key of the matching condition. 
        ///     	 "operator": "eq" // The logical operator of the matching condition, including eq (equal to), neq (not equal to), in (contains), nin (does not contain), re (regular expression match), and nre (regular expression mismatch).   
        ///     	 }
        ///     	 ]
        ///          }
        ///     	 ]
        /// </summary>
        [NameInMap("MatchingRules")]
        [Validation(Required=false)]
        public string MatchingRules { get; set; }

        /// <summary>
        /// The name of the silence policy.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
