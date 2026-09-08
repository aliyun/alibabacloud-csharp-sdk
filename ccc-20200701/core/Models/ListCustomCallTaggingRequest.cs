// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ListCustomCallTaggingRequest : TeaModel {
        /// <summary>
        /// <para>Filter by a list of number tag names. This parameter is optional and defaults to empty, which means no filtering is applied. The format is a JSON array string, where each array element is a number tag name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;TagA&quot;]</para>
        /// </summary>
        [NameInMap("CallTagNameList")]
        [Validation(Required=false)]
        public string CallTagNameList { get; set; }

        /// <summary>
        /// <para>Instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccc-test</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Page number, ranging from 1 to 100.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>Page size, ranging from 1 to 100.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Perform fuzzy matching based on number or description. This parameter is optional and defaults to empty. An empty value indicates no filtering.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1312121****</para>
        /// </summary>
        [NameInMap("SearchPattern")]
        [Validation(Required=false)]
        public string SearchPattern { get; set; }

    }

}
