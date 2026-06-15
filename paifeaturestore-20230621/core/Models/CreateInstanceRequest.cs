// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiFeatureStore20230621.Models
{
    public class CreateInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The instance type. The only supported value is <c>Basic</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Basic</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
