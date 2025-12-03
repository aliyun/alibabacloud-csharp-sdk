// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetMezzanineInfoRequest : TeaModel {
        /// <summary>
        /// <para>The type of additional information. Separate multiple values with commas (,). By default, only the basic information is returned. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>video</b>: video stream information</description></item>
        /// <item><description><b>audio</b>: audio stream information</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>video</para>
        /// </summary>
        [NameInMap("AdditionType")]
        [Validation(Required=false)]
        public string AdditionType { get; set; }

        /// <summary>
        /// <para>The validity period of the mezzanine file URL. Unit: seconds. Default value: <b>1800</b>. Minimum value: <b>1</b>.</para>
        /// <list type="bullet">
        /// <item><description><para>If the OutputType parameter is set to <b>cdn</b>:</para>
        /// <list type="bullet">
        /// <item><description>The mezzanine file URL has a validity period only if URL signing is enabled. Otherwise, the mezzanine file URL is permanently valid.</description></item>
        /// <item><description>Minimum value: <b>1</b>.</description></item>
        /// <item><description>Maximum Value: unlimited.</description></item>
        /// <item><description>Default value: If you do not set this parameter, the default validity period that is specified in URL signing is used.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <!---->
        /// 
        /// <list type="bullet">
        /// <item><description><para>If the OutputType parameter is set to <b>oss</b>:</para>
        /// <list type="bullet">
        /// <item><description>The mezzanine file URL has a validity period only if the permissions on the Object Storage Service (OSS) bucket are private. Otherwise, the mezzanine file URL is permanently valid.</description></item>
        /// <item><description>Minimum value: <b>1</b>.</description></item>
        /// <item><description>Maximum value: <b>2592000</b> (30 days). The maximum value is limited to reduce security risks of the origin.</description></item>
        /// <item><description>Default value: If you do not set this parameter, the default value is <b>3600</b>.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>3600</para>
        /// </summary>
        [NameInMap("AuthTimeout")]
        [Validation(Required=false)]
        public long? AuthTimeout { get; set; }

        /// <summary>
        /// <para>The type of the mezzanine file URL. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>oss</b>: OSS URL</description></item>
        /// <item><description><b>cdn</b> (default): Content Delivery Network (CDN) URL</description></item>
        /// </list>
        /// <remarks>
        /// <para>If the mezzanine file is stored in a bucket of the in type, only an OSS URL is returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>oss</para>
        /// </summary>
        [NameInMap("OutputType")]
        [Validation(Required=false)]
        public string OutputType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123-123</para>
        /// </summary>
        [NameInMap("ReferenceId")]
        [Validation(Required=false)]
        public string ReferenceId { get; set; }

        /// <summary>
        /// <para>The ID of the video.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1f1a6fc03ca04814031b8a6559e****</para>
        /// </summary>
        [NameInMap("VideoId")]
        [Validation(Required=false)]
        public string VideoId { get; set; }

    }

}
