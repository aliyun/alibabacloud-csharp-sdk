// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateVpconnFromVbrResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5356F028-0F5C-56FC-8574-897D24379041</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the hosted connection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-bp1mrgfbtmc9brre7****</para>
        /// </summary>
        [NameInMap("VirtualPhysicalConnection")]
        [Validation(Required=false)]
        public string VirtualPhysicalConnection { get; set; }

    }

}
