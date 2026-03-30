// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VoiceNavigator20251111.Models
{
    public class DeleteVariableRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>0099b75d-60fd-4c63-8541-7fbba0ae6bb0</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0099b75d-60fd-4c63-8541-7fbba0ae6bb1</para>
        /// </summary>
        [NameInMap("VariableId")]
        [Validation(Required=false)]
        public string VariableId { get; set; }

    }

}
