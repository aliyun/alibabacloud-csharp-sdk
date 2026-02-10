// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class CreateDigitalSignOrderShrinkRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>示例值示例值</para>
        /// </summary>
        [NameInMap("ExtendMessage")]
        [Validation(Required=false)]
        public string ExtendMessage { get; set; }

        [NameInMap("OrderContext")]
        [Validation(Required=false)]
        public string OrderContextShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CREATE_DIGITALSMS_SIGN</para>
        /// </summary>
        [NameInMap("OrderType")]
        [Validation(Required=false)]
        public string OrderType { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>41</para>
        /// </summary>
        [NameInMap("QualificationId")]
        [Validation(Required=false)]
        public long? QualificationId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>49</para>
        /// </summary>
        [NameInMap("QualificationVersion")]
        [Validation(Required=false)]
        public long? QualificationVersion { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("SignId")]
        [Validation(Required=false)]
        public long? SignId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SignIndustry")]
        [Validation(Required=false)]
        public long? SignIndustry { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>示例值示例值</para>
        /// </summary>
        [NameInMap("SignName")]
        [Validation(Required=false)]
        public string SignName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SignSource")]
        [Validation(Required=false)]
        public long? SignSource { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>110000001750080</para>
        /// </summary>
        [NameInMap("Submitter")]
        [Validation(Required=false)]
        public string Submitter { get; set; }

    }

}
