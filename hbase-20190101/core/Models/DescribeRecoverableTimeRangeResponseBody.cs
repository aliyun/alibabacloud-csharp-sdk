// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class DescribeRecoverableTimeRangeResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>A1A51D18-96DC-465C-9F1B-47180CA22524</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2020-10-26T18:02:03Z</para>
        /// </summary>
        [NameInMap("TimeBegin")]
        [Validation(Required=false)]
        public string TimeBegin { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2020-11-05T01:20:31Z</para>
        /// </summary>
        [NameInMap("TimeEnd")]
        [Validation(Required=false)]
        public string TimeEnd { get; set; }

    }

}
