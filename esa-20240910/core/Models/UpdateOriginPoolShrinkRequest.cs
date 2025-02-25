// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class UpdateOriginPoolShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Whether the origin pool is enabled:</para>
        /// <list type="bullet">
        /// <item><description>true: Enabled;</description></item>
        /// <item><description>false: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// <para>The ID of the origin pool, which can be obtained by calling the <a href="~~ListOriginPools~~">ListOriginPools</a> interface.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1038520525196928</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>Information about the origins added to the origin pool. Multiple origins are passed as an array.</para>
        /// </summary>
        [NameInMap("Origins")]
        [Validation(Required=false)]
        public string OriginsShrink { get; set; }

        /// <summary>
        /// <para>The site ID, which can be obtained by calling the <a href="~~ListSites~~">ListSites</a> interface.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>216558609793952</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

    }

}
