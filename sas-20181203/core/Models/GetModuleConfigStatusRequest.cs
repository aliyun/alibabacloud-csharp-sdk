// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetModuleConfigStatusRequest : TeaModel {
        /// <summary>
        /// <para>The service modules that you want to query.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ModuleNames")]
        [Validation(Required=false)]
        public List<string> ModuleNames { get; set; }

    }

}
