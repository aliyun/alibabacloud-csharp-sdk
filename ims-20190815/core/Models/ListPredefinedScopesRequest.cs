// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class ListPredefinedScopesRequest : TeaModel {
        /// <summary>
        /// The type of the application. Valid values:
        /// 
        /// *   WebApp
        /// *   NativeApp
        /// *   ServerApp
        /// 
        /// If this parameter is empty, the permissions on all types of applications are queried.
        /// </summary>
        [NameInMap("AppType")]
        [Validation(Required=false)]
        public string AppType { get; set; }

    }

}
