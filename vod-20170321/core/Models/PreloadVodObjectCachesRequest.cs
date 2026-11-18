// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class PreloadVodObjectCachesRequest : TeaModel {
        /// <summary>
        /// <para>The prefetch region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>domestic</para>
        /// </summary>
        [NameInMap("Area")]
        [Validation(Required=false)]
        public string Area { get; set; }

        /// <summary>
        /// <para>Specifies whether to prefetch content directly to L2 nodes. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The prefetch node hierarchy must include L2 nodes.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Content is prefetched only to the origin-fetching layer nodes. This is the <b>default value</b>. The origin-fetching layer nodes can be L2 or L3 nodes.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("L2Preload")]
        [Validation(Required=false)]
        public bool? L2Preload { get; set; }

        /// <summary>
        /// <para>The URLs of the files to be prefetched. Separate multiple URLs with line breaks (
        ///  or 
        /// ).</para>
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
        /// <para>By default, prefetch requests carry the Accept-Encoding: gzip header. If you want prefetch requests to carry other headers or implement multi-replica prefetching, you can use this parameter to specify custom prefetch headers. Submit the headers in JSON format.</para>
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
