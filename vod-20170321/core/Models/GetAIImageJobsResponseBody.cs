// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetAIImageJobsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of AI image processing tasks.</para>
        /// </summary>
        [NameInMap("AIImageJobList")]
        [Validation(Required=false)]
        public List<GetAIImageJobsResponseBodyAIImageJobList> AIImageJobList { get; set; }
        public class GetAIImageJobsResponseBodyAIImageJobList : TeaModel {
            /// <summary>
            /// <para>The OSS URL of the AI image.</para>
            /// <remarks>
            /// <para>This is the task result. The URL does not contain complete authentication information. To obtain authentication information, generate it yourself or call the <a href="https://help.aliyun.com/document_detail/186924.html">ListAIImage</a> operation to retrieve the media asset result.</para>
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
            /// <para>The time when the AI image processing task was created. The time is in the <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z format (UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-10-15T03:30:03Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The ID of the AI image processing task.</para>
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
            /// <para>The task status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>success</b>: The task is successful.</description></item>
            /// <item><description><b>fail</b>: The task failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The snapshot of the configuration information of the specified template when the task was submitted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;Format&quot;:&quot;gif&quot;,&quot;SetDefaultCover&quot;:&quot;true&quot;}</para>
            /// </summary>
            [NameInMap("TemplateConfig")]
            [Validation(Required=false)]
            public string TemplateConfig { get; set; }

            /// <summary>
            /// <para>The AI template ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5a86a00f15194*****d7fe7de1b4a173</para>
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

            /// <summary>
            /// <para>The custom settings.</para>
            /// <list type="bullet">
            /// <item><description>The value must be a JSON string.</description></item>
            /// <item><description>The value must contain the MessageCallback or Extend parameter.</description></item>
            /// <item><description>The maximum length is 512 bytes.</description></item>
            /// </list>
            /// <para>For more information about the parameter structure, see <a href="https://help.aliyun.com/document_detail/86952.html">UserData</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;Extend&quot;:{&quot;localId&quot;:&quot;****&quot;,&quot;test&quot;:&quot;www&quot;}}</para>
            /// </summary>
            [NameInMap("UserData")]
            [Validation(Required=false)]
            public string UserData { get; set; }

            /// <summary>
            /// <para>The video ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>357a8748c577*****789d2726e6436aa</para>
            /// </summary>
            [NameInMap("VideoId")]
            [Validation(Required=false)]
            public string VideoId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7721B494-1F78-4E*****E8-A7CEE7315BFA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
