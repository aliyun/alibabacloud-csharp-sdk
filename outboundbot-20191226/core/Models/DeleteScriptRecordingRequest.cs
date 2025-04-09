// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class DeleteScriptRecordingRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1eefcb81-cd58-4143-8180-6a962d79d708</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dcc42f0d-cfd8-4866-9bbf-002042503745</para>
        /// </summary>
        [NameInMap("ScriptId")]
        [Validation(Required=false)]
        public string ScriptId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[
        ///       &quot;d17d5bfa-4972-4389-9718-f9602edabe48&quot;
        /// ]</para>
        /// </summary>
        [NameInMap("UuidsJson")]
        [Validation(Required=false)]
        public string UuidsJson { get; set; }

    }

}
