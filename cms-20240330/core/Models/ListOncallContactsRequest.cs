// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ListOncallContactsRequest : TeaModel {
        /// <summary>
        /// <para>The timestamp of the on-call shift to query. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1730183838000</para>
        /// </summary>
        [NameInMap("timestamp")]
        [Validation(Required=false)]
        public string Timestamp { get; set; }

    }

}
