// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class UpdateSolutionRequest : TeaModel {
        /// <summary>
        /// <para>The workspace key. If this parameter is not specified, the default workspace is accessed. You can obtain the key from the business management page of the Alibaba Cloud account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ac627989eb4f8a98ed05fd098bbae5_p_beebot_public</para>
        /// </summary>
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        /// <summary>
        /// <para>The answer content.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Updated answer content</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The answer type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: plain text</description></item>
        /// <item><description>1: rich text</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ContentType")]
        [Validation(Required=false)]
        public int? ContentType { get; set; }

        /// <summary>
        /// <para>The list of perspective codes.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("PerspectiveCodes")]
        [Validation(Required=false)]
        public List<string> PerspectiveCodes { get; set; }

        /// <summary>
        /// <para>The answer ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100001333260</para>
        /// </summary>
        [NameInMap("SolutionId")]
        [Validation(Required=false)]
        public long? SolutionId { get; set; }

        /// <summary>
        /// <para>The list of tag IDs.</para>
        /// </summary>
        [NameInMap("TagIdList")]
        [Validation(Required=false)]
        public List<long?> TagIdList { get; set; }

    }

}
