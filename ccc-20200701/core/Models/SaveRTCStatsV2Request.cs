// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class SaveRTCStatsV2Request : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>257e73de-1ee8-123b-0b9a-00163e0a****</para>
        /// </summary>
        [NameInMap("CallId")]
        [Validation(Required=false)]
        public string CallId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("GeneralInfo")]
        [Validation(Required=false)]
        public string GeneralInfo { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;47.101.XX.XX&quot;,&quot;44368&quot;,&quot;47.104.XX.XX&quot;,&quot;37947&quot;]</para>
        /// </summary>
        [NameInMap("GoogAddress")]
        [Validation(Required=false)]
        public string GoogAddress { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccc-test</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;1&quot;,&quot;1649328987&quot;,&quot;40&quot;,&quot;PCMU&quot;,&quot;383560&quot;,&quot;89&quot;,&quot;49&quot;,&quot;ssrc_1649328987_recv&quot;,&quot;2022-03-15T09:52:08.820Z&quot;,&quot;&quot;,&quot;0&quot;,&quot;20000&quot;]</para>
        /// </summary>
        [NameInMap("ReceiverReport")]
        [Validation(Required=false)]
        public string ReceiverReport { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;11090&quot;,&quot;2055127460&quot;,&quot;0&quot;,&quot;2236&quot;,&quot;384592&quot;,&quot;ssrc_2055127460_send&quot;,&quot;2022-03-15T09:52:08.820Z&quot;,&quot;1&quot;]</para>
        /// </summary>
        [NameInMap("SenderReport")]
        [Validation(Required=false)]
        public string SenderReport { get; set; }

    }

}
