// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IQS20241111.Models
{
    public class ScanFileOutput : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ECB2144C-E277-5434-80E6-12D26678D364</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of scan result objects.</para>
        /// </summary>
        [NameInMap("scanFileInfoList")]
        [Validation(Required=false)]
        public List<ScanFileInfo> ScanFileInfoList { get; set; }

        /// <summary>
        /// <para>The search execution information.</para>
        /// </summary>
        [NameInMap("searchInformation")]
        [Validation(Required=false)]
        public UnifiedSearchInformation SearchInformation { get; set; }

    }

}
