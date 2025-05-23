// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi_intl20211015.Models
{
    public class BackendCallSignalRequest : TeaModel {
        /// <summary>
        /// <para>The phone number that receives the voice notification.</para>
        /// <para>You must add the country code to the beginning of the phone number. Example: 85200\<em>\</em>\*\*00.</para>
        /// 
        /// <b>Example:</b>
        /// <para>852****0000</para>
        /// </summary>
        [NameInMap("CalledNumber")]
        [Validation(Required=false)]
        public string CalledNumber { get; set; }

        /// <summary>
        /// <para>The calling number.</para>
        /// <para>If you do not specify this parameter, the system uses a local random number as the display number. If you use a dedicated number for outbound calls, you must specify the purchased number. You can specify only one number. You can log on to the VMS console and choose Number Management to view the purchased phone numbers.</para>
        /// 
        /// <b>Example:</b>
        /// <para>852****0000</para>
        /// </summary>
        [NameInMap("CallerIdNumber")]
        [Validation(Required=false)]
        public string CallerIdNumber { get; set; }

        /// <summary>
        /// <para>The ISO2 country code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HK</para>
        /// </summary>
        [NameInMap("CountryId")]
        [Validation(Required=false)]
        public string CountryId { get; set; }

        /// <summary>
        /// <para>The ID reserved for the caller. This ID is returned to the caller in a receipt message.</para>
        /// <para>The value must be of the STRING type and 1 to 15 bytes in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>22522****</para>
        /// </summary>
        [NameInMap("OutId")]
        [Validation(Required=false)]
        public string OutId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The number of times the voice notification is played back in a call. Valid values: 1 to 3. Default value: 3.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("PlayTimes")]
        [Validation(Required=false)]
        public long? PlayTimes { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The playback speed. Valid values: -500 to 500.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Speed")]
        [Validation(Required=false)]
        public long? Speed { get; set; }

        /// <summary>
        /// <para>The ID of the approved voice verification code template.</para>
        /// <para>You can log on to the VMS console and choose Voice Call Template to view the template ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1001</para>
        /// </summary>
        [NameInMap("TtsCode")]
        [Validation(Required=false)]
        public string TtsCode { get; set; }

        /// <summary>
        /// <para>The variables in the template, in the JSON format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;code&quot;:&quot;1234&quot;}</para>
        /// </summary>
        [NameInMap("TtsParam")]
        [Validation(Required=false)]
        public string TtsParam { get; set; }

        /// <summary>
        /// <para>The playback volume of the voice notification. Valid values: 0 to 100. Default value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("Volume")]
        [Validation(Required=false)]
        public long? Volume { get; set; }

    }

}
