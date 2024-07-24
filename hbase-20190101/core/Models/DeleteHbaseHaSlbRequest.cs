// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class DeleteHbaseHaSlbRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bds-t4n3496whj23ia4k</para>
        /// </summary>
        [NameInMap("BdsId")]
        [Validation(Required=false)]
        public string BdsId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ha-v21tmnxjwh2yuy1il</para>
        /// </summary>
        [NameInMap("HaId")]
        [Validation(Required=false)]
        public string HaId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>thrift</para>
        /// </summary>
        [NameInMap("HaTypes")]
        [Validation(Required=false)]
        public string HaTypes { get; set; }

    }

}
