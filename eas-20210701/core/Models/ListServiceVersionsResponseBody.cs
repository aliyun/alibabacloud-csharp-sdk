// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class ListServiceVersionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E089D584-B6F4-50C4-9902-DA2295B7****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>166</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        /// <summary>
        /// <para>The historical versions of the service.</para>
        /// </summary>
        [NameInMap("Versions")]
        [Validation(Required=false)]
        public List<ListServiceVersionsResponseBodyVersions> Versions { get; set; }
        public class ListServiceVersionsResponseBodyVersions : TeaModel {
            /// <summary>
            /// <para>The time when the service version was created. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-08-29T22:02:14Z</para>
            /// </summary>
            [NameInMap("BuildTime")]
            [Validation(Required=false)]
            public string BuildTime { get; set; }

            /// <summary>
            /// <para>Indicates whether the image is available. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: The image is available.</description></item>
            /// <item><description>false: The image is unavailable.</description></item>
            /// <item><description>unknown: The availability of the image is unknown.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ImageAvailable")]
            [Validation(Required=false)]
            public string ImageAvailable { get; set; }

            /// <summary>
            /// <para>The image ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public int? ImageId { get; set; }

            /// <summary>
            /// <para>The returned message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Service is Running</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The service deployment configurations. This parameter is returned only if the service is deployed by using a custom image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///     &quot;metadata&quot;: {
            ///         &quot;cpu&quot;: 1,
            ///         &quot;instance&quot;: 1,
            ///         &quot;memory&quot;: 1024
            ///     },
            ///     &quot;name&quot;: &quot;echo&quot;
            /// }</para>
            /// </summary>
            [NameInMap("ServiceConfig")]
            [Validation(Required=false)]
            public string ServiceConfig { get; set; }

            /// <summary>
            /// <para>Indicates whether Elastic Algorithm service (EAS) is activated. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: EAS is activated.</description></item>
            /// <item><description>false: EAS is not activated.</description></item>
            /// <item><description>unknown: The activation of EAS is unknown.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ServiceRunnable")]
            [Validation(Required=false)]
            public string ServiceRunnable { get; set; }

        }

    }

}
