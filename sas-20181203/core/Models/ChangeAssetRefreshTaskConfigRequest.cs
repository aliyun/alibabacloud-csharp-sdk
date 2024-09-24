// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ChangeAssetRefreshTaskConfigRequest : TeaModel {
        /// <summary>
        /// <para>The asset synchronization configuration.</para>
        /// </summary>
        [NameInMap("AssetRefreshConfigs")]
        [Validation(Required=false)]
        public List<ChangeAssetRefreshTaskConfigRequestAssetRefreshConfigs> AssetRefreshConfigs { get; set; }
        public class ChangeAssetRefreshTaskConfigRequestAssetRefreshConfigs : TeaModel {
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
            /// <para>The synchronization cycle. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>60</b>: 60 minutes</description></item>
            /// <item><description><b>180</b>: 3 hours</description></item>
            /// <item><description><b>360</b>: 6 hours</description></item>
            /// <item><description><b>720</b>: 12 hours</description></item>
            /// <item><description><b>1440</b>: 1 day</description></item>
            /// <item><description><b>10080</b>: 7 days</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>360</para>
            /// </summary>
            [NameInMap("SchedulePeriod")]
            [Validation(Required=false)]
            public int? SchedulePeriod { get; set; }

            /// <summary>
            /// <para>The status of the configuration. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: enabled</description></item>
            /// <item><description><b>0</b>: disabled</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The ID of the data entry containing the AccessKey pair that you specify when you configure the scheduled AccessKey pair verification task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2308</para>
            /// </summary>
            [NameInMap("TargetId")]
            [Validation(Required=false)]
            public long? TargetId { get; set; }

            /// <summary>
            /// <para>The service provider of the cloud asset. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>3</b>: Tencent Cloud</description></item>
            /// <item><description><b>4</b>: Huawei Cloud</description></item>
            /// <item><description><b>7</b>: Amazon Web Services (AWS) Cloud</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Vendor")]
            [Validation(Required=false)]
            public int? Vendor { get; set; }

        }

        /// <summary>
        /// <para>The region in which your Security Center service resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
