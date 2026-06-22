// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DeleteHoneypotPresetRequest : TeaModel {
        /// <summary>
        /// <para>The unique ID of the honeypot template.</para>
        /// <remarks>
        /// <para>Call the <a href="~~ListHoneypotPreset~~">ListHoneypotPreset</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>84104b7b-a2bc-41df-a190-12298f99xxxx</para>
        /// </summary>
        [NameInMap("HoneypotPresetId")]
        [Validation(Required=false)]
        public string HoneypotPresetId { get; set; }

        /// <summary>
        /// <para>The language of the content in the request and response. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

    }

}
