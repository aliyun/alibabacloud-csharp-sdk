// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class DeleteRoutineCodeVersionRequest : TeaModel {
        /// <summary>
        /// <para>The code version.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1710120201067203242</para>
        /// </summary>
        [NameInMap("CodeVersion")]
        [Validation(Required=false)]
        public string CodeVersion { get; set; }

        /// <summary>
        /// <para>The routine name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-routine1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
