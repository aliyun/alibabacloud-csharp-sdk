// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateDataAssetTagRequest : TeaModel {
        /// <summary>
        /// <para>The description of the tag.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is a description</para>
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
        public List<string> Managers { get; set; }

        /// <summary>
        /// <para>The type of the tag value. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Boolean</description></item>
        /// <item><description>Int</description></item>
        /// <item><description>String</description></item>
        /// <item><description>Double</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>String</para>
        /// </summary>
        [NameInMap("ValueType")]
        [Validation(Required=false)]
        public string ValueType { get; set; }

        /// <summary>
        /// <para>The tag values.</para>
        /// </summary>
        [NameInMap("Values")]
        [Validation(Required=false)]
        public List<string> Values { get; set; }

    }

}
