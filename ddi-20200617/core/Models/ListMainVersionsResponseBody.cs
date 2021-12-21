// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddi20200617.Models
{
    public class ListMainVersionsResponseBody : TeaModel {
        [NameInMap("MainVersionList")]
        [Validation(Required=false)]
        public List<ListMainVersionsResponseBodyMainVersionList> MainVersionList { get; set; }
        public class ListMainVersionsResponseBodyMainVersionList : TeaModel {
            [NameInMap("ClusterTypeInfoList")]
            [Validation(Required=false)]
            public List<ListMainVersionsResponseBodyMainVersionListClusterTypeInfoList> ClusterTypeInfoList { get; set; }
            public class ListMainVersionsResponseBodyMainVersionListClusterTypeInfoList : TeaModel {
                [NameInMap("ClusterType")]
                [Validation(Required=false)]
                public string ClusterType { get; set; }

            }

            [NameInMap("ExtraInfo")]
            [Validation(Required=false)]
            public string ExtraInfo { get; set; }

            [NameInMap("MainVersionName")]
            [Validation(Required=false)]
            public string MainVersionName { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
