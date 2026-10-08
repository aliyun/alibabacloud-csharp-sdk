// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class SaveDomainGroupRequest : TeaModel {
        /// <summary>
        /// <para>Domain group ID. If this parameter is not provided, a new group is created. If it is provided, the domain group name is updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("DomainGroupId")]
        [Validation(Required=false)]
        public long? DomainGroupId { get; set; }

        /// <summary>
        /// <para>Domain Name Group Name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试分组</para>
        /// </summary>
        [NameInMap("DomainGroupName")]
        [Validation(Required=false)]
        public string DomainGroupName { get; set; }

        /// <summary>
        /// <para>Language for error messages returned by the API. Valid values:  </para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese;  </description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// <para>Default value is <b>en</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>User IP address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>127.0.0.1</para>
        /// </summary>
        [NameInMap("UserClientIp")]
        [Validation(Required=false)]
        public string UserClientIp { get; set; }

    }

}
