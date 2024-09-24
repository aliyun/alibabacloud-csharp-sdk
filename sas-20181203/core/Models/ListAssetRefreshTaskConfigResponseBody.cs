// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListAssetRefreshTaskConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The asset synchronization configuration.</para>
        /// </summary>
        [NameInMap("AssetRefreshConfig")]
        [Validation(Required=false)]
        public List<ListAssetRefreshTaskConfigResponseBodyAssetRefreshConfig> AssetRefreshConfig { get; set; }
        public class ListAssetRefreshTaskConfigResponseBodyAssetRefreshConfig : TeaModel {
            /// <summary>
            /// <para>The type of the configuration. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: server synchronization task</description></item>
            /// <item><description><b>1</b>: cloud service synchronization task</description></item>
            /// <item><description><b>2</b>: scheduled AccessKey pair verification task</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
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
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D65AADFC-1D20-5A6A-8F6A-9FA53C0DC1F8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
