// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class UpdateSourceRequest : TeaModel {
        /// <summary>
        /// <para>The source configurations.</para>
        /// <para>This parameter is required.</para>
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MySourcelocation</para>
        /// </summary>
        [NameInMap("SourceLocationName")]
        [Validation(Required=false)]
        public string SourceLocationName { get; set; }

        /// <summary>
        /// <para>The name of the source.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MySource</para>
        /// </summary>
        [NameInMap("SourceName")]
        [Validation(Required=false)]
        public string SourceName { get; set; }

        /// <summary>
        /// <para>The source type. Valid values: vodSource and liveSource.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vodSource</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

    }

}
