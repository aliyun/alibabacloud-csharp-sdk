// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appflow20230904.Models
{
    public class GenerateUserSessionTokenRequest : TeaModel {
        /// <summary>
        /// <para>AI Assistant ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>cb-069d508f9ab341b1****</para>
        /// </summary>
        [NameInMap("ChatbotId")]
        [Validation(Required=false)]
        public string ChatbotId { get; set; }

        /// <summary>
        /// <para>Expiration Time, in seconds, default 24 hours</para>
        /// 
        /// <b>Example:</b>
        /// <para>6000</para>
        /// </summary>
        [NameInMap("ExpireSecond")]
        [Validation(Required=false)]
        public long? ExpireSecond { get; set; }

        [NameInMap("ExtraInfo")]
        [Validation(Required=false)]
        public string ExtraInfo { get; set; }

        /// <summary>
        /// <para>Integration ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>cit-960f499au184m7****</para>
        /// </summary>
        [NameInMap("IntegrateId")]
        [Validation(Required=false)]
        public string IntegrateId { get; set; }

        /// <summary>
        /// <para>User Avatar (URL)</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://xxxx.com/xxx">https://xxxx.com/xxx</a></para>
        /// </summary>
        [NameInMap("UserAvatar")]
        [Validation(Required=false)]
        public string UserAvatar { get; set; }

        /// <summary>
        /// <para>User ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>929293312213****</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <para>User Nickname</para>
        /// 
        /// <b>Example:</b>
        /// <para>testxxx</para>
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
