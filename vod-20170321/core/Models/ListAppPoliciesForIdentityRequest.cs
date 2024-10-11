// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class ListAppPoliciesForIdentityRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application. Default value: <b>app-1000000</b>. For more information, see <a href="https://help.aliyun.com/document_detail/113600.html">Overview</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app-****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The name of the identity.</para>
        /// <list type="bullet">
        /// <item><description>Specifies the ID of the RAM user when the IdentityType parameter is set to RamUser.</description></item>
        /// <item><description>Specifies the name of the RAM role when the IdentityType parameter is set to RamRole.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>test****name</para>
        /// </summary>
        [NameInMap("IdentityName")]
        [Validation(Required=false)]
        public string IdentityName { get; set; }

        /// <summary>
        /// <para>The type of the identity. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>RamUser</b>: a RAM user.</description></item>
        /// <item><description><b>RamRole</b>: a RAM role.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>RamUser</para>
        /// </summary>
        [NameInMap("IdentityType")]
        [Validation(Required=false)]
        public string IdentityType { get; set; }

    }

}
