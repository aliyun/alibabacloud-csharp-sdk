// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi_intl20211015.Models
{
    public class VoiceGroupCallShrinkRequest : TeaModel {
        [NameInMap("CalledNumber")]
        [Validation(Required=false)]
        public string CalledNumberShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>852****1111</para>
        /// </summary>
        [NameInMap("CallerIdNumber")]
        [Validation(Required=false)]
        public string CallerIdNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>HK</para>
        /// </summary>
        [NameInMap("CountryId")]
        [Validation(Required=false)]
        public string CountryId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>22596****</para>
        /// </summary>
        [NameInMap("OutId")]
        [Validation(Required=false)]
        public string OutId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
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
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SendType")]
        [Validation(Required=false)]
        public long? SendType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("Speed")]
        [Validation(Required=false)]
        public long? Speed { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>示例值示例值</para>
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2022-05-01T08:00:00+08:00</para>
        /// </summary>
        [NameInMap("TimingStart")]
        [Validation(Required=false)]
        public string TimingStart { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1****01</para>
        /// </summary>
        [NameInMap("TtsCode")]
        [Validation(Required=false)]
        public string TtsCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;code&quot;:&quot;1234&quot;}</para>
        /// </summary>
        [NameInMap("TtsParam")]
        [Validation(Required=false)]
        public string TtsParam { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2*****01</para>
        /// </summary>
        [NameInMap("VoiceCode")]
        [Validation(Required=false)]
        public string VoiceCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("Volume")]
        [Validation(Required=false)]
        public long? Volume { get; set; }

    }

}
