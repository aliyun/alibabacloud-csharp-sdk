// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ListAIAgentVoiceprintsRequest : TeaModel {
        /// <summary>
        /// <para>The page number to return. Must be 1 or greater.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: 1 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The registration mode for the voiceprint. The default value is <c>Explicit</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Explicit</para>
        /// </summary>
        [NameInMap("RegistrationMode")]
        [Validation(Required=false)]
        public string RegistrationMode { get; set; }

        /// <summary>
        /// <para>The unique voiceprint ID. If specified, this operation returns the details of a single voiceprint. If omitted, it returns a paginated list of all voiceprints under your account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vp_1699123456_8527</para>
        /// </summary>
        [NameInMap("VoiceprintId")]
        [Validation(Required=false)]
        public string VoiceprintId { get; set; }

    }

}
