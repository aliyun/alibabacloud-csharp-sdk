// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListInstanceIndicesRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to retrieve all indices. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: returns a list of indices including system indices.</para>
        /// </description></item>
        /// <item><description><para>false: returns a list of indices excluding system indices. Default value: false.</para>
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
        /// <para>Specifies whether to view only managed indices. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: views only managed indices.</para>
        /// </description></item>
        /// <item><description><para>false: views all indices. Default value: false.</para>
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
        /// <para>Specifies whether to view only OpenStore cold-phase indices. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: views only OpenStore cold-phase indices.</para>
        /// </description></item>
        /// <item><description><para>false: views all indices. Default value: false.</para>
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
        /// <para>The page number. Minimum value: 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        /// <summary>
        /// <para>The paging Settings for the number of entries per page in a paged query. Maximum value: 100. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("size")]
        [Validation(Required=false)]
        public int? Size { get; set; }

    }

}
