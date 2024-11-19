// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIMath20241114.Models
{
    public class GlobalConfirmRequest : TeaModel {
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
        /// <b>Example:</b>
        /// <para>2024-11-18</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public string Tag { get; set; }

    }

}
