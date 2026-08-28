// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class UpdateSkillBizTagsRequest : TeaModel {
        /// <summary>
        /// <para>The request body.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public UpdateSkillBizTagsRequestBody Body { get; set; }
        public class UpdateSkillBizTagsRequestBody : TeaModel {
            /// <summary>
            /// <para>The business tags as a JSON array string.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;cs&quot;,&quot;qa&quot;,&quot;support&quot;]</para>
            /// </summary>
            [NameInMap("bizTags")]
            [Validation(Required=false)]
            public string BizTags { get; set; }

        }

    }

}
