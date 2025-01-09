// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class CreateRoutineRequest : TeaModel {
        /// <summary>
        /// <para>The routine description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>the description of this routine</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The routine name, which must be unique in the same account.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-routine1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The specification of the routine.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5ms</para>
        /// </summary>
        [NameInMap("SpecName")]
        [Validation(Required=false)]
        public string SpecName { get; set; }

    }

}
