// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class FreeResourceClusterControlItem : TeaModel {
        [NameInMap("ClusterID")]
        [Validation(Required=false)]
        public string ClusterID { get; set; }

        [NameInMap("ClusterName")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        [NameInMap("CrossClusters")]
        [Validation(Required=false)]
        public bool? CrossClusters { get; set; }

        [NameInMap("EnableFreeResource")]
        [Validation(Required=false)]
        public bool? EnableFreeResource { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>frcc-whateversth</para>
        /// </summary>
        [NameInMap("FreeResourceClusterControlId")]
        [Validation(Required=false)]
        public string FreeResourceClusterControlId { get; set; }

        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        [NameInMap("GmtModifyTime")]
        [Validation(Required=false)]
        public string GmtModifyTime { get; set; }

        [NameInMap("RegionID")]
        [Validation(Required=false)]
        public string RegionID { get; set; }

    }

}
