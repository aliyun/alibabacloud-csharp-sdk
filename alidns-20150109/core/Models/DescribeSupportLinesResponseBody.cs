// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeSupportLinesResponseBody : TeaModel {
        /// <summary>
        /// 云解析线路列表。
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
                /// 2021-12-06T02:47:26.000+0000
                /// </summary>
                [NameInMap("FatherCode")]
                [Validation(Required=false)]
                public string FatherCode { get; set; }

                /// <summary>
                /// 子线路Code。
                /// </summary>
                [NameInMap("LineCode")]
                [Validation(Required=false)]
                public string LineCode { get; set; }

                /// <summary>
                /// 父线路展示名称。
                /// </summary>
                [NameInMap("LineDisplayName")]
                [Validation(Required=false)]
                public string LineDisplayName { get; set; }

                /// <summary>
                /// 子线路展示名称。
                /// </summary>
                [NameInMap("LineName")]
                [Validation(Required=false)]
                public string LineName { get; set; }

            }

        }

        /// <summary>
        /// 请求ID。
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
