// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetCanTrySasRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether the request is from the ECS console. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Yes.</description></item>
        /// <item><description><b>false</b>: No.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("FromEcs")]
        [Validation(Required=false)]
        public bool? FromEcs { get; set; }

        /// <summary>
        /// <para>Specifies the language of the request and response. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese.</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

    }

}
