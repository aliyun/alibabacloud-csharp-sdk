// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ChangeAssetRefreshTaskConfigRequest : TeaModel {
        /// <summary>
        /// <para>The list of asset refresh configurations.</para>
        /// </summary>
        [NameInMap("AssetRefreshConfigs")]
        [Validation(Required=false)]
        public List<ChangeAssetRefreshTaskConfigRequestAssetRefreshConfigs> AssetRefreshConfigs { get; set; }
        public class ChangeAssetRefreshTaskConfigRequestAssetRefreshConfigs : TeaModel {
            /// <summary>
            /// <para>The configuration type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Host refresh task</description></item>
            /// <item><description><b>1</b>: Cloud service refresh task</description></item>
            /// <item><description><b>2</b>: AccessKey scheduled check task</description></item>
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
            /// <para>The enabling status of the configuration. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Enabled</description></item>
            /// <item><description><b>0</b>: Disabled</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The ID of the specified AccessKey record when you configure an AccessKey scheduled check task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2308</para>
            /// </summary>
            [NameInMap("TargetId")]
            [Validation(Required=false)]
            public long? TargetId { get; set; }

            /// <summary>
            /// <para>The cloud asset vendor. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>3</b>: Tencent Cloud</description></item>
            /// <item><description><b>4</b>: Huawei Cloud</description></item>
            /// <item><description><b>7</b>: Amazon Web Services</description></item>
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
        /// <para>The region of the Security Center instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
