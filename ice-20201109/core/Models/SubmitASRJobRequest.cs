// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitASRJobRequest : TeaModel {
        /// <summary>
        /// <para>The task description. The value can be up to 128 bytes in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test description</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The duration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>00:00:10</para>
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public string Duration { get; set; }

        /// <summary>
        /// <para>The audio-to-text recognition configuration:</para>
        /// <list type="bullet">
        /// <item><description>HotwordLibraryIdList: the list of hotword library IDs. Currently, only one hotword library ID can be specified. Support for multiple hotword library IDs is planned for the future.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;HotwordLibraryIdList&quot;: &quot;<b><b><b>2609a14f54a0636b7e16</b></b></b>&quot;
        /// }</para>
        /// </summary>
        [NameInMap("EditingConfig")]
        [Validation(Required=false)]
        public string EditingConfig { get; set; }

        /// <summary>
        /// <para>The input configuration. OSS URLs and content library material IDs are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://example-bucket.oss-cn-shanghai.aliyuncs.com/example.mp4 or <b><b>20b48fb04483915d4f2cd8ac</b></b></para>
        /// </summary>
        [NameInMap("InputFile")]
        [Validation(Required=false)]
        public string InputFile { get; set; }

        /// <summary>
        /// <para>The start time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>00:00:00</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The task title. The value can be up to 128 bytes in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test title</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <para>The custom settings. You can pass in business information such as the business environment and task information. The value is a JSON string.</para>
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
