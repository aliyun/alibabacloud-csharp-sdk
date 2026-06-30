// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class CreateUserRequest : TeaModel {
        /// <summary>
        /// <para>Workspace ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("BaseMeAgentId")]
        [Validation(Required=false)]
        public long? BaseMeAgentId { get; set; }

        /// <summary>
        /// <para>A complete <b>JSON string</b>. For details, see the table below.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;aliUid&quot;:123,&quot;roleName&quot;:&quot;AGENT&quot;,&quot;userName&quot;:&quot;kefu01&quot;}]</para>
        /// </summary>
        [NameInMap("JsonStr")]
        [Validation(Required=false)]
        public string JsonStr { get; set; }

    }

}
