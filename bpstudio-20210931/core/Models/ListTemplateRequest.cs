// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BPStudio20210931.Models
{
    public class ListTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The keyword that is used to search for templates.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cadt</para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The number of the page to return.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public int? NextToken { get; set; }

        /// <summary>
        /// <para>The criterion by which the returned templates are sorted. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: The templates are sorted by the time when they are updated.</description></item>
        /// <item><description>2: The templates are sorted by the time when they are created.</description></item>
        /// <item><description>3: The templates are sorted by the system.</description></item>
        /// <item><description>4: The templates are sorted by the number of times that they are used.</description></item>
        /// <item><description>If you specify an integer other than 1, 2, 3, and 4 or do not specify any value, the templates are sorted by the system.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("OrderType")]
        [Validation(Required=false)]
        public long? OrderType { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmyjt3c5om3hi</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<ListTemplateRequestTag> Tag { get; set; }
        public class ListTemplateRequestTag : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The tag that you want to use to query templates.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TagList")]
        [Validation(Required=false)]
        [Obsolete]
        public int? TagList { get; set; }

        /// <summary>
        /// <para>The type of the templates to be returned. Valid values: public and private</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>public</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
