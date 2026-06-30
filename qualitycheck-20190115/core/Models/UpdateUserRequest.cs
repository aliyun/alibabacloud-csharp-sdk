// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class UpdateUserRequest : TeaModel {
        /// <summary>
        /// <para>Workspace ID.</para>
        /// </summary>
        [NameInMap("BaseMeAgentId")]
        [Validation(Required=false)]
        public long? BaseMeAgentId { get; set; }

        /// <summary>
        /// <para>This API supports batch modification of user roles. The value of the \<c>jsonStr\\</c> input parameter is a List type. Refer to the example value. See the detailed information below for the complete JSON string content.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;aliUid&quot;:&quot;2951869706989****&quot;,&quot;roleName&quot;:&quot;ADMIN&quot;},{&quot;aliUid&quot;:&quot;2557461687048****&quot;,&quot;roleName&quot;:&quot;ADMIN&quot;}]</para>
        /// </summary>
        [NameInMap("JsonStr")]
        [Validation(Required=false)]
        public string JsonStr { get; set; }

    }

}
