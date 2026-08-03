// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class UpdateDataAgentMemoryRequest : TeaModel {
        /// <summary>
        /// <para>The memory content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Diamond pricing analysis requires examining the skewness and outliers of the distribution of each feature.</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The current DMS unit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("DMSUnit")]
        [Validation(Required=false)]
        public string DMSUnit { get; set; }

        /// <summary>
        /// <para>The source ID.</para>
        /// <list type="bullet">
        /// <item><description>If MemFrom is set to session, FromId indicates the session ID.</description></item>
        /// <item><description>If MemFrom is set to user, FromId indicates the RAM user ID.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>8zm3**********g3yxa1</para>
        /// </summary>
        [NameInMap("FromId")]
        [Validation(Required=false)]
        public string FromId { get; set; }

        /// <summary>
        /// <para>The memory source. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>session: generated from a session.</description></item>
        /// <item><description>user: edited by a user.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>user</para>
        /// </summary>
        [NameInMap("MemFrom")]
        [Validation(Required=false)]
        public string MemFrom { get; set; }

        /// <summary>
        /// <para>The memory UUID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ed3f67***********ed</para>
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
