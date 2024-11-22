// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetListResponseBody : TeaModel {
        /// <summary>
        /// <para>The description of the custom list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a custom list</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of the custom list.<a href="~~2850217~~"></a></para>
        /// 
        /// <b>Example:</b>
        /// <para>40000001</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The items in the custom list, which are displayed as an array.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<string> Items { get; set; }

        /// <summary>
        /// <para>The type of the custom list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ip</para>
        /// </summary>
        [NameInMap("Kind")]
        [Validation(Required=false)]
        public string Kind { get; set; }

        /// <summary>
        /// <para>The name of the custom list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>36af3fcc-43d0-441c-86b1-428951dc8225</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The time when the custom list was last modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-01-01T00:00:00Z</para>
        /// </summary>
        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

    }

}
