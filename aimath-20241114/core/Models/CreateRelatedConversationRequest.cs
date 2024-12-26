// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIMath20241114.Models
{
    public class CreateRelatedConversationRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ex_pop_1731848070815_funI</para>
        /// </summary>
        [NameInMap("ExerciseCode")]
        [Validation(Required=false)]
        public string ExerciseCode { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>725e5550-8f81-42e0-a4db-d2de1be52afc</para>
        /// </summary>
        [NameInMap("OuterBizId")]
        [Validation(Required=false)]
        public string OuterBizId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pop_1731848070815</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
