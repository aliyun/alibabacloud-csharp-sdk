// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListInstanceCatalogRequest : TeaModel {
        /// <summary>
        /// <para>The language of the content within the request and response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>Specifies whether to filter the assets that support custom checks. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Filter assets that support custom checks.</description></item>
        /// <item><description><b>false</b>: All assets are selected. This is the default value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("OnlyCustom")]
        [Validation(Required=false)]
        public bool? OnlyCustom { get; set; }

        /// <summary>
        /// <para>The ID of the region in which the asset resides. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cn-hangzhou</b>: International</description></item>
        /// <item><description><b>ap-southeast-1</b>: Singapore</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The IDs of requirement items.</para>
        /// </summary>
        [NameInMap("RequirementIds")]
        [Validation(Required=false)]
        public List<long?> RequirementIds { get; set; }

        /// <summary>
        /// <para>The IDs of standards.</para>
        /// </summary>
        [NameInMap("StandardIds")]
        [Validation(Required=false)]
        public List<long?> StandardIds { get; set; }

        /// <summary>
        /// <para>List of task sources.</para>
        /// </summary>
        [NameInMap("TaskSources")]
        [Validation(Required=false)]
        public List<string> TaskSources { get; set; }

        /// <summary>
        /// <para>The types of check standards.</para>
        /// </summary>
        [NameInMap("Types")]
        [Validation(Required=false)]
        public List<string> Types { get; set; }

    }

}
