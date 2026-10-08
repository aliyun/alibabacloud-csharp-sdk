// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeHASwitchConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The automatic primary/secondary switchover setting. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Auto</b>: The system automatically switches over between the primary and secondary instances upon a fault.</description></item>
        /// <item><description><b>Manual</b>: Automatic switchover has been temporarily disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Manual</para>
        /// </summary>
        [NameInMap("HAConfig")]
        [Validation(Required=false)]
        public string HAConfig { get; set; }

        /// <summary>
        /// <para>The deadline for the temporary disabling of automatic switchover. The time follows the ISO 8601 standard in the <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z format. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-08-29T15:00:00Z</para>
        /// </summary>
        [NameInMap("ManualHATime")]
        [Validation(Required=false)]
        public string ManualHATime { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4FDF4B79-2741-4C5F-8C76-4B953FC5C2B1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
