// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetCurrentVersionPublishResponseBody : TeaModel {
        /// <summary>
        /// <para>The data details.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetCurrentVersionPublishResponseBodyData Data { get; set; }
        public class GetCurrentVersionPublishResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Indicates whether automatic upgrade is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Enabled.</description></item>
            /// <item><description><b>0</b>: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AutoUpgrade")]
            [Validation(Required=false)]
            public int? AutoUpgrade { get; set; }

            /// <summary>
            /// <para>Indicates whether the current user supports custom upgrades in Security Center. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Supported.</description></item>
            /// <item><description><b>false</b>: Not supported.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("BigCustomer")]
            [Validation(Required=false)]
            public bool? BigCustomer { get; set; }

            /// <summary>
            /// <para>The current version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0.8</para>
            /// </summary>
            [NameInMap("CurVersion")]
            [Validation(Required=false)]
            public string CurVersion { get; set; }

            /// <summary>
            /// <para>The timestamp for the forced client upgrade.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1732506308000</para>
            /// </summary>
            [NameInMap("ForceUpgradeTime")]
            [Validation(Required=false)]
            public long? ForceUpgradeTime { get; set; }

            /// <summary>
            /// <para>Indicates whether the canary release policy is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Enabled.</description></item>
            /// <item><description><b>0</b>: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("GraySwitchStatus")]
            [Validation(Required=false)]
            public int? GraySwitchStatus { get; set; }

            /// <summary>
            /// <para>The latest client version number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0.9</para>
            /// </summary>
            [NameInMap("LatestVersion")]
            [Validation(Required=false)]
            public string LatestVersion { get; set; }

            /// <summary>
            /// <para>The timestamp when the latest client version was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1662639150000</para>
            /// </summary>
            [NameInMap("LatestVersionCreate")]
            [Validation(Required=false)]
            public long? LatestVersionCreate { get; set; }

            /// <summary>
            /// <para>The description of the latest version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("LatestVersionDesc")]
            [Validation(Required=false)]
            public string LatestVersionDesc { get; set; }

            /// <summary>
            /// <para>The release status of the current version. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Not started.</description></item>
            /// <item><description><b>1</b>: Being released.</description></item>
            /// <item><description><b>2</b>: Release completed.</description></item>
            /// <item><description><b>3</b>: Release paused.</description></item>
            /// <item><description><b>4</b>: Forced upgrade in progress.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PublishStatus")]
            [Validation(Required=false)]
            public int? PublishStatus { get; set; }

            /// <summary>
            /// <para>The target version to upgrade to.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0.9</para>
            /// </summary>
            [NameInMap("UpgradeVersion")]
            [Validation(Required=false)]
            public string UpgradeVersion { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request. Alibaba Cloud generates a unique identifier for each request. You can use the ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1383B0DB-D5D6-4B0C-9E6B-75939C8E67FE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
