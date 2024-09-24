// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListAssetRefreshTaskConfigRequest : TeaModel {
        /// <summary>
        /// <para>The type of the configuration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: server synchronization task</description></item>
        /// <item><description><b>1</b>: cloud service synchronization task</description></item>
        /// <item><description><b>2</b>: scheduled AccessKey pair verification task</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("RefreshConfigType")]
        [Validation(Required=false)]
        public int? RefreshConfigType { get; set; }

        /// <summary>
        /// <para>The region where the Security Center instance is deployed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the data entry containing the AccessKey pair that you specify when you configure the scheduled AccessKey pair verification task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2295</para>
        /// </summary>
        [NameInMap("TargetId")]
        [Validation(Required=false)]
        public long? TargetId { get; set; }

    }

}
