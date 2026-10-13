// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class CreatePublishTaskShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The workspace key. If not specified, the default workspace is accessed. Obtain the key value from the business management page of the Alibaba Cloud account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ac627989eb4f8a98ed05fd098bbae5_p_beebot_public</para>
        /// </summary>
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        /// <summary>
        /// <para>The publish unit type. To publish a chatbot, use the CreateInstancePublishTask API.</para>
        /// 
        /// <b>Example:</b>
        /// <para>faq</para>
        /// </summary>
        [NameInMap("BizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        /// <summary>
        /// <para>Additional publish information. Currently supported: if BizType is faq, this field specifies category IDs, indicating that only knowledge under these categories is published.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;8521&quot;]</para>
        /// </summary>
        [NameInMap("DataIdList")]
        [Validation(Required=false)]
        public string DataIdListShrink { get; set; }

    }

}
