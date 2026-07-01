// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class ConversionDataIntlRequest : TeaModel {
        /// <summary>
        /// <para>The conversion rate monitoring value.</para>
        /// <remarks>
        /// <para>This parameter is of the double type. Valid values: [0,1].</para>
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
        /// <para>The point in time when the conversion rate is observed. The value must be a Unix timestamp in milliseconds, represented as a long integer.</para>
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
