// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class UpdateOriginPoolShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable the origin pool:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Enables the origin pool.</para>
        /// </description></item>
        /// <item><description><para>false: Disables the origin pool.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// <para>The origin pool ID. Get this ID by calling the <a href="~~ListOriginPools~~">ListOriginPools</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1038520525196928</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>An array of origin configurations.</para>
        /// </summary>
        [NameInMap("Origins")]
        [Validation(Required=false)]
        public string OriginsShrink { get; set; }

        /// <summary>
        /// <para>The site ID. Get this ID by calling the <a href="~~ListSites~~">ListSites</a> operation.</para>
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
