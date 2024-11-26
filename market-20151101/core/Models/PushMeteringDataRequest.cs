// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Market20151101.Models
{
    public class PushMeteringDataRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>[{&quot;InstanceId&quot;:&quot;1000001&quot;,&quot;StartTime&quot;:&quot;100000000&quot;,&quot;EndTime&quot;:&quot;100000010&quot;,&quot;Entities&quot;:[{&quot;Key&quot;:&quot;PeriodMin&quot;,&quot;Value&quot;:&quot;96&quot;,&quot;meteringAssit&quot;:&quot;cmapi00060317-PeriodMin-4&quot;}]}]</para>
        /// </summary>
        [NameInMap("Metering")]
        [Validation(Required=false)]
        public string Metering { get; set; }

    }

}
