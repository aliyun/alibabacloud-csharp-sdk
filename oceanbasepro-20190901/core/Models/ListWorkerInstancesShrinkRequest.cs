// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class ListWorkerInstancesShrinkRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>KAFKA</para>
        /// </summary>
        [NameInMap("DestType")]
        [Validation(Required=false)]
        public string DestType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>i4katz****</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("OnlyBindable")]
        [Validation(Required=false)]
        public bool? OnlyBindable { get; set; }

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

        /// <summary>
        /// <b>Example:</b>
        /// <para>OCEANBASE</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        [NameInMap("Specs")]
        [Validation(Required=false)]
        public string SpecsShrink { get; set; }

    }

}
