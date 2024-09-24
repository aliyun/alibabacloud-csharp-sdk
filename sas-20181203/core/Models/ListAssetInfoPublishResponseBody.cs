// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListAssetInfoPublishResponseBody : TeaModel {
        [NameInMap("AssetList")]
        [Validation(Required=false)]
        public List<ListAssetInfoPublishResponseBodyAssetList> AssetList { get; set; }
        public class ListAssetInfoPublishResponseBodyAssetList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>0.0.8</para>
            /// </summary>
            [NameInMap("CurVersion")]
            [Validation(Required=false)]
            public string CurVersion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1724522400000</para>
            /// </summary>
            [NameInMap("LastUpgradeTime")]
            [Validation(Required=false)]
            public long? LastUpgradeTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("UpgradeEnable")]
            [Validation(Required=false)]
            public bool? UpgradeEnable { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2a98f149-0256-414c-a29a-a69f8a75****</para>
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3956048F-9D73-5EDB-834B-4827BB483977</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
