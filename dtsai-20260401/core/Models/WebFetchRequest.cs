// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DtsAI20260401.Models
{
    public class WebFetchRequest : TeaModel {
        /// <summary>
        /// <para>The output format. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>markdown</b>: Markdown format.</para>
        /// </description></item>
        /// <item><description><para><b>html</b>: HTML format.</para>
        /// </description></item>
        /// <item><description><para><b>text</b>: Plain text format.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>markdown</para>
        /// </summary>
        [NameInMap("OutputFormat")]
        [Validation(Required=false)]
        public string OutputFormat { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The URL of the target web page to crawl.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://xxx/projects/spring-boot">https://xxx/projects/spring-boot</a></para>
        /// </summary>
        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
