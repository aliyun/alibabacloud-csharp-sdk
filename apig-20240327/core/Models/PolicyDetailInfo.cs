// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class PolicyDetailInfo : TeaModel {
        /// <summary>
        /// <para>The policy class ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cls-xxx</para>
        /// </summary>
        [NameInMap("classId")]
        [Validation(Required=false)]
        public string ClassId { get; set; }

        /// <summary>
        /// <para>The policy type name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RateLimit</para>
        /// </summary>
        [NameInMap("className")]
        [Validation(Required=false)]
        public string ClassName { get; set; }

        /// <summary>
        /// <para>The policy configuration content (JSON string).</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;rate&quot;:100,&quot;burst&quot;:50}</para>
        /// </summary>
        [NameInMap("config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <para>The policy description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>每秒限流100次</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The policy name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-rate-limit</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The policy ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>plc-xxx</para>
        /// </summary>
        [NameInMap("policyId")]
        [Validation(Required=false)]
        public string PolicyId { get; set; }

    }

}
