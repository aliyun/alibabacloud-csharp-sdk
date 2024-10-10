// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class CreateTicketRequest : TeaModel {
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AccountType")]
        [Validation(Required=false)]
        public int? AccountType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0fc6a275c7f64f17b1****a306ce0f31</para>
        /// </summary>
        [NameInMap("CmptId")]
        [Validation(Required=false)]
        public string CmptId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public int? ExpireTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[{&quot;paramKey&quot;:&quot;price&quot;,&quot;joinType&quot;:&quot;and&quot;,&quot;conditionList&quot;:[{&quot;operate&quot;:&quot;&gt;&quot;,&quot;value&quot;:&quot;0&quot;}]}]</para>
        /// </summary>
        [NameInMap("GlobalParam")]
        [Validation(Required=false)]
        public string GlobalParam { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TicketNum")]
        [Validation(Required=false)]
        public int? TicketNum { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>46e537466****92704c8</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        [NameInMap("WatermarkParam")]
        [Validation(Required=false)]
        public string WatermarkParam { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a206f5f3-****-e9b17c835b03</para>
        /// </summary>
        [NameInMap("WorksId")]
        [Validation(Required=false)]
        public string WorksId { get; set; }

    }

}
