// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetMediaInfoRequest : TeaModel {
        /// <summary>
        /// <para>The validity period of the signed URL, in seconds.</para>
        /// </summary>
        [NameInMap("AuthTimeout")]
        [Validation(Required=false)]
        public long? AuthTimeout { get; set; }

        /// <summary>
        /// <para>The address of the media asset to query. You must first register the media asset in the IMS media library and bind it to a <c>mediaId</c>.</para>
        /// <list type="bullet">
        /// <item><description>Object Storage Service (OSS) URL. Two formats are supported:</description></item>
        /// </list>
        /// <para><c>http(s)://example-bucket.oss-cn-shanghai.aliyuncs.com/example.mp4</c></para>
        /// <para><c>oss://example-bucket/example.mp4</c>. When you use this format, the OSS region defaults to the service endpoint region.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://example-bucket.oss-cn-shanghai.aliyuncs.com/example.mp4">http://example-bucket.oss-cn-shanghai.aliyuncs.com/example.mp4</a></para>
        /// </summary>
        [NameInMap("InputURL")]
        [Validation(Required=false)]
        public string InputURL { get; set; }

        /// <summary>
        /// <para>The ID of the media asset in Intelligent Media Services (IMS). If you omit this parameter, you must specify <c>InputURL</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>20b48fb04483915d4f2cd8ac</b></b></para>
        /// </summary>
        [NameInMap("MediaId")]
        [Validation(Required=false)]
        public string MediaId { get; set; }

        /// <summary>
        /// <para>The type of URL to return for the media asset file.</para>
        /// <list type="bullet">
        /// <item><description><para><c>oss</c>: Returns the OSS URL. This is the default value.</para>
        /// </description></item>
        /// <item><description><para><c>cdn</c>: Returns the Content Delivery Network (CDN) URL. A CDN URL is returned only if the media asset was imported from Video on Demand (VOD) and has a CDN domain name configured in VOD.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cdn</para>
        /// </summary>
        [NameInMap("OutputType")]
        [Validation(Required=false)]
        public string OutputType { get; set; }

        /// <summary>
        /// <para>Whether to return detailed information for specific media asset fields. The only supported field is <c>AiRoughData.StandardSmartTagJob</c>, which specifies how the result of a tag analysis task is returned.</para>
        /// <list type="bullet">
        /// <item><description><para><c>false</c>: The task result is returned as a URL. This is the default value.</para>
        /// </description></item>
        /// <item><description><para><c>true</c>: The task result is returned as a string.</para>
        /// </description></item>
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
