// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class ModifyIntentRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8fa1953f-4a84-46d8-b80c-8ce9cf684fb3</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("IntentDescription")]
        [Validation(Required=false)]
        public string IntentDescription { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3b9a2b33-50d4-4576-8c68-22498f4bf731</para>
        /// </summary>
        [NameInMap("IntentId")]
        [Validation(Required=false)]
        public string IntentId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("IntentName")]
        [Validation(Required=false)]
        public string IntentName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("Keywords")]
        [Validation(Required=false)]
        public string Keywords { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9b70486f-b1c2-429c-8a24-62798015ab1b</para>
        /// </summary>
        [NameInMap("ScriptId")]
        [Validation(Required=false)]
        public string ScriptId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Utterances")]
        [Validation(Required=false)]
        public string Utterances { get; set; }

    }

}
