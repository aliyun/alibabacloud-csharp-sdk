// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class CreateInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The description of the instance. The description can be up to 128 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>instance_for_test</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

    }

}
