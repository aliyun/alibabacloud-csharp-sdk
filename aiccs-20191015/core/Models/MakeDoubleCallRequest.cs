// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class MakeDoubleCallRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345</para>
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;bizId&quot;: 123456}</para>
        /// </summary>
        [NameInMap("BizData")]
        [Validation(Required=false)]
        public string BizData { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>agent_***</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1502123****</para>
        /// </summary>
        [NameInMap("MemberPhone")]
        [Validation(Required=false)]
        public string MemberPhone { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0571000****</para>
        /// </summary>
        [NameInMap("OutboundCallNumber")]
        [Validation(Required=false)]
        public string OutboundCallNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>150****1234</para>
        /// </summary>
        [NameInMap("ServicerPhone")]
        [Validation(Required=false)]
        public string ServicerPhone { get; set; }

    }

}
