// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class UploadAudioDataRequest : TeaModel {
        /// <summary>
        /// <para>The business space ID. In multi-business space scenarios, this parameter specifies the business space to use. Default value: the default business space.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("BaseMeAgentId")]
        [Validation(Required=false)]
        public long? BaseMeAgentId { get; set; }

        /// <summary>
        /// <para>The complete JSON string. For details about the content, see the following detailed information.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{“callList”:“xxxxx”}</para>
        /// </summary>
        [NameInMap("JsonStr")]
        [Validation(Required=false)]
        public string JsonStr { get; set; }

    }

}
