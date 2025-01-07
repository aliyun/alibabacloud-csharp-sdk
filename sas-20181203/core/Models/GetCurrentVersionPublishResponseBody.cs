// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetCurrentVersionPublishResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetCurrentVersionPublishResponseBodyData Data { get; set; }
        public class GetCurrentVersionPublishResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Indicates whether automatic upgrade is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: yes.</description></item>
            /// <item><description><b>0</b>: no.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AutoUpgrade")]
            [Validation(Required=false)]
            public int? AutoUpgrade { get; set; }

            /// <summary>
            /// <para>Indicates whether you can enable custom upgrade for the Security Center agent. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("BigCustomer")]
            [Validation(Required=false)]
            public bool? BigCustomer { get; set; }

            /// <summary>
            /// <para>The version of the Security Center agent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0.8</para>
            /// </summary>
            [NameInMap("CurVersion")]
            [Validation(Required=false)]
            public string CurVersion { get; set; }

            /// <summary>
            /// <para>The timestamp when the Security Center agent was forcibly upgraded.</para>
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
            /// <item><description><b>1</b>: yes.</description></item>
            /// <item><description>.<b>0</b>: no.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("GraySwitchStatus")]
            [Validation(Required=false)]
            public int? GraySwitchStatus { get; set; }

            /// <summary>
            /// <para>The latest version of the Security Center agent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0.9</para>
            /// </summary>
            [NameInMap("LatestVersion")]
            [Validation(Required=false)]
            public string LatestVersion { get; set; }

            /// <summary>
            /// <para>The timestamp when the latest version of the Security Center agent was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1662639150000</para>
            /// </summary>
            [NameInMap("LatestVersionCreate")]
            [Validation(Required=false)]
            public long? LatestVersionCreate { get; set; }

            /// <summary>
            /// <para>The description of about the latest version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("LatestVersionDesc")]
            [Validation(Required=false)]
            public string LatestVersionDesc { get; set; }

            /// <summary>
            /// <para>The publish status of the Security Center agent. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: not started.</description></item>
            /// <item><description><b>1</b>: publishing.</description></item>
            /// <item><description><b>2</b>: published.</description></item>
            /// <item><description><b>3</b>: publish suspended.</description></item>
            /// <item><description><b>4</b>: forcibly upgrading.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PublishStatus")]
            [Validation(Required=false)]
            public int? PublishStatus { get; set; }

            /// <summary>
            /// <para>The destination version of the Security Center agent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0.9</para>
            /// </summary>
            [NameInMap("UpgradeVersion")]
            [Validation(Required=false)]
            public string UpgradeVersion { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1383B0DB-D5D6-4B0C-9E6B-75939C8E67FE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
