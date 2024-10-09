// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class UpdateUdfArtifactRequest : TeaModel {
        /// <summary>
        /// <para>The details of the JAR file of the UDF.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public UdfArtifact Body { get; set; }

    }

}
