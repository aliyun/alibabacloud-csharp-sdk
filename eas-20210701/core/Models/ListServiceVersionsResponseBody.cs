// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class ListServiceVersionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The current page number of the returned historical versions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of historical versions returned on each page.</para>
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
        /// <para>The total number of versions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>166</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        /// <summary>
        /// <para>The list of versions.</para>
        /// </summary>
        [NameInMap("Versions")]
        [Validation(Required=false)]
        public List<ListServiceVersionsResponseBodyVersions> Versions { get; set; }
        public class ListServiceVersionsResponseBodyVersions : TeaModel {
            /// <summary>
            /// <para>The UTC time when the version was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-08-29T22:02:14Z</para>
            /// </summary>
            [NameInMap("BuildTime")]
            [Validation(Required=false)]
            public string BuildTime { get; set; }

            /// <summary>
            /// <para>The availability of the image. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Available.</description></item>
            /// <item><description>false: Unavailable.</description></item>
            /// <item><description>unknown: Unknown.</description></item>
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
            /// <para>The summary of the service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Service is Running</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The remarks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>new version.</para>
            /// </summary>
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            /// <summary>
            /// <para>The deployment configuration of the service. This field is returned only for custom image deployments.</para>
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
            /// <para>Indicates whether the EAS service is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Enabled.</description></item>
            /// <item><description>false: Disabled.</description></item>
            /// <item><description>unknown: Unknown.</description></item>
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
