// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class BlockObjectShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The content to block.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string ContentShrink { get; set; }

        /// <summary>
        /// <para>The effective period of the block, in seconds. This parameter is required when the type is set to block.</para>
        /// 
        /// <b>Example:</b>
        /// <para>864000</para>
        /// </summary>
        [NameInMap("Maxage")]
        [Validation(Required=false)]
        public int? Maxage { get; set; }

        /// <summary>
        /// <para>The site ID, which can be obtained by calling the <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456****</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        /// <summary>
        /// <para>The type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>block</b>: blocks the URLs.</description></item>
        /// <item><description><b>unblock</b>: unblocks the URLs.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>block</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
