// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class DataResultValue : TeaModel {
        /// <summary>
        /// <para>The SQL template ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>61f45ee381b2fa4e8a6545e3bee9</para>
        /// </summary>
        [NameInMap("sqlId")]
        [Validation(Required=false)]
        public string SqlId { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-xxx</para>
        /// </summary>
        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The number of errors.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

    }

}
