// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RealTranslationAgent20260622.Models
{
    public class GetTranslatedFileUrlRequest : TeaModel {
        /// <summary>
        /// <para>The API key that identifies a member accounts identity. You can obtain the key from the RuiYiBao console.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sk-1***s</para>
        /// </summary>
        [NameInMap("APIKey")]
        [Validation(Required=false)]
        public string APIKey { get; set; }

        /// <summary>
        /// <para>The task ID.</para>
        /// <list type="bullet">
        /// <item><description>The TaskId is returned after a task is submitted by calling SubmitTranslationTask.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>f9c35b0453b</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
