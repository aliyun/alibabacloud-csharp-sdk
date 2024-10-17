// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180208.Models
{
    public class SelectedDomainListRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20231109</para>
        /// </summary>
        [NameInMap("ListDate")]
        [Validation(Required=false)]
        public string ListDate { get; set; }

    }

}
