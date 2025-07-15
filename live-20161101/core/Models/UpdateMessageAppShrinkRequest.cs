// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class UpdateMessageAppShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The configurations of the application.</para>
        /// </summary>
        [NameInMap("AppConfig")]
        [Validation(Required=false)]
        public string AppConfigShrink { get; set; }

        /// <summary>
        /// <para>The ID of the interactive messaging application.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VKL3***</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The name of the interactive messaging application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testApp</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The extended field.</para>
        /// </summary>
        [NameInMap("Extension")]
        [Validation(Required=false)]
        public string ExtensionShrink { get; set; }

    }

}
