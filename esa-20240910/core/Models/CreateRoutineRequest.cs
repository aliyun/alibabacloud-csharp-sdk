// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class CreateRoutineRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>the description of this routine</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test-routine1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5ms</para>
        /// </summary>
        [NameInMap("SpecName")]
        [Validation(Required=false)]
        public string SpecName { get; set; }

    }

}
