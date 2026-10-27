// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class WaIdPermissions : TeaModel {
        /// <summary>
        /// <para>code</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>basic</para>
        /// </summary>
        [NameInMap("IsBasicChild")]
        [Validation(Required=false)]
        public bool? IsBasicChild { get; set; }

        /// <summary>
        /// <para>name</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>subPermissions</para>
        /// </summary>
        [NameInMap("SubPermissions")]
        [Validation(Required=false)]
        public List<WaIdPermissions> SubPermissions { get; set; }

        /// <summary>
        /// <para>type</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
