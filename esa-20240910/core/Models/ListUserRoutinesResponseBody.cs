// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListUserRoutinesResponseBody : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("QuotaRoutineNumber")]
        [Validation(Required=false)]
        public long? QuotaRoutineNumber { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Routines")]
        [Validation(Required=false)]
        public List<ListUserRoutinesResponseBodyRoutines> Routines { get; set; }
        public class ListUserRoutinesResponseBodyRoutines : TeaModel {
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("DefaultRelatedRecord")]
            [Validation(Required=false)]
            public string DefaultRelatedRecord { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("HasAssets")]
            [Validation(Required=false)]
            public bool? HasAssets { get; set; }

            [NameInMap("RoutineName")]
            [Validation(Required=false)]
            public string RoutineName { get; set; }

        }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        [NameInMap("UsedRoutineNumber")]
        [Validation(Required=false)]
        public long? UsedRoutineNumber { get; set; }

    }

}
