// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class SetSyncRefreshRegionRequest : TeaModel {
        /// <summary>
        /// <para>The access type of the multi-cloud site. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: The current site is not the default site of multi-cloud site. You can specify the current site as the default site of the multi-cloud site.</description></item>
        /// <item><description><b>1</b>: The current site is the default site of multi-cloud site.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("DefaultRegion")]
        [Validation(Required=false)]
        public int? DefaultRegion { get; set; }

        /// <summary>
        /// <para>The regions from which you want to synchronize assets at the current site.</para>
        /// </summary>
        [NameInMap("RegionIds")]
        [Validation(Required=false)]
        public List<string> RegionIds { get; set; }

        /// <summary>
        /// <para>The cloud service provider. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Tencent</b>: Tencent Cloud</description></item>
        /// <item><description><b>HUAWEICLOUD</b>: Huawei Cloud</description></item>
        /// <item><description><b>Azure</b>: Microsoft Azure</description></item>
        /// <item><description><b>AWS</b>: Amazon Web Services (AWS)</description></item>
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
