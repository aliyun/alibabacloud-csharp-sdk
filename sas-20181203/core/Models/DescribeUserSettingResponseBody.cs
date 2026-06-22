// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeUserSettingResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of alert notification levels. If the list is empty, no alerts are generated for custom policies.</para>
        /// </summary>
        [NameInMap("AlertLevels")]
        [Validation(Required=false)]
        public List<string> AlertLevels { get; set; }

        /// <summary>
        /// <para>The number of days to retain invalid alerts.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("InvalidWarningKeepDays")]
        [Validation(Required=false)]
        public int? InvalidWarningKeepDays { get; set; }

        /// <summary>
        /// <para>The ID of the request. Alibaba Cloud generates a unique identifier for each request. You can use the ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>09969D2C-4FAD-429E-BFBF-9A60DEF8****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
