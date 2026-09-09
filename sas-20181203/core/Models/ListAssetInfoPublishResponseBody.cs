// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListAssetInfoPublishResponseBody : TeaModel {
        /// <summary>
        /// <para>The server list information.</para>
        /// </summary>
        [NameInMap("AssetList")]
        [Validation(Required=false)]
        public List<ListAssetInfoPublishResponseBodyAssetList> AssetList { get; set; }
        public class ListAssetInfoPublishResponseBodyAssetList : TeaModel {
            /// <summary>
            /// <para>The current client version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0.8</para>
            /// </summary>
            [NameInMap("CurVersion")]
            [Validation(Required=false)]
            public string CurVersion { get; set; }

            /// <summary>
            /// <para>The time of the last upgrade. The value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1724522400000</para>
            /// </summary>
            [NameInMap("LastUpgradeTime")]
            [Validation(Required=false)]
            public long? LastUpgradeTime { get; set; }

            /// <summary>
            /// <para>The client release status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Not started.</description></item>
            /// <item><description><b>1</b>: Publishing.</description></item>
            /// <item><description><b>2</b>: Publishing completed.</description></item>
            /// <item><description><b>3</b>: Publishing paused.</description></item>
            /// <item><description><b>4</b>: Force upgrading.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>Indicates whether the upgrade is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Enabled.</description></item>
            /// <item><description><b>false</b>: Not enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("UpgradeEnable")]
            [Validation(Required=false)]
            public bool? UpgradeEnable { get; set; }

            /// <summary>
            /// <para>The UUID of the Security Center asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2a98f149-0256-414c-a29a-a69f8a75****</para>
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request. The ID is a unique identifier that Alibaba Cloud generates for the request. You can use the ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3956048F-9D73-5EDB-834B-4827BB483977</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
