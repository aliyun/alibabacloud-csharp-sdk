// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class GetChatappPhoneNumberMetricRequest : TeaModel {
        /// <summary>
        /// <para>The space ID of the RAM user within the ISV account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>293483938849493</para>
        /// </summary>
        [NameInMap("CustSpaceId")]
        [Validation(Required=false)]
        public string CustSpaceId { get; set; }

        /// <summary>
        /// <para>The end of the time range to query.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1693407714687</para>
        /// </summary>
        [NameInMap("End")]
        [Validation(Required=false)]
        public long? End { get; set; }

        /// <summary>
        /// <para>The granularity of the metric.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>DAILY</description></item>
        /// <item><description>HALF_HOUR</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DAILY</para>
        /// </summary>
        [NameInMap("Granularity")]
        [Validation(Required=false)]
        public string Granularity { get; set; }

        /// <summary>
        /// <para>The independent software vendor (ISV) verification code, which is used to verify whether the RAM user is authorized by the ISV account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>skdi3kksloslikdkkdk</para>
        /// </summary>
        [NameInMap("IsvCode")]
        [Validation(Required=false)]
        public string IsvCode { get; set; }

        /// <summary>
        /// <para>The business phone number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>861380000</para>
        /// </summary>
        [NameInMap("PhoneNumber")]
        [Validation(Required=false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1693107714687</para>
        /// </summary>
        [NameInMap("Start")]
        [Validation(Required=false)]
        public long? Start { get; set; }

    }

}
