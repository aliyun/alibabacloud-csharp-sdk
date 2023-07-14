// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class ListOnCallSchedulesResponseBody : TeaModel {
        /// <summary>
        /// The objects that were returned.
        /// </summary>
        [NameInMap("PageBean")]
        [Validation(Required=false)]
        public ListOnCallSchedulesResponseBodyPageBean PageBean { get; set; }
        public class ListOnCallSchedulesResponseBodyPageBean : TeaModel {
            /// <summary>
            /// The information about the scheduling policy.
            /// </summary>
            [NameInMap("OnCallSchedules")]
            [Validation(Required=false)]
            public List<ListOnCallSchedulesResponseBodyPageBeanOnCallSchedules> OnCallSchedules { get; set; }
            public class ListOnCallSchedulesResponseBodyPageBeanOnCallSchedules : TeaModel {
                /// <summary>
                /// The description of the scheduling policy.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The ID of the scheduling policy.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// The name of the scheduling policy.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// The page number of the returned page.
            /// </summary>
            [NameInMap("Page")]
            [Validation(Required=false)]
            public long? Page { get; set; }

            /// <summary>
            /// The number of entries returned per page.
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// The total number of returned entries.
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
