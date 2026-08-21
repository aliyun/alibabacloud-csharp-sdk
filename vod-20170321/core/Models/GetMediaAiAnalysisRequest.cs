// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetMediaAiAnalysisRequest : TeaModel {
        /// <summary>
        /// <para>The expiration time of the image access URL. Unit: seconds.</para>
        /// <list type="bullet">
        /// <item><description>If OutputType is set to cdn:<list type="bullet">
        /// <item><description>Only image URLs with URL authentication enabled expire. Otherwise, the URLs are permanently valid.</description></item>
        /// <item><description>Minimum value: 1.</description></item>
        /// <item><description>Maximum value: unlimited.</description></item>
        /// <item><description>Default value: If this parameter is not specified, the default validity period specified in URL authentication settings is used.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>If OutputType is set to oss:<list type="bullet">
        /// <item><description>Only image URLs with private storage permissions expire. Otherwise, the URLs are permanently valid.</description></item>
        /// <item><description>Minimum value: 1.</description></item>
        /// <item><description>Maximum value: To reduce security risks to the origin server, the maximum value is <b>2592000</b> (30 days) if images are stored in a bucket managed by ApsaraVideo VOD, and <b>129600</b> (36 hours) if images are stored in your own OSS bucket.</description></item>
        /// <item><description>Default value: If this parameter is not specified, the value is 3600.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>3600</para>
        /// </summary>
        [NameInMap("AuthTimeout")]
        [Validation(Required=false)]
        public string AuthTimeout { get; set; }

        /// <summary>
        /// <para>The audio ID. You can query the audio ID in the ApsaraVideo VOD console or obtain it from the response of the <a href="https://help.aliyun.com/document_detail/86044.html">SearchMedia</a> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>006204a11bb386bb25491f95f****</para>
        /// </summary>
        [NameInMap("MediaId")]
        [Validation(Required=false)]
        public string MediaId { get; set; }

        /// <summary>
        /// <para>The type of the output URL. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>oss</b>: back-to-origin URL.</description></item>
        /// <item><description><b>cdn</b> (default): accelerated URL.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cdn</para>
        /// </summary>
        [NameInMap("OutputType")]
        [Validation(Required=false)]
        public string OutputType { get; set; }

        /// <summary>
        /// <para>The type of analysis results. Separate multiple types with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>Chapter</para>
        /// </summary>
        [NameInMap("ResultTypes")]
        [Validation(Required=false)]
        public string ResultTypes { get; set; }

    }

}
