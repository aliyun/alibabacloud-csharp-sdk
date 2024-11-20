// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitTextGenerateJobRequest : TeaModel {
        /// <summary>
        /// <para>The job description, which can be up to 1,024 bytes in length and must be encoded in UTF-8.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The text generation configurations, including keywords and the requirements for the word count and number of output copies.</para>
        /// </summary>
        [NameInMap("GenerateConfig")]
        [Validation(Required=false)]
        public string GenerateConfig { get; set; }

        /// <summary>
        /// <para>The job title.</para>
        /// <para>The job title can be up to 128 bytes in length.</para>
        /// <para>The value must be encoded in UTF-8.</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <para>The job type.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>MarketingCopy: the marketing copy.</description></item>
        /// <item><description>Title: the short video title.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>MarketingCopy</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The user-defined data in the JSON format, which can be up to 512 bytes in length. You can specify a custom callback URL. For more information, see <a href="https://help.aliyun.com/document_detail/451631.html">Configure a callback upon editing completion</a>.</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
