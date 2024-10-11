// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class PreloadVodObjectCachesRequest : TeaModel {
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
        /// <para>The URL of the file to be prefetched. Separate multiple URLs with line breaks (\n or \r\n).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vod.test.com/test.txt</para>
        /// </summary>
        [NameInMap("ObjectPath")]
        [Validation(Required=false)]
        public string ObjectPath { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// <para>The custom header for prefetch in the JSON format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///       &quot;Accept-Encoding&quot;: [
        ///             &quot;gzip, deflate, br&quot;
        ///       ]
        /// }</para>
        /// </summary>
        [NameInMap("WithHeader")]
        [Validation(Required=false)]
        public string WithHeader { get; set; }

    }

}
