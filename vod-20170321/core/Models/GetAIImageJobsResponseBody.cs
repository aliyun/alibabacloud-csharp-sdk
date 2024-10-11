// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetAIImageJobsResponseBody : TeaModel {
        /// <summary>
        /// <para>The image AI processing jobs.</para>
        /// </summary>
        [NameInMap("AIImageJobList")]
        [Validation(Required=false)]
        public List<GetAIImageJobsResponseBodyAIImageJobList> AIImageJobList { get; set; }
        public class GetAIImageJobsResponseBodyAIImageJobList : TeaModel {
            /// <summary>
            /// <para>The Object Storage Service (OSS) URL of the image file.</para>
            /// <remarks>
            /// <para>This parameter does not include the complete authentication information. To obtain the authentication information, you must generate a signed URL. Alternatively, you can call the <a href="~~ListAIImageInfo~~">ListAIImageInfo</a> operation to obtain the image information.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;Score&quot;:5.035636554444242,&quot;Url&quot;:&quot;<a href="http://outin-*****.oss-cn-shanghai.aliyuncs.com/357a8748c577*****789d2726e6436aa/image/ai/b0a7612554d*****5cbe3-00001.gif%22%7D%5D">http://outin-*****.oss-cn-shanghai.aliyuncs.com/357a8748c577*****789d2726e6436aa/image/ai/b0a7612554d*****5cbe3-00001.gif&quot;}]</a></para>
            /// </summary>
            [NameInMap("AIImageResult")]
            [Validation(Required=false)]
            public string AIImageResult { get; set; }

            /// <summary>
            /// <para>The error code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>The time when the image AI processing job was created. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-10-15T03:30:03Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The ID of the image AI processing job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cf08a2c6e11e*****de1711b738b9067</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>The error message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The status of the job. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>success</b></description></item>
            /// <item><description><b>fail</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The configurations of the AI template that was used to submit the job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;Format&quot;:&quot;gif&quot;,&quot;SetDefaultCover&quot;:&quot;true&quot;}</para>
            /// </summary>
            [NameInMap("TemplateConfig")]
            [Validation(Required=false)]
            public string TemplateConfig { get; set; }

            /// <summary>
            /// <para>The ID of the AI template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5a86a00f15194*****d7fe7de1b4a173</para>
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

            /// <summary>
            /// <para>The user data.</para>
            /// <list type="bullet">
            /// <item><description>The value must be a JSON string.</description></item>
            /// <item><description>The MessageCallback or Extend parameter is returned.</description></item>
            /// <item><description>The value contains a maximum of 512 bytes.</description></item>
            /// </list>
            /// <para>For more information, see the &quot;UserData: specifies the custom configurations for media upload&quot; section of the <a href="https://help.aliyun.com/document_detail/86952.html">Request parameters</a> topic.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;Extend&quot;:{&quot;localId&quot;:&quot;****&quot;,&quot;test&quot;:&quot;www&quot;}}</para>
            /// </summary>
            [NameInMap("UserData")]
            [Validation(Required=false)]
            public string UserData { get; set; }

            /// <summary>
            /// <para>The ID of the video.</para>
            /// 
            /// <b>Example:</b>
            /// <para>357a8748c577*****789d2726e6436aa</para>
            /// </summary>
            [NameInMap("VideoId")]
            [Validation(Required=false)]
            public string VideoId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7721B494-1F78-4E*****E8-A7CEE7315BFA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
