// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Workorder20210610.Models
{
    public class EvaluateTicketRequest : TeaModel {
        /// <summary>
        /// <para>Comment</para>
        /// 
        /// <b>Example:</b>
        /// <para>The engineer solved my issue.</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>Rating star 1-5 stars</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Score")]
        [Validation(Required=false)]
        public string Score { get; set; }

        /// <summary>
        /// <para>Whether to resolve</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Solved")]
        [Validation(Required=false)]
        public bool? Solved { get; set; }

        /// <summary>
        /// <para>The ID of the ticket.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>001ET1BU1P</para>
        /// </summary>
        [NameInMap("TicketId")]
        [Validation(Required=false)]
        public string TicketId { get; set; }

        /// <summary>
        /// <para>UID</para>
        /// 
        /// <b>Example:</b>
        /// <para>1902070573958003</para>
        /// </summary>
        [NameInMap("Uid")]
        [Validation(Required=false)]
        public string Uid { get; set; }

    }

}
