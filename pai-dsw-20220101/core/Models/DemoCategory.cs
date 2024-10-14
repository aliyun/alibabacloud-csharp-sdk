// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dsw20220101.Models
{
    public class DemoCategory : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>sdk</para>
        /// </summary>
        [NameInMap("CategoryCode")]
        [Validation(Required=false)]
        public string CategoryCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>SDK Usage</para>
        /// </summary>
        [NameInMap("CategoryName")]
        [Validation(Required=false)]
        public string CategoryName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public long? Order { get; set; }

        [NameInMap("SubCategories")]
        [Validation(Required=false)]
        public List<DemoCategory> SubCategories { get; set; }

    }

}
