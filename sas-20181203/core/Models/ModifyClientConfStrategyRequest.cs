// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyClientConfStrategyRequest : TeaModel {
        /// <summary>
        /// The key of the tag that is added to the agent configuration policy.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public string Tag { get; set; }

        /// <summary>
        /// The extended tag of the agent configuration policy.
        /// </summary>
        [NameInMap("TagExt")]
        [Validation(Required=false)]
        public string TagExt { get; set; }

        /// <summary>
        /// The value of the tag that is added to the agent configuration policy.
        /// 
        /// *   major
        /// *   advanced
        /// *   basic
        /// </summary>
        [NameInMap("TagValue")]
        [Validation(Required=false)]
        public string TagValue { get; set; }

        /// <summary>
        /// The UUID of the server that you want to query.
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

        /// <summary>
        /// The UUID of the asset. You can specify a maximum of 500 UUIDs at a time.
        /// </summary>
        [NameInMap("Uuids")]
        [Validation(Required=false)]
        public List<string> Uuids { get; set; }

    }

}
