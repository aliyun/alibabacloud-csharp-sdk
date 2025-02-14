// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitASRJobRequest : TeaModel {
        /// <summary>
        /// <para>The job description, which can up to 128 bytes in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试描述</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The speech duration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>00:00:10</para>
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public string Duration { get; set; }

        [NameInMap("EditingConfig")]
        [Validation(Required=false)]
        public string EditingConfig { get; set; }

        /// <summary>
        /// <para>The input file. You can specify an Object Storage Service (OSS) URL or the ID of a media asset in the media asset library.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://example-bucket.oss-cn-shanghai.aliyuncs.com/example.mp4 或 <b><b>20b48fb04483915d4f2cd8ac</b></b></para>
        /// </summary>
        [NameInMap("InputFile")]
        [Validation(Required=false)]
        public string InputFile { get; set; }

        /// <summary>
        /// <para>The start time of the speech to recognize.</para>
        /// 
        /// <b>Example:</b>
        /// <para>00:00:00</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The job title, which can be up to 128 bytes in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试标题</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <para>The user-defined data in the JSON format. You can specify your business information, such as the business environment and job information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///       &quot;user&quot;: &quot;data&quot;,
        ///       &quot;env&quot;: &quot;prod&quot;
        /// }</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
