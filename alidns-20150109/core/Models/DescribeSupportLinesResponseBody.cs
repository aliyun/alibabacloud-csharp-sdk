// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeSupportLinesResponseBody : TeaModel {
        /// <summary>
        /// The list of Alibaba Cloud DNS lines.
        /// </summary>
        [NameInMap("RecordLines")]
        [Validation(Required=false)]
        public DescribeSupportLinesResponseBodyRecordLines RecordLines { get; set; }
        public class DescribeSupportLinesResponseBodyRecordLines : TeaModel {
            [NameInMap("RecordLine")]
            [Validation(Required=false)]
            public List<DescribeSupportLinesResponseBodyRecordLinesRecordLine> RecordLine { get; set; }
            public class DescribeSupportLinesResponseBodyRecordLinesRecordLine : TeaModel {
                /// <summary>
                /// The code of the parent line. Leave it blank if there is no parent line.
                /// </summary>
                [NameInMap("FatherCode")]
                [Validation(Required=false)]
                public string FatherCode { get; set; }

                /// <summary>
                /// The code of the child line.
                /// </summary>
                [NameInMap("LineCode")]
                [Validation(Required=false)]
                public string LineCode { get; set; }

                /// <summary>
                /// The name of the parent line.
                /// </summary>
                [NameInMap("LineDisplayName")]
                [Validation(Required=false)]
                public string LineDisplayName { get; set; }

                /// <summary>
                /// The name of the child line.
                /// </summary>
                [NameInMap("LineName")]
                [Validation(Required=false)]
                public string LineName { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
