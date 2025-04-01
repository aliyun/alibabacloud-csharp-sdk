// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class UnbindNlbRequest : TeaModel {
        /// <summary>
        /// <para>A short description of struct</para>
        /// 
        /// <b>Example:</b>
        /// <para>7171a6ca-d1cd-4928-8642-7d5cfe69****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The ID of NLB instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nlb-7z7jjbzz44d82c9***</para>
        /// </summary>
        [NameInMap("NlbId")]
        [Validation(Required=false)]
        public string NlbId { get; set; }

        /// <summary>
        /// <para>The listener port of the instance. Valid values: 0 to 65535.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3306</para>
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public int? Port { get; set; }

        /// <summary>
        /// <para>The type of the protocol. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>TCP</b>.</description></item>
        /// <item><description><b>UDP</b>.</description></item>
        /// <item><description><b>TCPSSL</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>TCP</para>
        /// </summary>
        [NameInMap("Protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

    }

}
