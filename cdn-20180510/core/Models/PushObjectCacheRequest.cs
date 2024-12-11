// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class PushObjectCacheRequest : TeaModel {
        /// <summary>
        /// <para>The acceleration region where content is to be prefetched. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>domestic</b><b>: Chinese mainland</b></description></item>
        /// <item><description><b>overseas</b><b>: regions outside the Chinese mainland</b></description></item>
        /// </list>
        /// <para>If you do not set this parameter, content in the service location (specified by parameter Coverage) that you configured for the domain is prefetched. Content is prefetched based on the following rules:</para>
        /// <list type="bullet">
        /// <item><description>If the acceleration region is set to <b>Chinese Mainland Only</b>, content in regions in the Chinese mainland is prefetched.</description></item>
        /// <item><description>If the acceleration region is set to <b>Global</b>, content in all regions is prefetched.</description></item>
        /// <item><description>If the acceleration region is set to <b>Global (Excluding the Chinese Mainland)</b>, content in regions outside the Chinese mainland is prefetched.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>domestic</para>
        /// </summary>
        [NameInMap("Area")]
        [Validation(Required=false)]
        public string Area { get; set; }

        /// <summary>
        /// <para>Specifies whether to prefetch content to L2 points of presence (POPs). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: prefetches content to L2 POPs.</description></item>
        /// <item><description><b>false</b>: prefetches content to regular POPs. Regular POPs can be L2 POPs or L3 POPs. Default value: <b>false</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("L2Preload")]
        [Validation(Required=false)]
        public bool? L2Preload { get; set; }

        /// <summary>
        /// <para>The URLs based on which content is prefetched. Format: <b>accelerated domain name/files to be prefetched</b>.</para>
        /// <remarks>
        /// <para>Separate URLs with line feeds (\n or \r\n). Each object path can be up to 1,024 characters in length.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com/image/1.png\nexample.org/image/2.png</para>
        /// </summary>
        [NameInMap("ObjectPath")]
        [Validation(Required=false)]
        public string ObjectPath { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>This parameter specifies whether to enable the hash key query mode when you run a prefetch task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>false: The default mode, in which the submitted URL is used as the hash key for the prefetch.</description></item>
        /// <item><description>true: In this mode, the actual hash key used for the prefetch is queried based on the configuration of the domain name.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
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
