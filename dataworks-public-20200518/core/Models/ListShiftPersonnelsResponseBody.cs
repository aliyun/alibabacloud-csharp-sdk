// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListShiftPersonnelsResponseBody : TeaModel {
        [NameInMap("Paging")]
        [Validation(Required=false)]
        public ListShiftPersonnelsResponseBodyPaging Paging { get; set; }
        public class ListShiftPersonnelsResponseBodyPaging : TeaModel {
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("ShiftPersons")]
            [Validation(Required=false)]
            public List<ListShiftPersonnelsResponseBodyPagingShiftPersons> ShiftPersons { get; set; }
            public class ListShiftPersonnelsResponseBodyPagingShiftPersons : TeaModel {
                public long? BeginTime { get; set; }
                public long? EndTime { get; set; }
                public string ShiftPersonName { get; set; }
                public string ShiftPersonUID { get; set; }
            }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
        };

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
