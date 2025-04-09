// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class CreateInstanceRequest : TeaModel {
        [NameInMap("CallingNumber")]
        [Validation(Required=false)]
        public List<string> CallingNumber { get; set; }

        [NameInMap("InstanceDescription")]
        [Validation(Required=false)]
        public string InstanceDescription { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("MaxConcurrentConversation")]
        [Validation(Required=false)]
        public int? MaxConcurrentConversation { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Provided</para>
        /// </summary>
        [NameInMap("NluServiceType")]
        [Validation(Required=false)]
        public string NluServiceType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>rg-acfmwd4qr3z773y</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
