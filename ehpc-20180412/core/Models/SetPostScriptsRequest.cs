// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class SetPostScriptsRequest : TeaModel {
        /// <summary>
        /// The cluster ID.
        /// 
        /// You can call the [ListClusters](~~87116~~) operation to obtain the cluster ID.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The post-processing scripts.
        /// </summary>
        [NameInMap("PostInstallScripts")]
        [Validation(Required=false)]
        public List<SetPostScriptsRequestPostInstallScripts> PostInstallScripts { get; set; }
        public class SetPostScriptsRequestPostInstallScripts : TeaModel {
            /// <summary>
            /// The parameter that is used to run the post-processing script.
            /// </summary>
            [NameInMap("Args")]
            [Validation(Required=false)]
            public string Args { get; set; }

            /// <summary>
            /// The URL that is used to download the post-processing script.
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// The ID of the region where the cluster resides. You can call the [ListRegions](~~188593~~) operation to query the latest region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
