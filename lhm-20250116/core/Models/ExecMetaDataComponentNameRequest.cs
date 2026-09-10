// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.LHM20250116.Models
{
    public class ExecMetaDataComponentNameRequest : TeaModel {
        /// <summary>
        /// <para>The datasource name to check. The system performs an exact match against non-deleted datasources under the current tenant.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_ds318_hangzhou_0428</para>
        /// </summary>
        [NameInMap("dsName")]
        [Validation(Required=false)]
        public string DsName { get; set; }

    }

}
