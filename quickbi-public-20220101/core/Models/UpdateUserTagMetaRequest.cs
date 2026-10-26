// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class UpdateUserTagMetaRequest : TeaModel {
        /// <summary>
        /// <para>The tag description.</para>
        /// <list type="bullet">
        /// <item><description>Format check: Maximum length is 255 characters.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Job Positions within the Department</para>
        /// </summary>
        [NameInMap("TagDescription")]
        [Validation(Required=false)]
        public string TagDescription { get; set; }

        /// <summary>
        /// <para>The specified TagID.</para>
        /// <list type="bullet">
        /// <item><description>Format check: Maximum length is 64 characters.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e82f6c6c0333431bad0225b2f85e****</para>
        /// </summary>
        [NameInMap("TagId")]
        [Validation(Required=false)]
        public string TagId { get; set; }

        /// <summary>
        /// <para>The tag name.</para>
        /// <list type="bullet">
        /// <item><description>Format check: Maximum length is 50 characters.</description></item>
        /// <item><description>Only Chinese, English, numbers, and /\|<a href=""></a> symbols are allowed.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Department</para>
        /// </summary>
        [NameInMap("TagName")]
        [Validation(Required=false)]
        public string TagName { get; set; }

    }

}
