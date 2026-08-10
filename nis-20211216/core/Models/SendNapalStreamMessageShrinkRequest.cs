// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nis20211216.Models
{
    public class SendNapalStreamMessageShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The request configuration object.</para>
        /// </summary>
        [NameInMap("Configuration")]
        [Validation(Required=false)]
        public string ConfigurationShrink { get; set; }

        /// <summary>
        /// <para>The message object that contains user input and session context information.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string MessageShrink { get; set; }

        /// <summary>
        /// <para>The additional request information.</para>
        /// </summary>
        [NameInMap("Metadata")]
        [Validation(Required=false)]
        public string MetadataShrink { get; set; }

    }

}
