// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class UpdateWhiteListRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the image repository.</para>
        /// <remarks>
        /// <para> You can call the <a href="~~PageImageRegistry~~">PageImageRegistry</a> operation to obtain the ID.</para>
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
        /// <para>The IP address whitelist. Separate multiple IP addresses with commas (,).</para>
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
