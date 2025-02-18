// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class LogisticsDetail : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2023-09-01 00:00:00</para>
        /// </summary>
        [NameInMap("ocurrTimeStr")]
        [Validation(Required=false)]
        public string OcurrTimeStr { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>已签收</para>
        /// </summary>
        [NameInMap("standerdDesc")]
        [Validation(Required=false)]
        public string StanderdDesc { get; set; }

    }

}
