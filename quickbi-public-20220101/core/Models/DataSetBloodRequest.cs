// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class DataSetBloodRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>234235234,234235235,234235235</para>
        /// </summary>
        [NameInMap("DataSetIds")]
        [Validation(Required=false)]
        public string DataSetIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dasasgaj342351</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>PAGE</para>
        /// </summary>
        [NameInMap("WorksType")]
        [Validation(Required=false)]
        public string WorksType { get; set; }

    }

}
