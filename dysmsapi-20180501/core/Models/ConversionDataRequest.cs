// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20180501.Models
{
    public class ConversionDataRequest : TeaModel {
        /// <summary>
        /// <para>Conversion rate monitoring return value.</para>
        /// <remarks>
        /// <para> The value of this parameter is of type double, and the value is between [0,1].</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.53</para>
        /// </summary>
        [NameInMap("ConversionRate")]
        [Validation(Required=false)]
        public string ConversionRate { get; set; }

        /// <summary>
        /// <para>Timestamp of the conversion rate observation should be a Unix timestamp, a millisecond-level long integer.</para>
        /// <remarks>
        /// <para> If this field is not specified: the current timestamp is the default.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1349055900000</para>
        /// </summary>
        [NameInMap("ReportTime")]
        [Validation(Required=false)]
        public long? ReportTime { get; set; }

    }

}
