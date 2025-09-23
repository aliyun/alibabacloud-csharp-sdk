// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Safconsole20210112.Models
{
    public class SendFeedbackRequest : TeaModel {
        [NameInMap("Reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

        /// <summary>
        /// <para>Sample labels. User-defined, separated by commas.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OTHERS</para>
        /// </summary>
        [NameInMap("RiskLabel")]
        [Validation(Required=false)]
        public string RiskLabel { get; set; }

        /// <summary>
        /// <para>Sample type. For phone number type samples, input PHONE; for email type samples, input EMAIL; for account type samples, input ACCOUNT.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PHONE</para>
        /// </summary>
        [NameInMap("SampleType")]
        [Validation(Required=false)]
        public string SampleType { get; set; }

        /// <summary>
        /// <para>Sample value.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000000000</para>
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
