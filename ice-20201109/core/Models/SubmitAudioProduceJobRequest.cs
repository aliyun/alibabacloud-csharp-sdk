// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitAudioProduceJobRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>任务描述  长度不超过1024字节  UTF8编码</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;voice&quot;:&quot;Siqi&quot;,&quot;format&quot;:&quot;MP3&quot;,&quot;volume&quot;:50}</para>
        /// </summary>
        [NameInMap("EditingConfig")]
        [Validation(Required=false)]
        public string EditingConfig { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试文本</para>
        /// </summary>
        [NameInMap("InputConfig")]
        [Validation(Required=false)]
        public string InputConfig { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;bucket&quot;:&quot;bucket&quot;,&quot;object&quot;:&quot;objeck&quot;}</para>
        /// </summary>
        [NameInMap("OutputConfig")]
        [Validation(Required=false)]
        public string OutputConfig { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Overwrite")]
        [Validation(Required=false)]
        public bool? Overwrite { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>任务标题。若不提供，根据日期自动生成默认title  长度不超过128字节  UTF8编码</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;user&quot;:&quot;data&quot;}</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
