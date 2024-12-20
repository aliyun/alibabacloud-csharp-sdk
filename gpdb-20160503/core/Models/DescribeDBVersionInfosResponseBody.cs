// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeDBVersionInfosResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ABB39CC3-4488-4857-905D-2E4A051D0521</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The queried minor versions.</para>
        /// </summary>
        [NameInMap("VersionDetails")]
        [Validation(Required=false)]
        public DescribeDBVersionInfosResponseBodyVersionDetails VersionDetails { get; set; }
        public class DescribeDBVersionInfosResponseBodyVersionDetails : TeaModel {
            /// <summary>
            /// <para>The queried minor version information about the instance in Serverless mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;Serverless&quot;: [
            ///                 {
            ///                     &quot;engineVersion&quot;: &quot;6.0&quot;,
            ///                     &quot;versionInfos&quot;: [
            ///                         {
            ///                             &quot;kernelVersion&quot;: &quot;v2.0.0.5&quot;,
            ///                             &quot;releaseDate&quot;: &quot;2023-05-28T07:48Z&quot;,
            ///                             &quot;expirationDate&quot;: &quot;2026-05-28T07:48Z&quot;
            ///                         },
            ///                         {
            ///                             &quot;kernelVersion&quot;: &quot;v2.0.0.1&quot;,
            ///                             &quot;releaseDate&quot;: &quot;2023-03-27T12:44Z&quot;,
            ///                             &quot;expirationDate&quot;: &quot;2026-03-27T12:44Z&quot;
            ///                         },
            ///                         {
            ///                             &quot;kernelVersion&quot;: &quot;v1.0.5.1&quot;,
            ///                             &quot;releaseDate&quot;: &quot;2023-02-22T11:39Z&quot;,
            ///                             &quot;expirationDate&quot;: &quot;2026-02-22T11:39Z&quot;
            ///                         }
            ///                     ]
            ///                 }
            /// ]</para>
            /// </summary>
            [NameInMap("Serverless")]
            [Validation(Required=false)]
            public object Serverless { get; set; }

            /// <summary>
            /// <para>The queried minor version information about the instance in elastic storage mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;StorageElasic&quot;: [
            ///                 {
            ///                     &quot;engineVersion&quot;: &quot;6.0&quot;,
            ///                     &quot;versionInfos&quot;: [
            ///                         {
            ///                             &quot;kernelVersion&quot;: &quot;v6.3.11.2&quot;,
            ///                             &quot;releaseDate&quot;: &quot;2023-08-17T09:14Z&quot;,
            ///                             &quot;expirationDate&quot;: &quot;2026-08-17T09:14Z&quot;
            ///                         }
            ///           },
            ///                 {
            ///                     &quot;engineVersion&quot;: &quot;7.0&quot;,
            ///                     &quot;versionInfos&quot;: [
            ///                         {
            ///                             &quot;kernelVersion&quot;: &quot;v7.0.2.0&quot;,
            ///                             &quot;releaseDate&quot;: &quot;2023-08-09T06:47Z&quot;,
            ///                             &quot;expirationDate&quot;: &quot;2026-08-09T06:47Z&quot;
            ///                         },
            ///                         {
            ///                             &quot;kernelVersion&quot;: &quot;v7.0.1.8&quot;,
            ///                             &quot;releaseDate&quot;: &quot;2023-05-25T06:56Z&quot;,
            ///                             &quot;expirationDate&quot;: &quot;2026-05-25T06:56Z&quot;
            ///                         }
            ///                     ]
            ///                 }
            /// ]</para>
            /// </summary>
            [NameInMap("StorageElastic")]
            [Validation(Required=false)]
            public object StorageElastic { get; set; }

        }

    }

}
