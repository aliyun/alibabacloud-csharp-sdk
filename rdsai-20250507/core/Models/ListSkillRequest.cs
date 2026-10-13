// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class ListSkillRequest : TeaModel {
        /// <summary>
        /// <para>The supported languages. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>zh-CN: Simplified Chinese</description></item>
        /// <item><description>zh-TW: Traditional Chinese</description></item>
        /// <item><description>en-US: English</description></item>
        /// <item><description>ja-JP: Japanese</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh-CN</para>
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 20. Maximum value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The search parameter for skill name or description. This filter is not currently enabled in the ContextDB management console.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("Query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// <para>The ContextDB query scope. Valid values: all (default), private, and system.</para>
        /// 
        /// <b>Example:</b>
        /// <para>all</para>
        /// </summary>
        [NameInMap("Scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

        /// <summary>
        /// <para>The sort parameter for skills. This sorting is not currently enabled in the ContextDB management console.</para>
        /// 
        /// <b>Example:</b>
        /// <para>updated_at_desc</para>
        /// </summary>
        [NameInMap("Sort")]
        [Validation(Required=false)]
        public string Sort { get; set; }

        /// <summary>
        /// <para>The filter parameter for skill source. This filter is not currently enabled in the ContextDB management console.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SYSTEM</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>The ContextDB workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>00000000-0000-4000-8000-000000000001</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
