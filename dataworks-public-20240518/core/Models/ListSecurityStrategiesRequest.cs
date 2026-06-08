// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListSecurityStrategiesRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>DataQuery</para>
        /// </summary>
        [NameInMap("ControlModule")]
        [Validation(Required=false)]
        public string ControlModule { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>MyCatalog</para>
        /// </summary>
        [NameInMap("ControlSubModule")]
        [Validation(Required=false)]
        public string ControlSubModule { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
