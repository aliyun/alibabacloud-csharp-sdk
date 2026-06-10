// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class ModifyTTSConfigRequest : TeaModel {
        /// <summary>
        /// <para>AppKey for your Intelligent Speech Interaction project. Required only when NlsServiceType is Authorized.</para>
        /// 
        /// <b>Example:</b>
        /// <para>99****Aw</para>
        /// </summary>
        [NameInMap("AppKey")]
        [Validation(Required=false)]
        public string AppKey { get; set; }

        /// <summary>
        /// <para>Instance ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>27244bae-e446-4811-bb1d-f8a07b525af0</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The service type.
        /// Managed: The default public Intelligent Speech Interaction service for Outbound Bot.
        /// Authorized: A private Intelligent Speech Interaction service that you have purchased. To grant authorization, navigate to Scenario Management &gt; Edit &gt; Call Service &gt; Custom Service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Managed</para>
        /// </summary>
        [NameInMap("NlsServiceType")]
        [Validation(Required=false)]
        public string NlsServiceType { get; set; }

        /// <summary>
        /// <para>Pitch. An integer between -500 and 500. Default is 0.</para>
        /// <para>A value greater than 0 raises pitch.</para>
        /// <para>A value less than 0 lowers pitch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("PitchRate")]
        [Validation(Required=false)]
        public string PitchRate { get; set; }

        /// <summary>
        /// <para>Scenario ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1f1a2ba0-b3e7-4ff9-baf1-6dc8aeac0791</para>
        /// </summary>
        [NameInMap("ScriptId")]
        [Validation(Required=false)]
        public string ScriptId { get; set; }

        /// <summary>
        /// <para>Speech rate. An integer between -500 and 500. Default is 0.</para>
        /// <para>A value greater than 0 increases speech speed.</para>
        /// <para>A value less than 0 decreases speech speed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SpeechRate")]
        [Validation(Required=false)]
        public string SpeechRate { get; set; }

        /// <summary>
        /// <para>Voice model, such as aixia, siyue, or xiaoyun</para>
        /// 
        /// <b>Example:</b>
        /// <para>aixia</para>
        /// </summary>
        [NameInMap("Voice")]
        [Validation(Required=false)]
        public string Voice { get; set; }

        /// <summary>
        /// <para>Volume. An integer between 0 and 100. Default is 50.</para>
        /// <para>A value greater than 50 increases volume.</para>
        /// <para>A value less than 50 decreases volume.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("Volume")]
        [Validation(Required=false)]
        public string Volume { get; set; }

    }

}
