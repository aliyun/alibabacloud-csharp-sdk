// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class ListUserKubeConfigStatesResponseBody : TeaModel {
        [NameInMap("page")]
        [Validation(Required=false)]
        public ListUserKubeConfigStatesResponseBodyPage Page { get; set; }
        public class ListUserKubeConfigStatesResponseBodyPage : TeaModel {
            [NameInMap("page_number")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            [NameInMap("page_size")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("total_count")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        [NameInMap("states")]
        [Validation(Required=false)]
        public List<ListUserKubeConfigStatesResponseBodyStates> States { get; set; }
        public class ListUserKubeConfigStatesResponseBodyStates : TeaModel {
            [NameInMap("cert_expire_time")]
            [Validation(Required=false)]
            public string CertExpireTime { get; set; }

            [NameInMap("cert_state")]
            [Validation(Required=false)]
            public string CertState { get; set; }

            [NameInMap("cluster_id")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            [NameInMap("cluster_name")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            [NameInMap("cluster_state")]
            [Validation(Required=false)]
            public string ClusterState { get; set; }

        }

    }

}
