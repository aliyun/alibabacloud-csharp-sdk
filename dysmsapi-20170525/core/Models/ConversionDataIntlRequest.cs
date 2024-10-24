// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class ConversionDataIntlRequest : TeaModel {
        /// <summary>
        /// <para>The conversion rate.</para>
        /// <remarks>
        /// <para>The value of this parameter is a double, and ranges from 0 to 1.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.53</para>
        /// </summary>
        [NameInMap("ConversionRate")]
        [Validation(Required=false)]
        public string ConversionRate { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The time point at which the conversion rate is monitored. The value is a UNIX timestamp. Unit: milliseconds.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the current timestamp is used by default.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1349055900000</para>
        /// </summary>
        [NameInMap("ReportTime")]
        [Validation(Required=false)]
        public long? ReportTime { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
