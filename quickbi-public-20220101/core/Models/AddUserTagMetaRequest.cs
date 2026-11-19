// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class AddUserTagMetaRequest : TeaModel {
        /// <summary>
        /// <para>The tag description. Format requirements: The maximum length is 255 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Positions within the department</para>
        /// </summary>
        [NameInMap("TagDescription")]
        [Validation(Required=false)]
        public string TagDescription { get; set; }

        /// <summary>
        /// <para>The tag name. Format requirements:</para>
        /// <list type="bullet">
        /// <item><description>The maximum length is 50 characters.</description></item>
        /// <item><description>Only Chinese characters, English letters, digits, and the /\|<a href=""></a> symbols are allowed.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Position</para>
        /// </summary>
        [NameInMap("TagName")]
        [Validation(Required=false)]
        public string TagName { get; set; }

    }

}
