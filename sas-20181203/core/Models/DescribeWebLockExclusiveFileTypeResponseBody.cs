// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeWebLockExclusiveFileTypeResponseBody : TeaModel {
        [NameInMap("ExclusiveFileType")]
        [Validation(Required=false)]
        public List<string> ExclusiveFileType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>9CCD7D51-5E81-5FF5-BD74-813DDD248430</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
