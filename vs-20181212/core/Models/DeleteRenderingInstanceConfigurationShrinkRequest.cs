// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class DeleteRenderingInstanceConfigurationShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Configuration content. Purge all configured modules by default.</para>
        /// </summary>
        [NameInMap("Configuration")]
        [Validation(Required=false)]
        public string ConfigurationShrink { get; set; }

        /// <summary>
        /// <para>Cloud application service instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>render-9f8c57355d224ad7beaf95e145f22111</para>
        /// </summary>
        [NameInMap("RenderingInstanceId")]
        [Validation(Required=false)]
        public string RenderingInstanceId { get; set; }

    }

}
