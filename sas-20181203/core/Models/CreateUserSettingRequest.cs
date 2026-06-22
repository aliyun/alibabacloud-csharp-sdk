// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateUserSettingRequest : TeaModel {
        /// <summary>
        /// <para>The list of alert notification levels.</para>
        /// 
        /// <b>Example:</b>
        /// <para>high,low</para>
        /// </summary>
        [NameInMap("AlertLevels")]
        [Validation(Required=false)]
        public string AlertLevels { get; set; }

        /// <summary>
        /// <para>The number of days to retain false positive alerts.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("InvalidWarningKeepDays")]
        [Validation(Required=false)]
        public int? InvalidWarningKeepDays { get; set; }

        /// <summary>
        /// <para>The IP address of the access source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>112.48.16.***</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

    }

}
