// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class SuspendCallRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("CalledNumbers")]
        [Validation(Required=false)]
        public List<string> CalledNumbers { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>f745881b-343d-43e4-9c51-31b7b063031c</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a5fc6490-ef1e-4666-870a-07a4e586c414</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
