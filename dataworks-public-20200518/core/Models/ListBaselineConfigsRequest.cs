// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListBaselineConfigsRequest : TeaModel {
        /// <summary>
        /// <para>The type of the baseline. Valid values: DAILY and HOURLY. Separate multiple baseline types with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>DAILY,HOURLY</para>
        /// </summary>
        [NameInMap("BaselineTypes")]
        [Validation(Required=false)]
        public string BaselineTypes { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account used by the baseline owner.</para>
        /// 
        /// <b>Example:</b>
        /// <para>95279527****</para>
        /// </summary>
        [NameInMap("Owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        /// <summary>
        /// <para>The page number. Valid values: 1 to 30. Default value: 1.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: 1 to 100. Default value: 10.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The priority of the baseline. Valid values: {1,3,5,7,8}. Separate multiple priorities with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1,3,5,7,8</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public string Priority { get; set; }

        /// <summary>
        /// <para>The workspace ID. You can call the ListProjects operation to query the ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The keyword in the baseline name, which is used to search for the baseline.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Baseline name search keywords</para>
        /// </summary>
        [NameInMap("SearchText")]
        [Validation(Required=false)]
        public string SearchText { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the baseline. Valid values: true and false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Useflag")]
        [Validation(Required=false)]
        public bool? Useflag { get; set; }

    }

}
