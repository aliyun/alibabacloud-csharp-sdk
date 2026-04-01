// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class UpgradeInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>5FFD9ED4-C2EC-4E89-B22B-1ACB6FE1D****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public UpgradeInfoResponseBodyResult Result { get; set; }
        public class UpgradeInfoResponseBodyResult : TeaModel {
            [NameInMap("UpgradeInfo")]
            [Validation(Required=false)]
            public UpgradeInfoResponseBodyResultUpgradeInfo UpgradeInfo { get; set; }
            public class UpgradeInfoResponseBodyResultUpgradeInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1.7.3</para>
                /// </summary>
                [NameInMap("CurRepoVersion")]
                [Validation(Required=false)]
                public string CurRepoVersion { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1.7.3</para>
                /// </summary>
                [NameInMap("UpdateRepoVersion")]
                [Validation(Required=false)]
                public string UpdateRepoVersion { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Upgrade")]
                [Validation(Required=false)]
                public bool? Upgrade { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2.2.4</para>
                /// </summary>
                [NameInMap("curApackVersion")]
                [Validation(Required=false)]
                public string CurApackVersion { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>8.17.0</para>
                /// </summary>
                [NameInMap("curEsVersion")]
                [Validation(Required=false)]
                public string CurEsVersion { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2.2.4</para>
                /// </summary>
                [NameInMap("upgradeApackVersion")]
                [Validation(Required=false)]
                public string UpgradeApackVersion { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>8.17.0</para>
                /// </summary>
                [NameInMap("upgradeEsVersion")]
                [Validation(Required=false)]
                public string UpgradeEsVersion { get; set; }

            }

        }

    }

}
