// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetLocalDefaultRegionRequest : TeaModel {
        /// <summary>
        /// <para>The cloud asset vendor. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Tencent</b>: Tencent Cloud</description></item>
        /// <item><description><b>HUAWEICLOUD</b>: Huawei Cloud</description></item>
        /// <item><description><b>Azure</b>: Azure</description></item>
        /// <item><description><b>AWS</b>: AWS.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Tencent</para>
        /// </summary>
        [NameInMap("Vendor")]
        [Validation(Required=false)]
        public string Vendor { get; set; }

    }

}
