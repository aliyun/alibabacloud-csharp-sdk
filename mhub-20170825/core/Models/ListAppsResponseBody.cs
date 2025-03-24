// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mhub20170825.Models
{
    public class ListAppsResponseBody : TeaModel {
        [NameInMap("AppInfos")]
        [Validation(Required=false)]
        public ListAppsResponseBodyAppInfos AppInfos { get; set; }
        public class ListAppsResponseBodyAppInfos : TeaModel {
            [NameInMap("AppInfo")]
            [Validation(Required=false)]
            public List<ListAppsResponseBodyAppInfosAppInfo> AppInfo { get; set; }
            public class ListAppsResponseBodyAppInfosAppInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>123456</para>
                /// </summary>
                [NameInMap("AppKey")]
                [Validation(Required=false)]
                public string AppKey { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>com.test.ios</para>
                /// </summary>
                [NameInMap("BundleId")]
                [Validation(Required=false)]
                public string BundleId { get; set; }

                [NameInMap("EncodedIcon")]
                [Validation(Required=false)]
                public string EncodedIcon { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("IndustryId")]
                [Validation(Required=false)]
                public int? IndustryId { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>com.test.android</para>
                /// </summary>
                [NameInMap("PackageName")]
                [Validation(Required=false)]
                public string PackageName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Readonly")]
                [Validation(Required=false)]
                public bool? Readonly { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public int? Type { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>126D4DDD-05A5-49B1-B18C-39C4A929BFB2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>enabled</para>
        /// </summary>
        [NameInMap("UbsmsStatus")]
        [Validation(Required=false)]
        public string UbsmsStatus { get; set; }

    }

}
