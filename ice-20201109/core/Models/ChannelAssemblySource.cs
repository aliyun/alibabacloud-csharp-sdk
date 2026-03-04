// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ChannelAssemblySource : TeaModel {
        /// <summary>
        /// <para>The ARN of the source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ims:mediaweaver:<regionId>:<userId>:vodSource/mySourceLocation/mySource</para>
        /// </summary>
        [NameInMap("Arn")]
        [Validation(Required=false)]
        public string Arn { get; set; }

        /// <summary>
        /// <para>The time when the source was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-10-20T07:15:51Z</para>
        /// </summary>
        [NameInMap("GmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        /// <summary>
        /// <para>The time when the source was last modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-11-07T10:12:01Z</para>
        /// </summary>
        [NameInMap("GmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        /// <summary>
        /// <para>The source configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{
        ///     &quot;sourceGroupName&quot;: &quot;mySourceGroup-1&quot;,
        ///     &quot;relativePath&quot;: &quot;group1/hls.m3u8&quot;,
        ///     &quot;packageType&quot;: &quot;hls&quot;
        /// }]</para>
        /// </summary>
        [NameInMap("HttpPackageConfigurations")]
        [Validation(Required=false)]
        public string HttpPackageConfigurations { get; set; }

        /// <summary>
        /// <para>The name of the source location.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MySourceLocation</para>
        /// </summary>
        [NameInMap("SourceLocationName")]
        [Validation(Required=false)]
        public string SourceLocationName { get; set; }

        /// <summary>
        /// <para>The name of the source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MyVodSource</para>
        /// </summary>
        [NameInMap("SourceName")]
        [Validation(Required=false)]
        public string SourceName { get; set; }

        /// <summary>
        /// <para>The source type. Valid values: vodSource and liveSource.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vodSource</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>The status of the source. 0: normal. 1: deleted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public int? State { get; set; }

    }

}
