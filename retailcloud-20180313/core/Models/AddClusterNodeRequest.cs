/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Retailcloud20180313.Models
{
    public class AddClusterNodeRequest : TeaModel {
        [NameInMap("ClusterInstanceId")]
        [Validation(Required=false)]
        public string ClusterInstanceId { get; set; }

        [NameInMap("EcsInstanceIdList")]
        [Validation(Required=false)]
        public List<string> EcsInstanceIdList { get; set; }

    }

}
