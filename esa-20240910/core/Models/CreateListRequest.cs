// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class CreateListRequest : TeaModel {
        /// <summary>
        /// <para>The description of the list that you want to create.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a custom list</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The items in the list that you want to create.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a custom list</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<string> Items { get; set; }

        /// <summary>
        /// <para>The type of the list that you want to create.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ip</para>
        /// </summary>
        [NameInMap("Kind")]
        [Validation(Required=false)]
        public string Kind { get; set; }

        /// <summary>
        /// <para>The name of the list that you want to create.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
