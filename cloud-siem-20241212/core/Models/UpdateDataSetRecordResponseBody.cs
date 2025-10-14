// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class UpdateDataSetRecordResponseBody : TeaModel {
        [NameInMap("DataSetRecordStatistic")]
        [Validation(Required=false)]
        public UpdateDataSetRecordResponseBodyDataSetRecordStatistic DataSetRecordStatistic { get; set; }
        public class UpdateDataSetRecordResponseBodyDataSetRecordStatistic : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("NewDataSetRecordCount")]
            [Validation(Required=false)]
            public int? NewDataSetRecordCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("UpdateDataSetRecordCount")]
            [Validation(Required=false)]
            public int? UpdateDataSetRecordCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>9AAA9ED9-78F4-5021-86DC-D51C7511****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
