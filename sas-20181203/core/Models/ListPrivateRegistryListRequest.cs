// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListPrivateRegistryListRequest : TeaModel {
        /// <summary>
        /// <para>The type of the image repository. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>acr</b>: Container Registry</description></item>
        /// <item><description><b>harbor</b>: Harbor</description></item>
        /// <item><description><b>quay</b>: Quay</description></item>
        /// <item><description><b>CI/CD</b>: Jenkins</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>harbor</para>
        /// </summary>
        [NameInMap("RegistryType")]
        [Validation(Required=false)]
        public string RegistryType { get; set; }

    }

}
