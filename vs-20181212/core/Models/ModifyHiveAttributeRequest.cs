// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class ModifyHiveAttributeRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>gb-test</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hive-3b506f0868a7451ba15e0e890706033a</para>
        /// </summary>
        [NameInMap("HiveId")]
        [Validation(Required=false)]
        public string HiveId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>yy-test2</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
