// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CloneDataSourceResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the cloned data source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>19715</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>FCD583B9-346B-5E75-82C1-4A7C192C48DB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
