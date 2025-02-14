// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class UpdateWhiteListRequest : TeaModel {
        /// <summary>
        /// <para>Image repository ID.</para>
        /// <remarks>
        /// <para>You can obtain this parameter by calling the <a href="~~PageImageRegistry~~">PageImageRegistry</a> interface.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>19882</para>
        /// </summary>
        [NameInMap("RegistryId")]
        [Validation(Required=false)]
        public long? RegistryId { get; set; }

        /// <summary>
        /// <para>Whitelist list. If there are multiple whitelisted addresses, separate them with a comma (,).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.XXX.XXX,192.180.XXX.XXX</para>
        /// </summary>
        [NameInMap("WhiteList")]
        [Validation(Required=false)]
        public string WhiteList { get; set; }

    }

}
