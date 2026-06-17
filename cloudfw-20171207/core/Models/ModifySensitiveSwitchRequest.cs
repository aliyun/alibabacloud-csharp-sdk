// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class ModifySensitiveSwitchRequest : TeaModel {
        /// <summary>
        /// <para>The language of the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh</b> (default): Chinese</para>
        /// </description></item>
        /// <item><description><para><b>en</b>: English</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The type of sensitive data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>id_card</para>
        /// </summary>
        [NameInMap("SensitiveCategory")]
        [Validation(Required=false)]
        public string SensitiveCategory { get; set; }

        /// <summary>
        /// <para>The status of the switch. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>1</b>: on.</para>
        /// </description></item>
        /// <item><description><para><b>0</b>: off.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SwitchStatus")]
        [Validation(Required=false)]
        public string SwitchStatus { get; set; }

    }

}
