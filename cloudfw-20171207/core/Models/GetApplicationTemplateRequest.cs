// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class GetApplicationTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application template to query. The template must exist within the current Alibaba Cloud account.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ati-4f0691c56b8d4f06</para>
        /// </summary>
        [NameInMap("ApplicationTemplateId")]
        [Validation(Required=false)]
        public string ApplicationTemplateId { get; set; }

        /// <summary>
        /// <para>The return scope for built-in application actions. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Custom</b>: Returns only applications for which users have customized actions. This is the default value.</description></item>
        /// <item><description><b>All</b>: Returns all built-in applications.
        /// The priority of action effectiveness is: user-customized &gt; template default &gt; application library default.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Custom</para>
        /// </summary>
        [NameInMap("BuiltInApplicationActionType")]
        [Validation(Required=false)]
        public string BuiltInApplicationActionType { get; set; }

    }

}
