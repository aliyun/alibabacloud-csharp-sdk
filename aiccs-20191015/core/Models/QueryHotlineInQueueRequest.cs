// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class QueryHotlineInQueueRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("OuterGroupId")]
        [Validation(Required=false)]
        public string OuterGroupId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mybank</para>
        /// </summary>
        [NameInMap("OuterGroupType")]
        [Validation(Required=false)]
        public string OuterGroupType { get; set; }

    }

}
