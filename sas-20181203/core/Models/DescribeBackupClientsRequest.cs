// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeBackupClientsRequest : TeaModel {
        /// <summary>
        /// <para>The region supported by the anti-ransomware feature. You can call <a href="~~DescribeSupportRegion~~">DescribeSupportRegion</a> to query the regions supported by the anti-ransomware feature.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("SupportRegionId")]
        [Validation(Required=false)]
        public string SupportRegionId { get; set; }

    }

}
