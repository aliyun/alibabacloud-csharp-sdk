// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitTextGenerateJobRequest : TeaModel {
        /// <summary>
        /// <para>The job description, with a maximum length of 1,024 bytes (UTF-8 encoded).</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test description</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The generation configuration, in JSON format.</para>
        /// <para>If <c>Type</c> is set to <c>Title</c> or <c>MarketingCopy</c>, specify the following fields:</para>
        /// <list type="bullet">
        /// <item><description><para><c>keywords</c>: The keywords used to generate the title or marketing copy. This parameter is required.</para>
        /// </description></item>
        /// <item><description><para><c>textLength</c>: The target length of the generated text, in characters. Valid values: 5 to 1,000. The actual length of the output is less than or equal to this value. This parameter is required.</para>
        /// </description></item>
        /// <item><description><para><c>targetCount</c>: The number of copy variations to generate. Valid values: 1 to 1,000. This parameter is required.</para>
        /// </description></item>
        /// </list>
        /// <para>If <c>Type</c> is set to <c>StoryboardScript</c>, specify the following field:</para>
        /// <list type="bullet">
        /// <item><description><c>originText</c>: The original text used to generate the storyboard script. This parameter is required.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;keywords&quot;:&quot;New cake shop, animal cream&quot;,&quot;textLength&quot;:100,&quot;targetCount&quot;:3}
        /// or
        /// {&quot;originText&quot;: &quot;A new cake shop just opened on the street, selling cream cakes, fruit cakes, bread, muffins, etc. A coffee shop opened across from the cake shop, with a steady stream of customers.&quot;}</para>
        /// </summary>
        [NameInMap("GenerateConfig")]
        [Validation(Required=false)]
        public string GenerateConfig { get; set; }

        /// <summary>
        /// <para>The job title.</para>
        /// <para>\- The maximum length is 128 bytes.</para>
        /// <para>\- UTF-8 encoding is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test title</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <para>The job type.</para>
        /// <para><b>Valid values:</b></para>
        /// <list type="bullet">
        /// <item><description><para><c>MarketingCopy</c>: Generates marketing copy.</para>
        /// </description></item>
        /// <item><description><para><c>Title</c>: Generates a short video title.</para>
        /// </description></item>
        /// <item><description><para><c>StoryboardScript</c>: Generates a storyboard script from text.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>MarketingCopy</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The custom settings in JSON format. The maximum length is 512 bytes. You can use this parameter to specify a <a href="https://help.aliyun.com/document_detail/451631.html">custom callback address</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;NotifyAddress&quot;:&quot;<a href="http://xx.xx.xxx%22%7D">http://xx.xx.xxx&quot;}</a> or {&quot;NotifyAddress&quot;:&quot;<a href="https://xx.xx.xxx%22%7D">https://xx.xx.xxx&quot;}</a> or {&quot;NotifyAddress&quot;:&quot;ice-callback-demo&quot;}</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
