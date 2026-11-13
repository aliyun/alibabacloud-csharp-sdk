// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class UpdateAiModelSourceRequest : TeaModel {
        /// <summary>
        /// <para>The display name of the model source or model provider.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Model Studio model source</para>
        /// </summary>
        [NameInMap("displayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>The expected object version. Use the version returned by the most recent query.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("expectedVersion")]
        [Validation(Required=false)]
        public long? ExpectedVersion { get; set; }

        /// <summary>
        /// <para>The ID of the AI service bound to the model source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>svc-d00000000000000000000</para>
        /// </summary>
        [NameInMap("serviceId")]
        [Validation(Required=false)]
        public string ServiceId { get; set; }

    }

}
