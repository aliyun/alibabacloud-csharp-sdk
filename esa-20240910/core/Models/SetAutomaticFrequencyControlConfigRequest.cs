// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class SetAutomaticFrequencyControlConfigRequest : TeaModel {
        /// <summary>
        /// <para>The action to take on requests that trigger the control. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>observe</b>: Monitors the requests.</para>
        /// </description></item>
        /// <item><description><para><b>deny</b>: Blocks the requests.</para>
        /// </description></item>
        /// <item><description><para><b>js</b>: Issues a JS challenge.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>js</para>
        /// </summary>
        [NameInMap("ActionType")]
        [Validation(Required=false)]
        public string ActionType { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable automatic frequency control. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>on</b>: Enables automatic frequency control.</para>
        /// </description></item>
        /// <item><description><para><b>off</b>: Disables automatic frequency control.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("Enable")]
        [Validation(Required=false)]
        public string Enable { get; set; }

        /// <summary>
        /// <para>The protection level. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>loose</b>: Loose protection.</para>
        /// </description></item>
        /// <item><description><para><b>normal</b>: Normal protection.</para>
        /// </description></item>
        /// <item><description><para><b>strict</b>: Strict protection.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>normal</para>
        /// </summary>
        [NameInMap("Level")]
        [Validation(Required=false)]
        public string Level { get; set; }

        /// <summary>
        /// <para>The ID of the site. Call the <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> operation to obtain this ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456****</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        /// <summary>
        /// <para>The version of the site. For a site with version management enabled, this parameter specifies the version to which the configuration applies. The default value is 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SiteVersion")]
        [Validation(Required=false)]
        public int? SiteVersion { get; set; }

    }

}
