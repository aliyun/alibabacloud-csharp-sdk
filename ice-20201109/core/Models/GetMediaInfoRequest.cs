// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetMediaInfoRequest : TeaModel {
        [NameInMap("AuthTimeout")]
        [Validation(Required=false)]
        public long? AuthTimeout { get; set; }

        /// <summary>
        /// <para>The address of the media asset in the corresponding system. Before use, the media asset must be registered in the IMS content library and bound to an IMS mediaId.</para>
        /// <list type="bullet">
        /// <item><description>OSS address. Two formats are supported:</description></item>
        /// </list>
        /// <para>http(s)://example-bucket.oss-ap-southeast-1.aliyuncs.com/example.mp4 or</para>
        /// <para>oss://example-bucket/example.mp4. This format assumes the OSS region is the same as the service access region by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://example-bucket.oss-cn-shanghai.aliyuncs.com/example.mp4">http://example-bucket.oss-cn-shanghai.aliyuncs.com/example.mp4</a></para>
        /// </summary>
        [NameInMap("InputURL")]
        [Validation(Required=false)]
        public string InputURL { get; set; }

        /// <summary>
        /// <para>The IMS media asset ID. If this parameter is empty, InputURL is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>20b48fb04483915d4f2cd8ac</b></b></para>
        /// </summary>
        [NameInMap("MediaId")]
        [Validation(Required=false)]
        public string MediaId { get; set; }

        /// <summary>
        /// <para>The type of the media file address in the response:</para>
        /// 
        /// <b>Example:</b>
        /// <para>cdn</para>
        /// </summary>
        [NameInMap("OutputType")]
        [Validation(Required=false)]
        public string OutputType { get; set; }

        /// <summary>
        /// <para>Specifies whether to return detailed information for the corresponding media asset fields. The following fields are supported:
        /// AiRoughData.StandardSmartTagJob: Specifies whether to return detailed tagging results if the media asset has been submitted for tag analysis.</para>
        /// <list type="bullet">
        /// <item><description>Default value: false. The task result is returned as a URL.</description></item>
        /// <item><description>true: The task result is returned as text.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;AiRoughData.StandardSmartTagJob&quot;: false}</para>
        /// </summary>
        [NameInMap("ReturnDetailedInfo")]
        [Validation(Required=false)]
        public string ReturnDetailedInfo { get; set; }

    }

}
