// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class GetHotlineCallActionRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;time&quot;:1}</para>
        /// </summary>
        [NameInMap("Acc")]
        [Validation(Required=false)]
        public string Acc { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="mailto:username@example.com">username@example.com</a></para>
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Act")]
        [Validation(Required=false)]
        public int? Act { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;name&quot;:123}</para>
        /// </summary>
        [NameInMap("Biz")]
        [Validation(Required=false)]
        public string Biz { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>46c1341e-2648-447a-9b11-70b6a298d9****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>hotlinebs_out</para>
        /// </summary>
        [NameInMap("FromSource")]
        [Validation(Required=false)]
        public string FromSource { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccc_xp_pre-cn-***</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
