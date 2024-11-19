// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIMath20241114.Models
{
    public class UpdateStepRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1549d636-b102-4fee-8a99-fcc552aa9aa9</para>
        /// </summary>
        [NameInMap("ContentCode")]
        [Validation(Required=false)]
        public string ContentCode { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ex_pop_1731848070815_funI</para>
        /// </summary>
        [NameInMap("ExerciseCode")]
        [Validation(Required=false)]
        public string ExerciseCode { get; set; }

    }

}
