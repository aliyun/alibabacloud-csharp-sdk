// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveDomainSnapshotDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B955107D-E658-4E77-B913-E0AC3D31693F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SnapshotDataInfos")]
        [Validation(Required=false)]
        public DescribeLiveDomainSnapshotDataResponseBodySnapshotDataInfos SnapshotDataInfos { get; set; }
        public class DescribeLiveDomainSnapshotDataResponseBodySnapshotDataInfos : TeaModel {
            [NameInMap("SnapshotDataInfo")]
            [Validation(Required=false)]
            public List<DescribeLiveDomainSnapshotDataResponseBodySnapshotDataInfosSnapshotDataInfo> SnapshotDataInfo { get; set; }
            public class DescribeLiveDomainSnapshotDataResponseBodySnapshotDataInfosSnapshotDataInfo : TeaModel {
                [NameInMap("Date")]
                [Validation(Required=false)]
                public string Date { get; set; }

                [NameInMap("Total")]
                [Validation(Required=false)]
                public int? Total { get; set; }

            }

        }

    }

}
