// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class ModifyTTSConfigRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>99****Aw</para>
        /// </summary>
        [NameInMap("AppKey")]
        [Validation(Required=false)]
        public string AppKey { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>27244bae-e446-4811-bb1d-f8a07b525af0</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Managed</para>
        /// </summary>
        [NameInMap("NlsServiceType")]
        [Validation(Required=false)]
        public string NlsServiceType { get; set; }

        /// <summary>
        /// <para>语调 [-500,500]之间整数。默认值为0。</para>
        /// <para>大于0表示升高音高。</para>
        /// <para>小于0表示降低音高。</para>
        /// </summary>
        [NameInMap("PitchRate")]
        [Validation(Required=false)]
        public string PitchRate { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1f1a2ba0-b3e7-4ff9-baf1-6dc8aeac0791</para>
        /// </summary>
        [NameInMap("ScriptId")]
        [Validation(Required=false)]
        public string ScriptId { get; set; }

        [NameInMap("SpeechRate")]
        [Validation(Required=false)]
        public string SpeechRate { get; set; }

        [NameInMap("Voice")]
        [Validation(Required=false)]
        public string Voice { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("Volume")]
        [Validation(Required=false)]
        public string Volume { get; set; }

    }

}
