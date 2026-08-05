// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class CreateMessageAppRequest : TeaModel {
        /// <summary>
        /// <para>The application configuration.</para>
        /// </summary>
        [NameInMap("AppConfig")]
        [Validation(Required=false)]
        public Dictionary<string, string> AppConfig { get; set; }

        /// <summary>
        /// <para>The name of the interactive message application. The length must be 2 to 16 characters.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The extension field.</para>
        /// </summary>
        [NameInMap("Extension")]
        [Validation(Required=false)]
        public Dictionary<string, string> Extension { get; set; }

    }

}
