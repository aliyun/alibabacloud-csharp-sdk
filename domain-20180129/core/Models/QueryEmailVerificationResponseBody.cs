// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class QueryEmailVerificationResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>42.<em>.</em>.31</para>
        /// </summary>
        [NameInMap("ConfirmIp")]
        [Validation(Required=false)]
        public string ConfirmIp { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="mailto:abc@aliyun.com">abc@aliyun.com</a></para>
        /// </summary>
        [NameInMap("Email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>72b36ba0572e423bbb3f19640896****</para>
        /// </summary>
        [NameInMap("EmailVerificationNo")]
        [Validation(Required=false)]
        public string EmailVerificationNo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2019-02-19 16:38:07</para>
        /// </summary>
        [NameInMap("GmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2019-02-19 16:40:38</para>
        /// </summary>
        [NameInMap("GmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>FC4F7D02-8A83-4E37-B935-2D48A1B8423E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>42.<em>.</em>.115</para>
        /// </summary>
        [NameInMap("SendIp")]
        [Validation(Required=false)]
        public string SendIp { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2019-02-19 16:38:07</para>
        /// </summary>
        [NameInMap("TokenSendTime")]
        [Validation(Required=false)]
        public string TokenSendTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>140692647406****</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("VerificationStatus")]
        [Validation(Required=false)]
        public int? VerificationStatus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2019-02-19 16:40:38</para>
        /// </summary>
        [NameInMap("VerificationTime")]
        [Validation(Required=false)]
        public string VerificationTime { get; set; }

    }

}
