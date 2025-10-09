// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetDataQualityScanRunLogRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the data quality monitor run record.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10001</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The starting position of the log, in bytes, relative to the beginning of the file. Each query returns a maximum of 512 KB of content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Offset")]
        [Validation(Required=false)]
        public long? Offset { get; set; }

    }

}
