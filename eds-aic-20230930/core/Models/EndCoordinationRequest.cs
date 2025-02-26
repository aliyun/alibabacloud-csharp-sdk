// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class EndCoordinationRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>lina</para>
        /// </summary>
        [NameInMap("CoordinatorUserId")]
        [Validation(Required=false)]
        public string CoordinatorUserId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>acp-2zecay9ponatdc4m****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xiaoming</para>
        /// </summary>
        [NameInMap("OwnerUserId")]
        [Validation(Required=false)]
        public string OwnerUserId { get; set; }

    }

}
