// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudcontrol20220830.Models
{
    public class ListResourceTypesHeaders : TeaModel {
        [NameInMap("commonHeaders")]
        [Validation(Required=false)]
        public Dictionary<string, string> CommonHeaders { get; set; }

        /// <summary>
        /// <para>Select the language in which the response is returned.</para>
        /// <para>zh_CH: Chinese (default).</para>
        /// <para>en_US: English.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh_CH</para>
        /// </summary>
        [NameInMap("x-acs-accept-language")]
        [Validation(Required=false)]
        public string XAcsAcceptLanguage { get; set; }

    }

}
