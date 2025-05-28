// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class AddUserTagMetaRequest : TeaModel {
        /// <summary>
        /// <para>Tag description. Format check: maximum length of 255 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("TagDescription")]
        [Validation(Required=false)]
        public string TagDescription { get; set; }

        /// <summary>
        /// <para>Tag name. Format check:</para>
        /// <list type="bullet">
        /// <item><description>Maximum length of 50 characters.</description></item>
        /// <item><description>Only Chinese, English, numbers, and /\|<a href=""></a> symbols are allowed.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("TagName")]
        [Validation(Required=false)]
        public string TagName { get; set; }

    }

}
