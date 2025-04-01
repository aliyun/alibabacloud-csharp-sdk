// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class UnbindSlbRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0099b7be-5f5b-4512-a7fc-56049ef1****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>Specifies whether to disassociate the Internet-facing SLB instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: dissociates the Internet-facing SLB instance.</description></item>
        /// <item><description><b>false</b>: does not dissociate the Internet-facing SLB instance.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Internet")]
        [Validation(Required=false)]
        public bool? Internet { get; set; }

        /// <summary>
        /// <para>Specifies whether to disassociate the internal-facing SLB instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: dissociates the internal-facing SLB instance.</description></item>
        /// <item><description><b>false</b>: does not dissociate the internal-facing SLB instance.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Intranet")]
        [Validation(Required=false)]
        public bool? Intranet { get; set; }

    }

}
