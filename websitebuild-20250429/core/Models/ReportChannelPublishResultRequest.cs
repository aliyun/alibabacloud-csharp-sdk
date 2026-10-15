// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class ReportChannelPublishResultRequest : TeaModel {
        /// <summary>
        /// <para>The display name of the publishing account. A null value does not overwrite the original value. Maximum length: 256 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xx</para>
        /// </summary>
        [NameInMap("ChannelAccountName")]
        [Validation(Required=false)]
        public string ChannelAccountName { get; set; }

        /// <summary>
        /// <para>The channel draft ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>draft-789</para>
        /// </summary>
        [NameInMap("DraftId")]
        [Validation(Required=false)]
        public string DraftId { get; set; }

        /// <summary>
        /// <para>The ID returned by the platform. Set this parameter when the publishing is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5467410713875420090</para>
        /// </summary>
        [NameInMap("ExternalId")]
        [Validation(Required=false)]
        public string ExternalId { get; set; }

        /// <summary>
        /// <para>The redirect URL of the platform.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://hf-groot.lingostarcdn.com/sparkenglish-sv/groot-parent/1-698a94b7-133b20ab-42ae793d40f6/05a0caf1-abb0-415d-941c-eecf0b613eae.mp4">https://hf-groot.lingostarcdn.com/sparkenglish-sv/groot-parent/1-698a94b7-133b20ab-42ae793d40f6/05a0caf1-abb0-415d-941c-eecf0b613eae.mp4</a></para>
        /// </summary>
        [NameInMap("ExternalUrl")]
        [Validation(Required=false)]
        public string ExternalUrl { get; set; }

        /// <summary>
        /// <para>The failure reason. Set this parameter when the publishing fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("FailReason")]
        [Validation(Required=false)]
        public string FailReason { get; set; }

        /// <summary>
        /// <para>Specifies whether the publishing is successful (true/false).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
