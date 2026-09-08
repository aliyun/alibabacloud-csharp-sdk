// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ListCategoriesRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the ticket category. Specify this parameter to return information about the subcategories of the specified category. If you leave this parameter empty, information about all categories in the instance is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>43c2671b-<em><b>-</b></em>-86d0-6bd187905cc8</para>
        /// </summary>
        [NameInMap("CategoryId")]
        [Validation(Required=false)]
        public string CategoryId { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccc-test</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The category type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ticket</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
