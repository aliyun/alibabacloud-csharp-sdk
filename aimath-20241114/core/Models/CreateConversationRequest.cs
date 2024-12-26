// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIMath20241114.Models
{
    public class CreateConversationRequest : TeaModel {
        [NameInMap("ExerciseAnalysis")]
        [Validation(Required=false)]
        public string ExerciseAnalysis { get; set; }

        [NameInMap("ExerciseAnswer")]
        [Validation(Required=false)]
        public string ExerciseAnswer { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ExerciseContent")]
        [Validation(Required=false)]
        public string ExerciseContent { get; set; }

        [NameInMap("ExerciseType")]
        [Validation(Required=false)]
        public string ExerciseType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2r560eHAbsknrfHXVZO4L</para>
        /// </summary>
        [NameInMap("OuterBizId")]
        [Validation(Required=false)]
        public string OuterBizId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>wx-xx-yy</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
