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
        /// <item><description><para><b>acr</b>: ACR</para>
        /// </description></item>
        /// <item><description><para><b>harbor</b>: Harbor</para>
        /// </description></item>
        /// <item><description><para><b>quay</b>: Quay</para>
        /// </description></item>
        /// <item><description><para><b>CI/CD</b>: Jenkins</para>
        /// </description></item>
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
