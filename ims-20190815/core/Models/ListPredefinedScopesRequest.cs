// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class ListPredefinedScopesRequest : TeaModel {
        /// <summary>
        /// <para>The type of the application. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>WebApp</description></item>
        /// <item><description>NativeApp</description></item>
        /// <item><description>ServerApp</description></item>
        /// </list>
        /// <para>If this parameter is empty, the permissions on all types of applications are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WebApp</para>
        /// </summary>
        [NameInMap("AppType")]
        [Validation(Required=false)]
        public string AppType { get; set; }

    }

}
