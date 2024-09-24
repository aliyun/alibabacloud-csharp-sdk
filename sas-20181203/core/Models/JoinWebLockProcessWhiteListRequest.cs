// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class JoinWebLockProcessWhiteListRequest : TeaModel {
        /// <summary>
        /// <para>The paths of the processes.</para>
        /// </summary>
        [NameInMap("ProcessPaths")]
        [Validation(Required=false)]
        public List<string> ProcessPaths { get; set; }

        /// <summary>
        /// <para>The UUIDs of the servers on which the processes run. Separate multiple UUIDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>0c1714dc-f7a3-4265-8364-7aa3fce8****,1cc45e7d-7698-4b2c-89d8-e8cba407****</para>
        /// </summary>
        [NameInMap("Uuids")]
        [Validation(Required=false)]
        public string Uuids { get; set; }

    }

}
