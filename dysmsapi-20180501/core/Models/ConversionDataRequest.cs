// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20180501.Models
{
    public class ConversionDataRequest : TeaModel {
        /// <summary>
        /// Conversion rate monitoring return value.
        /// 
        /// >  The value of this parameter is of type double, and the value is between [0,1].
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ConversionRate")]
        [Validation(Required=false)]
        public string ConversionRate { get; set; }

        /// <summary>
        /// Timestamp of the conversion rate observation should be a Unix timestamp, a millisecond-level long integer.
        /// 
        /// >  If this field is not specified: the current timestamp is the default.
        /// </summary>
        [NameInMap("ReportTime")]
        [Validation(Required=false)]
        public long? ReportTime { get; set; }

    }

}
