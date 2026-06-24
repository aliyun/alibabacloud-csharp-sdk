// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListInstanceIndicesRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to retrieve all indexes. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Returns the index list that includes system indexes.</para>
        /// </description></item>
        /// <item><description><para>false (default): Returns the index list that excludes system indexes.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("all")]
        [Validation(Required=false)]
        public bool? All { get; set; }

        /// <summary>
        /// <para>Specifies whether to display only managed indexes. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Displays only managed indexes.</para>
        /// </description></item>
        /// <item><description><para>false (default): Displays all indexes.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("isManaged")]
        [Validation(Required=false)]
        public bool? IsManaged { get; set; }

        /// <summary>
        /// <para>Specifies whether to display only OpenStore cold-phase indexes. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Displays only OpenStore cold-phase indexes.</para>
        /// </description></item>
        /// <item><description><para>false (default): Displays all indexes.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("isOpenstore")]
        [Validation(Required=false)]
        public bool? IsOpenstore { get; set; }

        /// <summary>
        /// <para>The index name. Fuzzy match is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>log-0001</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The page number of the instance list. Minimum value: 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        /// <summary>
        /// <para>The number of entries per page for paging. Maximum value: 100. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("size")]
        [Validation(Required=false)]
        public int? Size { get; set; }

    }

}
