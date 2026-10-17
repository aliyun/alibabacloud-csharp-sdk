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
        /// <item><description>PUBLIC: All members of the current workspace can access the instance.</description></item>
        /// <item><description>PRIVATE: Only the creator can access the instance.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PUBLIC</para>
        /// </summary>
        [NameInMap("Accessibility")]
        [Validation(Required=false)]
        public string Accessibility { get; set; }

        [NameInMap("CallerAccessKeyId")]
        [Validation(Required=false)]
        public string CallerAccessKeyId { get; set; }

        [NameInMap("CallerSecurityToken")]
        [Validation(Required=false)]
        public string CallerSecurityToken { get; set; }

        [NameInMap("CallerType")]
        [Validation(Required=false)]
        public string CallerType { get; set; }

        [NameInMap("CallerUid")]
        [Validation(Required=false)]
        public string CallerUid { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud account UID of the creator of the workspace permission.</para>
        /// 
        /// <b>Example:</b>
        /// <para>17915******4216</para>
        /// </summary>
        [NameInMap("Creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

        /// <summary>
        /// <para>The labels.</para>
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public Dictionary<string, object> Labels { get; set; }

        /// <summary>
        /// <para>The optional configurations. Separate multiple configurations with commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ResourceEmpty: The resource is empty. If Resource is not specified, this value is empty.</description></item>
        /// <item><description>DisableRam: Disables RAM checks.</description></item>
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
