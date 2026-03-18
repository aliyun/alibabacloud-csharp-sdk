// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Starrocks20221019.Models
{
    public class RebootECSRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>8c96a3fc8a0d4a48b5db5fdb9742fbbc</para>
        /// </summary>
        [NameInMap("EventId")]
        [Validation(Required=false)]
        public string EventId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>c-b25e21e24388****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1772076782</para>
        /// </summary>
        [NameInMap("RebootTime")]
        [Validation(Required=false)]
        public long? RebootTime { get; set; }

    }

}
