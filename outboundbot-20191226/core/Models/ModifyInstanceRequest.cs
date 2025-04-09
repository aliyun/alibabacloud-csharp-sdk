// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class ModifyInstanceRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>[&quot;95187&quot;]</para>
        /// </summary>
        [NameInMap("CallingNumber")]
        [Validation(Required=false)]
        public List<string> CallingNumber { get; set; }

        [NameInMap("InstanceDescription")]
        [Validation(Required=false)]
        public string InstanceDescription { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>90515b5-6115-4ccf-83e2-52d5bfaf2ddf</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("MaxConcurrentConversation")]
        [Validation(Required=false)]
        public int? MaxConcurrentConversation { get; set; }

    }

}
