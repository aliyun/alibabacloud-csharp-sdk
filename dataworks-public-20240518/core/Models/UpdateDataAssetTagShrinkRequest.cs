// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class UpdateDataAssetTagShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The description of the tag.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is a description.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The tag key.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>key1</para>
        /// </summary>
        [NameInMap("Key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        /// <summary>
        /// <para>The tag administrators.</para>
        /// </summary>
        [NameInMap("Managers")]
        [Validation(Required=false)]
        public string ManagersShrink { get; set; }

        /// <summary>
        /// <para>The tag values.</para>
        /// </summary>
        [NameInMap("Values")]
        [Validation(Required=false)]
        public string ValuesShrink { get; set; }

    }

}
