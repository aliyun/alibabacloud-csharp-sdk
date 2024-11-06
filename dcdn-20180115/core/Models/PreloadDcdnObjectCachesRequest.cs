// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class PreloadDcdnObjectCachesRequest : TeaModel {
        /// <summary>
        /// <para>The acceleration region in which you want to prefetch content. If you do not specify a region, the value overseas is used.</para>
        /// <list type="bullet">
        /// <item><description><b>domestic</b>: Chinese mainland</description></item>
        /// <item><description><b>overseas</b>: outside the Chinese mainland</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>domestic</para>
        /// </summary>
        [NameInMap("Area")]
        [Validation(Required=false)]
        public string Area { get; set; }

        /// <summary>
        /// <para>Specifies whether to prefetch content to POPs. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: prefetches content to nodes that include L2 DCDN nodes.</description></item>
        /// <item><description><b>false</b>: prefetches content to L2 POPs or L3 POPs.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("L2Preload")]
        [Validation(Required=false)]
        public bool? L2Preload { get; set; }

        /// <summary>
        /// <para>The path of the content that you want to prefetch. Separate multiple URLs with line feed characters (\n) or a pair of carriage return and line feed characters (\r\n).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com/examplefile.txt</para>
        /// </summary>
        [NameInMap("ObjectPath")]
        [Validation(Required=false)]
        public string ObjectPath { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("QueryHashkey")]
        [Validation(Required=false)]
        public bool? QueryHashkey { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// <para>The custom header for prefetch in the JSON format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///       &quot;Accept-Encoding&quot;: [
        ///             &quot;gzip&quot;
        ///       ]
        /// }</para>
        /// </summary>
        [NameInMap("WithHeader")]
        [Validation(Required=false)]
        public string WithHeader { get; set; }

    }

}
