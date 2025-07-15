// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class CreateMessageAppRequest : TeaModel {
        /// <summary>
        /// <para>The configurations of the application.</para>
        /// </summary>
        [NameInMap("AppConfig")]
        [Validation(Required=false)]
        public Dictionary<string, string> AppConfig { get; set; }

        /// <summary>
        /// <para>The name of the interactive message application. The name must be 2 to 16 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The extended fields.</para>
        /// </summary>
        [NameInMap("Extension")]
        [Validation(Required=false)]
        public Dictionary<string, string> Extension { get; set; }

    }

}
