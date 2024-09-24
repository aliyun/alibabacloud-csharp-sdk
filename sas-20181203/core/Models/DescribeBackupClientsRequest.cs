// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeBackupClientsRequest : TeaModel {
        /// <summary>
        /// <para>The region in which the anti-ransomware feature is supported.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~DescribeSupportRegion~~">DescribeSupportRegion</a> operation to query the regions in which the anti-ransomware feature is supported.</para>
        /// </remarks>
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
