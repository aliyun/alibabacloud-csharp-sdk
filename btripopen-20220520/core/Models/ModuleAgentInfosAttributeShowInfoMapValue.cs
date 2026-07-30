// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class ModuleAgentInfosAttributeShowInfoMapValue : TeaModel {
        /// <summary>
        /// <para>The attribute code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FIRST_BAGGAGE</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The attribute name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>行李1</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The description text.</para>
        /// 
        /// <b>Example:</b>
        /// <para>行李详情</para>
        /// </summary>
        [NameInMap("text")]
        [Validation(Required=false)]
        public string Text { get; set; }

    }

}
