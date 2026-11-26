// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class SetKnowledgeBaseVisibilityResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The status code description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>019FF406-1B10-0065-A97D-2D1920C2A03D</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The target ID, which varies based on the target type.</para>
        /// <list type="bullet">
        /// <item><description>If the type is period, specify the period ID.</description></item>
        /// <item><description>If the type is objective, specify the objective ID.</description></item>
        /// <item><description>If the type is kr, specify the keyResult ID.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>kb_001</para>
        /// </summary>
        [NameInMap("targetId")]
        [Validation(Required=false)]
        public string TargetId { get; set; }

        /// <summary>
        /// <para>The type of the current permission. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>period: period type</description></item>
        /// <item><description>objective: objective type</description></item>
        /// <item><description>kr: keyResult type</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>KB</para>
        /// </summary>
        [NameInMap("targetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

        /// <summary>
        /// <para>The collection of user groups.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;group-1&quot;]</para>
        /// </summary>
        [NameInMap("userGroupIds")]
        [Validation(Required=false)]
        public List<string> UserGroupIds { get; set; }

        /// <summary>
        /// <para>The collection of users.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;10001&quot;]</para>
        /// </summary>
        [NameInMap("userIds")]
        [Validation(Required=false)]
        public List<string> UserIds { get; set; }

        /// <summary>
        /// <para>The visibility scope mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SPECIFIED</para>
        /// </summary>
        [NameInMap("visibilityMode")]
        [Validation(Required=false)]
        public string VisibilityMode { get; set; }

    }

}
