// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class ListMachinesResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of machines that are returned on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>The machines that are returned.</para>
        /// </summary>
        [NameInMap("machines")]
        [Validation(Required=false)]
        public List<Machine> Machines { get; set; }

        /// <summary>
        /// <para>The total number of machines.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
