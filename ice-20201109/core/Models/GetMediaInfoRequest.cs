// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetMediaInfoRequest : TeaModel {
        /// <summary>
        /// <para>The input URL of the media asset in another service. The URL must be registered in the IMS content library and bound to the ID of the media asset in IMS.</para>
        /// <list type="bullet">
        /// <item><description>For a media asset from Object Storage Service (OSS), the URL may have one of the following formats:</description></item>
        /// </list>
        /// <para>http(s)://example-bucket.oss-cn-shanghai.aliyuncs.com/example.mp4 or</para>
        /// <para>oss://example-bucket/example.mp4. The second format indicates that the region in which the OSS bucket of the media asset resides is the same as the region in which OSS is activated.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://example-bucket.oss-cn-shanghai.aliyuncs.com/example.mp4">http://example-bucket.oss-cn-shanghai.aliyuncs.com/example.mp4</a></para>
        /// </summary>
        [NameInMap("InputURL")]
        [Validation(Required=false)]
        public string InputURL { get; set; }

        /// <summary>
        /// <para>The ID of the media asset in IMS. If this parameter is left empty, the InputURL parameter must be specified.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>20b48fb04483915d4f2cd8ac</b></b></para>
        /// </summary>
        [NameInMap("MediaId")]
        [Validation(Required=false)]
        public string MediaId { get; set; }

        /// <summary>
        /// <para>The type of the URL of the media asset to return in the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>oss (default): an OSS URL.</description></item>
        /// <item><description>cdn: a CDN URL. A CDN URL is returned only if the media asset is imported from ApsaraVideo VOD and the relevant domain name is an accelerated domain name in ApsaraVideo VOD.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cdn</para>
        /// </summary>
        [NameInMap("OutputType")]
        [Validation(Required=false)]
        public string OutputType { get; set; }

        /// <summary>
        /// <para>Specifies whether to return detailed information for specific media asset attributes. Supported attributes: AiRoughData.StandardSmartTagJob, which specifies whether to return detailed tag information if a tagging job has been submitted for the media asset. Valid values for the attribute:</para>
        /// <list type="bullet">
        /// <item><description>false (default): The job result is returned as a URL.</description></item>
        /// <item><description>true: The job result is returned as text.</description></item>
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
