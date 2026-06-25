// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class GetPermissionRequest : TeaModel {
        /// <summary>
        /// <para>The access type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>PUBLIC: All members in the workspace can perform the operation.</para>
        /// </description></item>
        /// <item><description><para>PRIVATE: Only the creator can perform the operation.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PUBLIC</para>
        /// </summary>
        [NameInMap("Accessibility")]
        [Validation(Required=false)]
        public string Accessibility { get; set; }

        [NameInMap("CallerType")]
        [Validation(Required=false)]
        public string CallerType { get; set; }

        [NameInMap("CallerUid")]
        [Validation(Required=false)]
        public string CallerUid { get; set; }

        /// <summary>
        /// <para>The UID of the Alibaba Cloud account that created the workspace permission.</para>
        /// 
        /// <b>Example:</b>
        /// <para>17915******4216</para>
        /// </summary>
        [NameInMap("Creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

        [NameInMap("Labels")]
        [Validation(Required=false)]
        public Dictionary<string, object> Labels { get; set; }

        /// <summary>
        /// <para>Optional configurations. Separate multiple configurations with commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>ResourceEmpty: The resource is empty. This value is used if you do not set the Resource parameter.</para>
        /// </description></item>
        /// <item><description><para>DisableRam: RAM verification is disabled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ResourceEmpty,DisableRam</para>
        /// </summary>
        [NameInMap("Option")]
        [Validation(Required=false)]
        public string Option { get; set; }

        /// <summary>
        /// <para>The resource.</para>
        /// 
        /// <b>Example:</b>
        /// <para>job/dlc-ksd******s12</para>
        /// </summary>
        [NameInMap("Resource")]
        [Validation(Required=false)]
        public string Resource { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
