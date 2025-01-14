// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateDataAssetTagShrinkRequest : TeaModel {
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>key1</para>
        /// </summary>
        [NameInMap("Key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        [NameInMap("Managers")]
        [Validation(Required=false)]
        public string ManagersShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>String</para>
        /// </summary>
        [NameInMap("ValueType")]
        [Validation(Required=false)]
        public string ValueType { get; set; }

        [NameInMap("Values")]
        [Validation(Required=false)]
        public string ValuesShrink { get; set; }

    }

}
